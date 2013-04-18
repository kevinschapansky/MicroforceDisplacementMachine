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

        public int XMovement
        {
            get { return _XMoveSinceLastRst; }
        }

        public int YMovement
        {
            get { return _YMoveSinceLastRst; }
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

        private int XRes = FiveHundredMicrons;
        private int YRes = FiveHundredMicrons;
        private int ZRes = FiveHundredMicrons;

        private int _XMoveSinceLastRst;
        private int _YMoveSinceLastRst;

        public StageController()
        {
            XCommunicator = new StageSerialCom(XPort);
            YZCommunicator = new StageSerialCom(YZPort);

            XAxisController = new XAxis(XCommunicator, XLChannel, XRChannel);
            YAxisController = new YAxis(YZCommunicator, YChannel);
            ZAxisController = new ZAxis(YZCommunicator, ZChannel);
        }

        public void ResetMovement()
        {
            _XMoveSinceLastRst = 0;
            _YMoveSinceLastRst = 0;
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
            ZNegative(HalfMicron);
        }

        public void ZPositiveAuto()
        {
            ZPositive(HalfMicron);
        }

        public void ZNegative()
        {
            ZNegative(ZResolution);
        }

        public void ZPositive() 
        {
            ZPositive(ZResolution);
        }

        public void XNegative(int encoderUnits)
        {
            _XMoveSinceLastRst += -1 * encoderUnits;
            XAxisController.Move(-1 * encoderUnits);
        }

        public void XPositive(int encoderUnits)
        {
            _XMoveSinceLastRst += encoderUnits;
            XAxisController.Move(encoderUnits);
        }

        public void XNegative()
        {
            XNegative(XResolution);
        }

        public void XPositive()
        {
            XPositive(XResolution);
        }

        public void YNegative(int encoderUnits)
        {
            _YMoveSinceLastRst += -1 * encoderUnits;
            YAxisController.Move(-1 * encoderUnits);
        }

        public void YPositive(int encoderUnits)
        {
            _YMoveSinceLastRst += encoderUnits;
            YAxisController.Move(encoderUnits);
        }

        public void YNegative()
        {
            YNegative(YResolution);
        }

        public void YPositive()
        {
            YPositive(YResolution);
        }
    }
}
