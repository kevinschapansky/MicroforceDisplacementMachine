using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class StageAxis
    {
        protected StageSerialCom SerialComm;

        public StageAxis(StageSerialCom comm)
        {
            SerialComm = comm;
        }
    }
}
