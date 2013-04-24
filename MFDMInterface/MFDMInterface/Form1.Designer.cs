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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UpButton = new System.Windows.Forms.Button();
            this.icImagingControl1 = new TIS.Imaging.ICImagingControl();
            this.DownButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.sldZoom = new System.Windows.Forms.TrackBar();
            this.lblZoomPercent = new System.Windows.Forms.Label();
            this.probeUp = new System.Windows.Forms.Button();
            this.probeDown = new System.Windows.Forms.Button();
            this.stopValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.readingDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stepSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outFile = new System.Windows.Forms.TextBox();
            this.bcCal = new System.Windows.Forms.Button();
            this.XYStepBar = new System.Windows.Forms.TrackBar();
            this.stepSizeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.verticalStepBar = new System.Windows.Forms.TrackBar();
            this.verticalStepLabel = new System.Windows.Forms.Label();
            this.assYOffLabel = new System.Windows.Forms.Label();
            this.assXOffLabel = new System.Windows.Forms.Label();
            this.actXOffLabel = new System.Windows.Forms.Label();
            this.actYOffLabel = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.backtrackButton = new System.Windows.Forms.Button();
            this.forceDisplacementChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.runButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.stopVoltageText = new System.Windows.Forms.TextBox();
            this.testPosition = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYStepBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalStepBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forceDisplacementChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(91, 306);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(49, 23);
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
            this.icImagingControl1.LiveDisplayDefault = false;
            this.icImagingControl1.LiveDisplayPosition = new System.Drawing.Point(0, 0);
            this.icImagingControl1.Location = new System.Drawing.Point(12, 12);
            this.icImagingControl1.Name = "icImagingControl1";
            this.icImagingControl1.Size = new System.Drawing.Size(326, 228);
            this.icImagingControl1.TabIndex = 5;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(91, 363);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(49, 23);
            this.DownButton.TabIndex = 6;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(145, 335);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(49, 23);
            this.RightButton.TabIndex = 7;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(36, 335);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(49, 23);
            this.LeftButton.TabIndex = 8;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // sldZoom
            // 
            this.sldZoom.Location = new System.Drawing.Point(12, 246);
            this.sldZoom.Minimum = 2;
            this.sldZoom.Name = "sldZoom";
            this.sldZoom.Size = new System.Drawing.Size(326, 45);
            this.sldZoom.TabIndex = 13;
            this.sldZoom.Value = 2;
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
            this.probeUp.Location = new System.Drawing.Point(228, 315);
            this.probeUp.Name = "probeUp";
            this.probeUp.Size = new System.Drawing.Size(75, 23);
            this.probeUp.TabIndex = 15;
            this.probeUp.Text = "Probe Up";
            this.probeUp.UseVisualStyleBackColor = true;
            this.probeUp.Click += new System.EventHandler(this.probeUp_Click);
            // 
            // probeDown
            // 
            this.probeDown.Location = new System.Drawing.Point(228, 346);
            this.probeDown.Name = "probeDown";
            this.probeDown.Size = new System.Drawing.Size(75, 23);
            this.probeDown.TabIndex = 16;
            this.probeDown.Text = "Probe Down";
            this.probeDown.UseVisualStyleBackColor = true;
            this.probeDown.Click += new System.EventHandler(this.probeDown_Click);
            // 
            // stopValue
            // 
            this.stopValue.Location = new System.Drawing.Point(461, 321);
            this.stopValue.Name = "stopValue";
            this.stopValue.Size = new System.Drawing.Size(100, 20);
            this.stopValue.TabIndex = 18;
            this.stopValue.Text = "10.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stop Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Reading Delay (ms)";
            // 
            // readingDelay
            // 
            this.readingDelay.Location = new System.Drawing.Point(461, 347);
            this.readingDelay.Name = "readingDelay";
            this.readingDelay.Size = new System.Drawing.Size(100, 20);
            this.readingDelay.TabIndex = 21;
            this.readingDelay.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Step Size (en)";
            // 
            // stepSize
            // 
            this.stepSize.Location = new System.Drawing.Point(461, 373);
            this.stepSize.Name = "stepSize";
            this.stepSize.Size = new System.Drawing.Size(100, 20);
            this.stepSize.TabIndex = 23;
            this.stepSize.Text = "28";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calibration Output File";
            // 
            // outFile
            // 
            this.outFile.Location = new System.Drawing.Point(461, 399);
            this.outFile.Name = "outFile";
            this.outFile.Size = new System.Drawing.Size(100, 20);
            this.outFile.TabIndex = 25;
            this.outFile.Text = "TestCal_1.txt";
            // 
            // bcCal
            // 
            this.bcCal.Location = new System.Drawing.Point(793, 353);
            this.bcCal.Name = "bcCal";
            this.bcCal.Size = new System.Drawing.Size(169, 23);
            this.bcCal.TabIndex = 26;
            this.bcCal.Text = "Balance/Keithley Calibration";
            this.bcCal.UseVisualStyleBackColor = true;
            this.bcCal.Click += new System.EventHandler(this.bcCal_Click);
            // 
            // XYStepBar
            // 
            this.XYStepBar.Location = new System.Drawing.Point(12, 390);
            this.XYStepBar.Maximum = 100000;
            this.XYStepBar.Minimum = 1;
            this.XYStepBar.Name = "XYStepBar";
            this.XYStepBar.Size = new System.Drawing.Size(326, 45);
            this.XYStepBar.TabIndex = 27;
            this.XYStepBar.Value = 2;
            this.XYStepBar.Scroll += new System.EventHandler(this.XYStepBar_Scroll);
            // 
            // stepSizeLabel
            // 
            this.stepSizeLabel.AutoSize = true;
            this.stepSizeLabel.Location = new System.Drawing.Point(124, 422);
            this.stepSizeLabel.Name = "stepSizeLabel";
            this.stepSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.stepSizeLabel.TabIndex = 28;
            this.stepSizeLabel.Text = "Step Size: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "1 mm = 28275 en";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "1 um = 28 en";
            // 
            // verticalStepBar
            // 
            this.verticalStepBar.Location = new System.Drawing.Point(12, 479);
            this.verticalStepBar.Maximum = 28275;
            this.verticalStepBar.Minimum = 1;
            this.verticalStepBar.Name = "verticalStepBar";
            this.verticalStepBar.Size = new System.Drawing.Size(326, 45);
            this.verticalStepBar.TabIndex = 31;
            this.verticalStepBar.Value = 1;
            this.verticalStepBar.Scroll += new System.EventHandler(this.verticalStepBar_Scroll);
            // 
            // verticalStepLabel
            // 
            this.verticalStepLabel.AutoSize = true;
            this.verticalStepLabel.BackColor = System.Drawing.SystemColors.Control;
            this.verticalStepLabel.Location = new System.Drawing.Point(79, 523);
            this.verticalStepLabel.Name = "verticalStepLabel";
            this.verticalStepLabel.Size = new System.Drawing.Size(93, 13);
            this.verticalStepLabel.TabIndex = 32;
            this.verticalStepLabel.Text = "Vertical Step Size:";
            // 
            // assYOffLabel
            // 
            this.assYOffLabel.AutoSize = true;
            this.assYOffLabel.Location = new System.Drawing.Point(794, 394);
            this.assYOffLabel.Name = "assYOffLabel";
            this.assYOffLabel.Size = new System.Drawing.Size(34, 13);
            this.assYOffLabel.TabIndex = 33;
            this.assYOffLabel.Text = "Ass Y";
            // 
            // assXOffLabel
            // 
            this.assXOffLabel.AutoSize = true;
            this.assXOffLabel.Location = new System.Drawing.Point(793, 381);
            this.assXOffLabel.Name = "assXOffLabel";
            this.assXOffLabel.Size = new System.Drawing.Size(34, 13);
            this.assXOffLabel.TabIndex = 34;
            this.assXOffLabel.Text = "Ass X";
            // 
            // actXOffLabel
            // 
            this.actXOffLabel.AutoSize = true;
            this.actXOffLabel.Location = new System.Drawing.Point(793, 426);
            this.actXOffLabel.Name = "actXOffLabel";
            this.actXOffLabel.Size = new System.Drawing.Size(33, 13);
            this.actXOffLabel.TabIndex = 35;
            this.actXOffLabel.Text = "Act X";
            // 
            // actYOffLabel
            // 
            this.actYOffLabel.AutoSize = true;
            this.actYOffLabel.Location = new System.Drawing.Point(794, 439);
            this.actYOffLabel.Name = "actYOffLabel";
            this.actYOffLabel.Size = new System.Drawing.Size(33, 13);
            this.actYOffLabel.TabIndex = 36;
            this.actYOffLabel.Text = "Act Y";
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(797, 479);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(75, 23);
            this.calButton.TabIndex = 37;
            this.calButton.Text = "XY Calibrate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(910, 479);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 39;
            this.setButton.Text = "Set Offset";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // backtrackButton
            // 
            this.backtrackButton.Location = new System.Drawing.Point(796, 508);
            this.backtrackButton.Name = "backtrackButton";
            this.backtrackButton.Size = new System.Drawing.Size(75, 23);
            this.backtrackButton.TabIndex = 40;
            this.backtrackButton.Text = "Backtrack";
            this.backtrackButton.UseVisualStyleBackColor = true;
            this.backtrackButton.Click += new System.EventHandler(this.backtrackButton_Click);
            // 
            // forceDisplacementChart
            // 
            chartArea1.Name = "ChartArea1";
            this.forceDisplacementChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.forceDisplacementChart.Legends.Add(legend1);
            this.forceDisplacementChart.Location = new System.Drawing.Point(354, 12);
            this.forceDisplacementChart.Name = "forceDisplacementChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.forceDisplacementChart.Series.Add(series1);
            this.forceDisplacementChart.Size = new System.Drawing.Size(608, 300);
            this.forceDisplacementChart.TabIndex = 41;
            this.forceDisplacementChart.Text = "chart1";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(465, 479);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 42;
            this.runButton.Text = "Run Test";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Stop Voltage: ";
            // 
            // stopVoltageText
            // 
            this.stopVoltageText.Location = new System.Drawing.Point(542, 449);
            this.stopVoltageText.Name = "stopVoltageText";
            this.stopVoltageText.Size = new System.Drawing.Size(100, 20);
            this.stopVoltageText.TabIndex = 44;
            // 
            // testPosition
            // 
            this.testPosition.Location = new System.Drawing.Point(546, 479);
            this.testPosition.Name = "testPosition";
            this.testPosition.Size = new System.Drawing.Size(117, 23);
            this.testPosition.TabIndex = 45;
            this.testPosition.Text = "Move To Test Pos";
            this.testPosition.UseVisualStyleBackColor = true;
            this.testPosition.Click += new System.EventHandler(this.testPosition_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(515, 513);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 46;
            this.stopButton.Text = "Stop Test";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 585);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.testPosition);
            this.Controls.Add(this.stopVoltageText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.forceDisplacementChart);
            this.Controls.Add(this.backtrackButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.actYOffLabel);
            this.Controls.Add(this.actXOffLabel);
            this.Controls.Add(this.assXOffLabel);
            this.Controls.Add(this.assYOffLabel);
            this.Controls.Add(this.verticalStepLabel);
            this.Controls.Add(this.verticalStepBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stepSizeLabel);
            this.Controls.Add(this.XYStepBar);
            this.Controls.Add(this.bcCal);
            this.Controls.Add(this.outFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stepSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readingDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopValue);
            this.Controls.Add(this.probeDown);
            this.Controls.Add(this.probeUp);
            this.Controls.Add(this.lblZoomPercent);
            this.Controls.Add(this.sldZoom);
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
            ((System.ComponentModel.ISupportInitialize)(this.XYStepBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalStepBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forceDisplacementChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private TIS.Imaging.ICImagingControl icImagingControl1;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.TrackBar sldZoom;
        private System.Windows.Forms.Label lblZoomPercent;
        private System.Windows.Forms.Button probeUp;
        private System.Windows.Forms.Button probeDown;
        private System.Windows.Forms.TextBox stopValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readingDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stepSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outFile;
        private System.Windows.Forms.Button bcCal;
        private System.Windows.Forms.TrackBar XYStepBar;
        private System.Windows.Forms.Label stepSizeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar verticalStepBar;
        private System.Windows.Forms.Label verticalStepLabel;
        private System.Windows.Forms.Label assYOffLabel;
        private System.Windows.Forms.Label assXOffLabel;
        private System.Windows.Forms.Label actXOffLabel;
        private System.Windows.Forms.Label actYOffLabel;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button backtrackButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart forceDisplacementChart;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stopVoltageText;
        private System.Windows.Forms.Button testPosition;
        private System.Windows.Forms.Button stopButton;
    }
}

