using System;
using System.Threading;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class TestingUtility
    {
        private static StageController MovementController;
        private static SerialPort KeithleyPort;
        public static Boolean KeepRunningTest;

        public delegate void DataUpdateDelegate(float displacement, float voltage);

        private class TestRunner
        {
            private DataUpdateDelegate GraphUpdate;
            private float StopVoltage;
            private int ReadingDelay;
            private int StepSize;
            private string OutFile;

            public TestRunner(DataUpdateDelegate graphUpdate, float stopVoltage, int readingDelay, int stepSize, string outFile)
            {
                GraphUpdate = graphUpdate;
                StopVoltage = stopVoltage;
                ReadingDelay = readingDelay;
                StepSize = stepSize;
                OutFile = outFile;
            }

            public void RunTest()
            {
                float curVoltage;
                float displacement = 0;
                string strVolt;

                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\microfab\Desktop\" + OutFile);
                file.Write("Stop Voltage: " + StopVoltage + " (v) Reading Delay: " + ReadingDelay + " (ms) Step Size: " + StepSize + " (en)\n");

                do
                {
                    MovementController.ZNegative(StepSize);
                    displacement += StepSize;
                    System.Threading.Thread.Sleep(ReadingDelay);

                    KeithleyPort.Write(":READ?\r");
                    strVolt = KeithleyPort.ReadLine();
                    file.Write(displacement + "," + strVolt);
                    curVoltage = float.Parse(strVolt, System.Globalization.CultureInfo.InvariantCulture);
                    GraphUpdate(displacement, curVoltage);
                } while (curVoltage >= StopVoltage && KeepRunningTest);
                file.Close();
                KeithleyPort.Close();
            }
        }

        public TestingUtility(StageController stageCont, string keithleyPort)
        {
            MovementController = stageCont;

            KeithleyPort = new SerialPort(keithleyPort);
            KeithleyPort.BaudRate = 19200;
            KeithleyPort.Parity = Parity.None;
            KeithleyPort.DataBits = 8;
            KeithleyPort.StopBits = StopBits.One;
            KeithleyPort.Handshake = Handshake.None;
        }

        public void SetupKeithley()
        {
            KeithleyPort.Write("*RST\r");
            KeithleyPort.Write(":SENS:FUNC 'VOLT'\r");
            KeithleyPort.Write(":SENS:RES:NPLC 1\r");
            KeithleyPort.Write(":SENS:RES:MODE MAN\r");
            KeithleyPort.Write(":SENS:VOLT:PROT 100\r");
            KeithleyPort.Write(":SOUR:CLE:AUTO ON\r");
            KeithleyPort.Write(":TRIG:COUN 1\r");
            KeithleyPort.Write(":FORM:ELEM VOLT\r");
            KeithleyPort.Write(":OUTP ON\r");
            KeithleyPort.Write(":READ?\r");
        }

        public void RunTest(DataUpdateDelegate graphUpdate, float stopVoltage, int readingDelay, int stepSize, string outFile)
        {
            TestRunner runner = new TestRunner(graphUpdate, stopVoltage, readingDelay, stepSize, outFile);
            Thread tThread = new Thread(new ThreadStart(runner.RunTest));

            KeepRunningTest = true;
            tThread.Start();
        }

        public void MoveToTestPosition(int xOffset, int yOffset)
        {
            MovementController.XPositive(-xOffset);
            MovementController.YPositive(-yOffset);
        }

        public void OpenPort()
        {
            KeithleyPort.Open();
            SetupKeithley();
        }

        public void ClosePort()
        {
            KeithleyPort.Close();
        }
    }
}
