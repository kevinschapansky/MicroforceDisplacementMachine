using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class StageController
    {
        public static string XPort = "COM4";
        public static string YZPort = "COM5";

        public static int XLChannel = 2;
        public static int XRChannel = 1;
        public static int ZChannel = 2;
        public static int YChannel = 1;

        public int XResolution 
        { 
            get { return XRes; } 
            set { XRes = value; } 
        }

        public int YResolution
        {
            get { return YRes; }
            set { YRes = value; }
        }

        public int XFResolution
        {
            get { return XFRes; }
            set { XFRes = value; }
        }

        public int YFResolution
        {
            get { return YFRes; }
            set { YFRes = value; }
        }

        StageSerialCom XCommunicator;
        StageSerialCom YZCommunicator;

        private XAxis XAxisController;
        private YAxis YAxisController;
        private ZAxis ZAxisController;

        private int XRes = 3000;
        private int YRes = 3000;

        private int XFRes = 28275;
        private int YFRes = 28275;

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
            XAxisController.Move(-1 * XResolution);
        }

        public void XPositive()
        {
            XAxisController.Move(XResolution);
        }

        public void YNegative()
        {
            YAxisController.Move(-1 * YResolution);
        }

        public void YPositive()
        {
            YAxisController.Move(YResolution);
        }

        public void XFNegative()
        {
            XAxisController.Move(-1 * XFResolution);
        }

        public void XFPositive()
        {
            XAxisController.Move(XFResolution);
        }

        public void YFNegative()
        {
            YAxisController.Move(-1 * YFResolution);
        }

        public void YFPositive()
        {
            YAxisController.Move(YFResolution);
        }
    }
}
