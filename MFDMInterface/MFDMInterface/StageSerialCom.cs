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

            SendCommand(1, "SN", 3);
            SendCommand(2, "SN", 3);
            SetResolution(1, 10);
            SetResolution(2, 10);
            SetMaxVelocity(1, 100);
            SetMaxVelocity(2, 100);
            SetVelocity(1, 100);
            SetVelocity(2, 100);
            SetAcceleration(1, 50);
            SetAcceleration(2, 50);
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

        public void MoveRelative(int stageNum, int units)
        {
            SendCommand(stageNum, "PR", units);
        }
    }
}
