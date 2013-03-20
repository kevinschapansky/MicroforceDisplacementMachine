namespace MFDMInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpButton = new System.Windows.Forms.Button();
            this.icImagingControl1 = new TIS.Imaging.ICImagingControl();
            this.DownButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.FUp = new System.Windows.Forms.Button();
            this.FLeft = new System.Windows.Forms.Button();
            this.FDown = new System.Windows.Forms.Button();
            this.FRight = new System.Windows.Forms.Button();
            this.sldZoom = new System.Windows.Forms.TrackBar();
            this.lblZoomPercent = new System.Windows.Forms.Label();
            this.probeUp = new System.Windows.Forms.Button();
            this.probeDown = new System.Windows.Forms.Button();
            this.balCalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(232, 328);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // icImagingControl1
            // 
            this.icImagingControl1.BackColor = System.Drawing.Color.White;
            this.icImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke;
            this.icImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded;
            this.icImagingControl1.LiveDisplayPosition = new System.Drawing.Point(0, 0);
            this.icImagingControl1.Location = new System.Drawing.Point(12, 12);
            this.icImagingControl1.Name = "icImagingControl1";
            this.icImagingControl1.Size = new System.Drawing.Size(326, 228);
            this.icImagingControl1.TabIndex = 5;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(232, 400);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 6;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(334, 365);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 7;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(124, 365);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 8;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // FUp
            // 
            this.FUp.Location = new System.Drawing.Point(232, 299);
            this.FUp.Name = "FUp";
            this.FUp.Size = new System.Drawing.Size(75, 23);
            this.FUp.TabIndex = 9;
            this.FUp.Text = "Fast Up";
            this.FUp.UseVisualStyleBackColor = true;
            this.FUp.Click += new System.EventHandler(this.FUp_Click);
            // 
            // FLeft
            // 
            this.FLeft.Location = new System.Drawing.Point(43, 365);
            this.FLeft.Name = "FLeft";
            this.FLeft.Size = new System.Drawing.Size(75, 23);
            this.FLeft.TabIndex = 10;
            this.FLeft.Text = "Fast Left";
            this.FLeft.UseVisualStyleBackColor = true;
            this.FLeft.Click += new System.EventHandler(this.FLeft_Click);
            // 
            // FDown
            // 
            this.FDown.Location = new System.Drawing.Point(232, 429);
            this.FDown.Name = "FDown";
            this.FDown.Size = new System.Drawing.Size(75, 23);
            this.FDown.TabIndex = 11;
            this.FDown.Text = "Fast Down";
            this.FDown.UseVisualStyleBackColor = true;
            this.FDown.Click += new System.EventHandler(this.FDown_Click);
            // 
            // FRight
            // 
            this.FRight.Location = new System.Drawing.Point(415, 365);
            this.FRight.Name = "FRight";
            this.FRight.Size = new System.Drawing.Size(75, 23);
            this.FRight.TabIndex = 12;
            this.FRight.Text = "Fast Right";
            this.FRight.UseVisualStyleBackColor = true;
            this.FRight.Click += new System.EventHandler(this.FRight_Click);
            // 
            // sldZoom
            // 
            this.sldZoom.Location = new System.Drawing.Point(12, 246);
            this.sldZoom.Maximum = 11;
            this.sldZoom.Minimum = 1;
            this.sldZoom.Name = "sldZoom";
            this.sldZoom.Size = new System.Drawing.Size(326, 45);
            this.sldZoom.TabIndex = 13;
            this.sldZoom.Value = 1;
            this.sldZoom.Scroll += new System.EventHandler(this.sldZoom_Scroll);
            // 
            // lblZoomPercent
            // 
            this.lblZoomPercent.AutoSize = true;
            this.lblZoomPercent.Location = new System.Drawing.Point(142, 278);
            this.lblZoomPercent.Name = "lblZoomPercent";
            this.lblZoomPercent.Size = new System.Drawing.Size(40, 13);
            this.lblZoomPercent.TabIndex = 14;
            this.lblZoomPercent.Text = "Zoom: ";
            // 
            // probeUp
            // 
            this.probeUp.Location = new System.Drawing.Point(415, 45);
            this.probeUp.Name = "probeUp";
            this.probeUp.Size = new System.Drawing.Size(75, 23);
            this.probeUp.TabIndex = 15;
            this.probeUp.Text = "Probe Up";
            this.probeUp.UseVisualStyleBackColor = true;
            this.probeUp.Click += new System.EventHandler(this.probeUp_Click);
            // 
            // probeDown
            // 
            this.probeDown.Location = new System.Drawing.Point(415, 75);
            this.probeDown.Name = "probeDown";
            this.probeDown.Size = new System.Drawing.Size(75, 23);
            this.probeDown.TabIndex = 16;
            this.probeDown.Text = "Probe Down";
            this.probeDown.UseVisualStyleBackColor = true;
            this.probeDown.Click += new System.EventHandler(this.probeDown_Click);
            // 
            // balCalButton
            // 
            this.balCalButton.Location = new System.Drawing.Point(613, 191);
            this.balCalButton.Name = "balCalButton";
            this.balCalButton.Size = new System.Drawing.Size(154, 23);
            this.balCalButton.TabIndex = 17;
            this.balCalButton.Text = "Balance Calibration";
            this.balCalButton.UseVisualStyleBackColor = true;
            this.balCalButton.Click += new System.EventHandler(this.balCalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 633);
            this.Controls.Add(this.balCalButton);
            this.Controls.Add(this.probeDown);
            this.Controls.Add(this.probeUp);
            this.Controls.Add(this.lblZoomPercent);
            this.Controls.Add(this.sldZoom);
            this.Controls.Add(this.FRight);
            this.Controls.Add(this.FDown);
            this.Controls.Add(this.FLeft);
            this.Controls.Add(this.FUp);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.icImagingControl1);
            this.Controls.Add(this.UpButton);
            this.Name = "Form1";
            this.Text = "MFDM Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private TIS.Imaging.ICImagingControl icImagingControl1;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button FUp;
        private System.Windows.Forms.Button FLeft;
        private System.Windows.Forms.Button FDown;
        private System.Windows.Forms.Button FRight;
        private System.Windows.Forms.TrackBar sldZoom;
        private System.Windows.Forms.Label lblZoomPercent;
        private System.Windows.Forms.Button probeUp;
        private System.Windows.Forms.Button probeDown;
        private System.Windows.Forms.Button balCalButton;
    }
}

