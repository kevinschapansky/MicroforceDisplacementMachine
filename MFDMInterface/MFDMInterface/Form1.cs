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
        public Form1()
        {
            InitializeComponent();
            MovementController = new StageController();
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
                icImagingControl1.LiveDisplayWidth = 326;
                icImagingControl1.LiveDisplayHeight = 228;
                icImagingControl1.LiveStart();
                icImagingControl1.OverlayBitmap.Enable = true;
                icImagingControl1.OverlayBitmap.ColorMode = TIS.Imaging.OverlayColorModes.Color;
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red,width / 2 - 10, height / 2, width / 2 + 10, height / 2);
                icImagingControl1.OverlayBitmap.DrawLine(Color.Red, width / 2, height / 2 - 10, width / 2, height / 2 + 10);
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

    }
}
