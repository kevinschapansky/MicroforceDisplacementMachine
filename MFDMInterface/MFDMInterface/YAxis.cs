using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class YAxis : StageAxis
    {
        private int YChannel;

        public YAxis(StageSerialCom comm, int stageChannel)
            : base(comm)
        {
            YChannel = stageChannel;
        }

        public void Move(int uM)
        {
            SerialComm.MoveRelative(YChannel, uM);
        }
    }
}
