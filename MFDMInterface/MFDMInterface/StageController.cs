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

        public int ZResolution
        {
            get { return ZRes; }
            set { ZRes = value; }
        }

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

        public static int OneMillimeter = 28275;
        public static int FiveHundredMicrons = 14137;
        public static int OneMicron = 28;
        public static int HalfMicron = 14;

        private int XRes = 3000;
        private int YRes = 3000;
        private int ZRes = FiveHundredMicrons;

        private int XFRes = OneMillimeter;
        private int YFRes = OneMillimeter;

        public StageController()
        {
            XCommunicator = new StageSerialCom(XPort);
            YZCommunicator = new StageSerialCom(YZPort);

            XAxisController = new XAxis(XCommunicator, XLChannel, XRChannel);
            YAxisController = new YAxis(YZCommunicator, YChannel);
            ZAxisController = new ZAxis(YZCommunicator, ZChannel);
        }

        public void ZNegative(int encoderUnits)
        {
            ZAxisController.Move(encoderUnits);
        }

        public void ZPositive(int encoderUnits)
        {
            ZAxisController.Move(-1 * encoderUnits);
        }

        public void ZNegativeAuto()
        {
            ZAxisController.Move(HalfMicron);
        }

        public void ZPositiveAuto()
        {
            ZAxisController.Move(-1 * HalfMicron);
        }

        public void ZNegative()
        {
            ZAxisController.Move(ZResolution);
        }

        public void ZPositive() 
        {
            ZAxisController.Move(-1 * ZResolution);
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
