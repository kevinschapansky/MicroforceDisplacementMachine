using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class ZAxis : StageAxis
    {
        private int ZChannel;

        public ZAxis(StageSerialCom comm, int stageChannel)
            : base(comm)
        {
            ZChannel = stageChannel;
        }

        public void Move(int uM)
        {
            SerialComm.MoveRelative(ZChannel, uM);
        }
    }
}
