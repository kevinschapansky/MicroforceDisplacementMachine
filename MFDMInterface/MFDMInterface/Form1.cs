using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFDMInterface
{
    public partial class Form1 : Form
    {
        private StageController MovementController;
        private CalibrationUtility CalUtill;

        public Form1()
        {
            InitializeComponent();
            MovementController = new StageController();
            CalUtill = new CalibrationUtility(MovementController, "COM3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!icImagingControl1.DeviceValid)
            {
                icImagingControl1.ShowDeviceSettingsDialog();

                if (!icImagingControl1.DeviceValid)
                {
                    MessageBox.Show("No device was selected.", "Grabbing an Image",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                int width = icImagingControl1.Width;
                int height = icImagingControl1.Height;
                icImagingControl1.LiveDisplayDefault = false;
                icImagingControl1.LiveDisplayHeight = icImagingControl1.Height;
                icImagingControl1.LiveDisplayWidth = icImagingControl1.Width;
                icImagingControl1.OverlayBitmap.Enable = true;
                icImagingControl1.OverlayBitmap.ColorMode = TIS.Imaging.OverlayColorModes.Color;
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red,width / 2 - 10, height / 2, width / 2 + 10, height / 2);
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2, height / 2 - 10, width / 2, height / 2 + 10);
                icImagingControl1.LiveStart();
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            MovementController.XNegative();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            MovementController.YPositive();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            MovementController.XPositive();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            MovementController.YNegative();
        }

        private void FUp_Click(object sender, EventArgs e)
        {
            MovementController.YFPositive();
        }

        private void FRight_Click(object sender, EventArgs e)
        {
            MovementController.XFPositive();
        }

        private void FDown_Click(object sender, EventArgs e)
        {
            MovementController.YFNegative();
        }

        private void FLeft_Click(object sender, EventArgs e)
        {
            MovementController.XFNegative();
        }

        private void sldZoom_Scroll(object sender, EventArgs e)
        {
            if (icImagingControl1.LiveDisplayDefault == false)
            {
                icImagingControl1.LiveDisplayZoomFactor = (float)sldZoom.Value / 10.0f;
                lblZoomPercent.Text = (sldZoom.Value * 10).ToString() + "%";
                icImagingControl1.LiveDisplayPosition = new Point((-1 * icImagingControl1.LiveDisplayWidth / 2) + icImagingControl1.Width / 2,
                    (-1 * icImagingControl1.LiveDisplayHeight / 2) + icImagingControl1.Height / 2);
            }
            else
            {
                MessageBox.Show("The zoom factor can only be set" + "\n" + "if LiveDisplayDefault returns False!");
            }
        }

        private void probeUp_Click(object sender, EventArgs e)
        {
            MovementController.ZPositive();
        }

        private void probeDown_Click(object sender, EventArgs e)
        {
            MovementController.ZNegative();
        }

        private void balCalButton_Click(object sender, EventArgs e)
        {
            CalUtill.GenerateBalanceCalibrationData();
        }


    }
}
