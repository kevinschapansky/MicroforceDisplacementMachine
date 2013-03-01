using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class StageAxis
    {
        private List<StageSerialCom> SerialComms;

        public StageAxis(List<string> comPorts)
        {
            foreach (string com in comPorts)
            {
                SerialComms.Add(new StageSerialCom(com));
            }
        }

        public void Move(int uM)
        {
            throw new Exception("Move not overridden");
        }
    }
}
