using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class StageController
    {
        public static string XPort = "COMX";
        public static string YZPort = "COMX";

        public static int XLChannel = 2;
        public static int XRChannel = 1;
        public static int ZChannel = 2;
        public static int YChannel = 1;

        StageSerialCom XCommunicator;
        StageSerialCom YZCommunicator;

        private XAxis XAxisController;
        private YAxis YAxisController;
        private ZAxis ZAxisController;

        public StageController()
        {
            XCommunicator = new StageSerialCom(XPort);
            YZCommunicator = new StageSerialCom(YZPort);

            XAxisController = new XAxis(XCommunicator, XLChannel, XRChannel);
            YAxisController = new YAxis(YZCommunicator, YChannel);
            ZAxisController = new ZAxis(YZCommunicator, ZChannel);
        }

        public void XNegative()
        {

        }

        public void XPositive()
        {

        }

        public void YNegative()
        {

        }

        public void YPositive()
        {

        }
    }
}
