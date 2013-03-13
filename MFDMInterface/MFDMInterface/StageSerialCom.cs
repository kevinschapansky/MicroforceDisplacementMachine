using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace MFDMInterface
{
    class StageSerialCom
    {
        const int BAUD = 19200;

        SerialPort StagePort;

        public StageSerialCom(string comPort)
        {
            StagePort = new SerialPort(comPort);
            StagePort.BaudRate = BAUD;
            StagePort.Parity = Parity.None;
            StagePort.DataBits = 8;
            StagePort.StopBits = StopBits.One;
            StagePort.Handshake = Handshake.XOnXOff;

            StagePort.Open();

            SetUnits(1, 0);
            SetUnits(2, 0);
            SetResolution(1, 1);
            SetResolution(2, 1);

            SetMaxAccDec(1, 50000);
            SetMaxAccDec(2, 50000);

            SetAcceleration(1, 50000);
            SetAcceleration(2, 50000);
            SetDeceleration(1, 50000);
            SetDeceleration(2, 50000);

            SetMaxVelocity(1, 141374);
            SetMaxVelocity(2, 141374);

            SetVelocity(1, 70000);
            SetVelocity(2, 70000);
        }

        public void SendCommand(int stageNum, string command, int setting)
        {
            StagePort.Write(stageNum + command + setting + "\r");
        }

        public void SetMaxVelocity(int stageNum, int maxVelocity)
        {
            SendCommand(stageNum, "VU", maxVelocity);
        }

        public void SetVelocity(int stageNum, int velocity)
        {
           SendCommand(stageNum, "VA", velocity);
        }

        public void SetResolution(int stageNum, int resolution)
        {
            SendCommand(stageNum, "SU", resolution);
        }

        public void SetAcceleration(int stageNum, int acceleration)
        {
            SendCommand(stageNum, "AC", acceleration);
        }

        public void SetDeceleration(int stageNum, int deceleration)
        {
            SendCommand(stageNum, "AG", deceleration);
        }

        public void MoveRelative(int stageNum, int units)
        {
            SendCommand(stageNum, "PR", units);
        }

        public void SetMaxAccDec(int stageNum, int accDec)
        {
            SendCommand(stageNum, "AU", accDec);
        }

        public void SetUnits(int stageNum, int units)
        {
            SendCommand(stageNum, "SN", units);
        }
    }
}
