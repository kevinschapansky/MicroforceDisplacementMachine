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
        static const int BAUD = 19200;

        SerialPort StagePort;

        public StageSerialCom(string comPort)
        {
            StagePort = new SerialPort(comPort);
            StagePort.BaudRate = BAUD;
            StagePort.Parity = Parity.None;
            StagePort.DataBits = 8;
            StagePort.StopBits = StopBits.None;
            StagePort.Handshake = Handshake.XOnXOff;

            StagePort.Open();
        }
    }
}
