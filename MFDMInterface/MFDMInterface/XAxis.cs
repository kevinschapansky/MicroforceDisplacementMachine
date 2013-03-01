using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class XAxis : StageAxis
    {
        private int StageL;
        private int StageR;

        public XAxis(StageSerialCom comm, int leftChannel, int rightChannel) 
            : base(comm)
        {
            StageL = leftChannel;
            StageR = rightChannel;
        }

        public void Move(int uM)
        {
            int L = uM / 2;
            int R = uM / 2 + uM % 2;

            SerialComm.MoveRelative(StageL, L);
            SerialComm.MoveRelative(StageR, R);
        }
    }
}
