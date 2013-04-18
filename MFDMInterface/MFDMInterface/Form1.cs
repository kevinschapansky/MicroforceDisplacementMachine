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
            CalUtill = new CalibrationUtility(MovementController, "COM6", "COM3"); //THIS IS THE LINE (Move...roller, Balance, Keithley)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            assXOffLabel.Text = "Assumed X Offset: " + CalUtill.XOffset + " (en)";
            assYOffLabel.Text = "Assumed Y Offset: " + CalUtill.YOffset + " (en)";
            actXOffLabel.Text = "Actual X Offset: -- (en)";
            actYOffLabel.Text = "Actual Y Offset: -- (en)";
            verticalStepLabel.Text = "Vertical Step Size: " + verticalStepBar.Value + " (en)";
            stepSizeLabel.Text = "Step Size: " + XYStepBar.Value + " (en)";
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

                icImagingControl1.LiveDisplayZoomFactor = (float)sldZoom.Value / 10.0f;
                lblZoomPercent.Text = (sldZoom.Value * 10).ToString() + "%";
                icImagingControl1.LiveDisplayPosition = new Point((-1 * icImagingControl1.LiveDisplayWidth / 2) + icImagingControl1.Width / 2,
                    (-1 * icImagingControl1.LiveDisplayHeight / 2) + icImagingControl1.Height / 2);

                icImagingControl1.LiveStart();
                DrawCrosshairs();
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            MovementController.XNegative(XYStepBar.Value);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            MovementController.YPositive(XYStepBar.Value);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            MovementController.XPositive(XYStepBar.Value);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            MovementController.YNegative(XYStepBar.Value);
        }

        private void XYStepBar_Scroll(object sender, EventArgs e)
        {
            stepSizeLabel.Text = "Step Size: " + XYStepBar.Value + " (en)";
        }

        private void sldZoom_Scroll(object sender, EventArgs e)
        {
            if (icImagingControl1.LiveDisplayDefault == false)
            {
                icImagingControl1.LiveDisplayZoomFactor = (float)sldZoom.Value / 10.0f;
                lblZoomPercent.Text = (sldZoom.Value * 10).ToString() + "%";
                int centerX = (-1 * icImagingControl1.LiveDisplayWidth / 2) + icImagingControl1.Width / 2;
                int centerY = (-1 * icImagingControl1.LiveDisplayHeight / 2) + icImagingControl1.Height / 2;
                icImagingControl1.LiveDisplayPosition = new Point(centerX, centerY);

                DrawCrosshairs();
            }
            else
            {
                MessageBox.Show("The zoom factor can only be set" + "\n" + "if LiveDisplayDefault returns False!");
            }
        }

        private void DrawCrosshairs()
        {
            int width = icImagingControl1.ImageWidth;
            int height = icImagingControl1.ImageHeight;
            int crosshairLength = (icImagingControl1.ImageWidth / icImagingControl1.LiveDisplayWidth) * 50;

            icImagingControl1.OverlayBitmap.Fill(icImagingControl1.OverlayBitmap.DropOutColor);
            for (int i = Math.Max(0, 7 - sldZoom.Value); i >= 0; i--)
            {
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2 - crosshairLength, height / 2, width / 2 + crosshairLength, height / 2);
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2, height / 2 - crosshairLength, width / 2, height / 2 + crosshairLength);

                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2 - crosshairLength, height / 2 + i, width / 2 + crosshairLength, height / 2 + i);
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2 + i, height / 2 - crosshairLength, width / 2 + i, height / 2 + crosshairLength);

                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2 - crosshairLength, height / 2 - i, width / 2 + crosshairLength, height / 2 - i);
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2 - i, height / 2 - crosshairLength, width / 2 - i, height / 2 + crosshairLength);
            }
        }

        private void probeUp_Click(object sender, EventArgs e)
        {
            MovementController.ZPositive(verticalStepBar.Value);
        }

        private void probeDown_Click(object sender, EventArgs e)
        {
            MovementController.ZNegative(verticalStepBar.Value);
        }

        private void balCalButton_Click(object sender, EventArgs e)
        {
            CalUtill.GenerateBalanceCalibrationData(float.Parse(stopValue.Text), int.Parse(readingDelay.Text), int.Parse(stepSize.Text), outFile.Text);
        }

        private void bcCal_Click(object sender, EventArgs e)
        {
            CalUtill.GenerateBalanceKeithleyCalibrationData(float.Parse(stopValue.Text), int.Parse(readingDelay.Text), int.Parse(stepSize.Text), outFile.Text);
        }

        private void verticalStepBar_Scroll(object sender, EventArgs e)
        {
            verticalStepLabel.Text = "Vertical Step Size: " + verticalStepBar.Value + " (en)";
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            MovementController.ResetMovement();
            MovementController.XPositive(CalUtill.XOffset);
            MovementController.YPositive(CalUtill.YOffset);
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            CalUtill.XOffset = MovementController.XMovement;
            CalUtill.YOffset = MovementController.YMovement;
            assXOffLabel.Text = "Assumed X Offset: " + CalUtill.XOffset + " (en)";
            assYOffLabel.Text = "Assumed Y Offset: " + CalUtill.YOffset + " (en)";
            actXOffLabel.Text = "Actual X Offset: " + CalUtill.XOffset + " (en)";
            actYOffLabel.Text = "Actual Y Offset: " + CalUtill.YOffset + " (en)";
        }

        private void backtrackButton_Click(object sender, EventArgs e)
        {
            MovementController.XPositive(-CalUtill.XOffset);
            MovementController.YPositive(-CalUtill.YOffset);
        }

    }
}
