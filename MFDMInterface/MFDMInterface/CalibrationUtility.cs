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

        public CalibrationUtility(StageController stageCont, string comPort)
        {
            MovementController = stageCont;

            BalancePort = new SerialPort(comPort);
            BalancePort.BaudRate = 9600;
            BalancePort.Parity = Parity.None;
            BalancePort.DataBits = 8;
            BalancePort.StopBits = StopBits.One;
            BalancePort.Handshake = Handshake.None;

            BalancePort.Open();
        }

        public void GenerateBalanceCalibrationData()
        {
            float curPressure;
            char[] splitChars = { ' ' };
            string result;
            string[] splitResult;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\microfab\Desktop\CalibrationOutput.txt");

            do
            {
                MovementController.ZNegativeAuto();
                System.Threading.Thread.Sleep(5000);
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
                file.WriteLine(curPressure);
            } while (curPressure <= 10.0);
            file.Close();
        }
    }
}
