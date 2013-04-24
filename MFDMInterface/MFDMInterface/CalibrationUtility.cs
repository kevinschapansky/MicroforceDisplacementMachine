using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace MFDMInterface
{
    class CalibrationUtility
    {
        private StageController MovementController;
        private SerialPort BalancePort;
        private SerialPort KeithleyPort;

        public int XOffset;
        public int YOffset;

        public delegate void DataUpdateDelegate(float displacement, float voltage);

        public CalibrationUtility(StageController stageCont, string balancePort, string keithleyPort)
        {
            XOffset = 892985;
            YOffset = -69572;

            MovementController = stageCont;

            BalancePort = new SerialPort(balancePort);
            BalancePort.BaudRate = 9600;
            BalancePort.Parity = Parity.None;
            BalancePort.DataBits = 8;
            BalancePort.StopBits = StopBits.One;
            BalancePort.Handshake = Handshake.None;

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

        public void OpenPorts()
        {
            KeithleyPort.Open();
            SetupKeithley();
            BalancePort.Open();
        }

        public void ClosePorts()
        {
            KeithleyPort.Close();
            BalancePort.Close();
        }

        public void GenerateBalanceKeithleyCalibrationData(DataUpdateDelegate graphUpdate, float stopValue, int readingDelay, int stepSize, string outFile)
        {
            float curPressure;
            char[] splitChars = { ' ' };
            string result;
            string[] splitResult;
            float displacement = 0;
            string strVolt;
            
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\microfab\Desktop\" + outFile);

            do
            {
                MovementController.ZNegative(stepSize);
                displacement += stepSize;
                System.Threading.Thread.Sleep(readingDelay);
                BalancePort.Write("!KP\r");
                result = BalancePort.ReadLine();
                splitResult = result.Split(splitChars);

                foreach (string str in splitResult)
                {
                    if (str.Contains('.'))
                    {
                        result = str;
                        break;
                    }
                }
                curPressure = float.Parse(result, System.Globalization.CultureInfo.InvariantCulture);
                KeithleyPort.Write(":READ?\r");
                strVolt = KeithleyPort.ReadLine();
                file.Write(curPressure + "," + strVolt);
                graphUpdate(displacement, float.Parse(strVolt, System.Globalization.CultureInfo.InvariantCulture));
            } while (curPressure <= stopValue);
            file.Close();
        }
    }
}
