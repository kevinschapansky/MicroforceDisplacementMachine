using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFDMInterface
{
    class StageController : INotifyPropertyChanged
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
            private set
            {
                _XMoveSinceLastRst = value;
                FormattedXMovement = "Actual X Offset: " + value + " (en)";
            }
        }

        public int YMovement
        {
            get { return _YMoveSinceLastRst; }
            private set
            {
                _YMoveSinceLastRst = value;
                FormattedYMovement = "Actual Y Offset: " + value + " (en)";
            }
        }

        public string FormattedXMovement
        {
            get { return _FormattedX; }
            private set
            {
                _FormattedX = value;
                OnPropertyChanged("FormattedXMovement");
            }
        }

        public string FormattedYMovement
        {
            get { return _FormattedY; }
            private set
            {
                _FormattedY = value;
                OnPropertyChanged("FormattedYMovement");
            }
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

        private string _FormattedX;
        private string _FormattedY;

        public event PropertyChangedEventHandler PropertyChanged;

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
            XMovement = 0;
            YMovement = 0;
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
            XMovement += -1 * encoderUnits;
            XAxisController.Move(-1 * encoderUnits);
        }

        public void XPositive(int encoderUnits)
        {
            XMovement += encoderUnits;
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
            YMovement += -1 * encoderUnits;
            YAxisController.Move(-1 * encoderUnits);
        }

        public void YPositive(int encoderUnits)
        {
            YMovement += encoderUnits;
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

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
