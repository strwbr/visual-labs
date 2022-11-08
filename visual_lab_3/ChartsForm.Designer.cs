
namespace visual_lab_3
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine7 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine8 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.leftBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.leftBoundaryValueTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rightBoundaryValueTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fixCb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.leftModeGb = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rightModeGb = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.normalizeModeRb = new System.Windows.Forms.RadioButton();
            this.updateBrightBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).BeginInit();
            this.leftModeGb.SuspendLayout();
            this.rightModeGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightAmountChart
            // 
            chartArea4.AxisX.Interval = 5D;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea4.AxisX.Maximum = 256D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            stripLine7.BackColor = System.Drawing.Color.DeepSkyBlue;
            stripLine7.BorderWidth = 0;
            stripLine7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stripLine7.StripWidth = 1D;
            stripLine7.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine7.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            stripLine8.BackColor = System.Drawing.Color.LightCoral;
            stripLine8.BorderWidth = 0;
            stripLine8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            stripLine8.IntervalOffset = 255D;
            stripLine8.StripWidth = 1D;
            stripLine8.TextAlignment = System.Drawing.StringAlignment.Near;
            stripLine8.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine8.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX.StripLines.Add(stripLine7);
            chartArea4.AxisX.StripLines.Add(stripLine8);
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.CursorX.LineColor = System.Drawing.Color.Lime;
            chartArea4.CursorX.LineWidth = 5;
            chartArea4.Name = "ChartArea1";
            this.brightAmountChart.ChartAreas.Add(chartArea4);
            this.brightAmountChart.IsSoftShadows = false;
            this.brightAmountChart.Location = new System.Drawing.Point(20, 15);
            this.brightAmountChart.Margin = new System.Windows.Forms.Padding(4);
            this.brightAmountChart.Name = "brightAmountChart";
            this.brightAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Gray;
            series4.Name = "Series1";
            this.brightAmountChart.Series.Add(series4);
            this.brightAmountChart.Size = new System.Drawing.Size(893, 369);
            this.brightAmountChart.TabIndex = 0;
            this.brightAmountChart.Text = "chart1";
            this.brightAmountChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseDown);
            this.brightAmountChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseMove);
            this.brightAmountChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseUp);
            // 
            // leftBoundaryTrack
            // 
            this.leftBoundaryTrack.LargeChange = 1;
            this.leftBoundaryTrack.Location = new System.Drawing.Point(661, 564);
            this.leftBoundaryTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBoundaryTrack.Maximum = 255;
            this.leftBoundaryTrack.Name = "leftBoundaryTrack";
            this.leftBoundaryTrack.Size = new System.Drawing.Size(741, 56);
            this.leftBoundaryTrack.TabIndex = 1;
            this.leftBoundaryTrack.TickFrequency = 10;
            this.leftBoundaryTrack.Scroll += new System.EventHandler(this.LeftBoundaryTrack_Scroll);
            // 
            // leftBoundaryValueTb
            // 
            this.leftBoundaryValueTb.Location = new System.Drawing.Point(89, 398);
            this.leftBoundaryValueTb.Margin = new System.Windows.Forms.Padding(4);
            this.leftBoundaryValueTb.Name = "leftBoundaryValueTb";
            this.leftBoundaryValueTb.ReadOnly = true;
            this.leftBoundaryValueTb.Size = new System.Drawing.Size(104, 22);
            this.leftBoundaryValueTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "L";
            // 
            // rightBoundaryTrack
            // 
            this.rightBoundaryTrack.LargeChange = 1;
            this.rightBoundaryTrack.Location = new System.Drawing.Point(661, 624);
            this.rightBoundaryTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBoundaryTrack.Maximum = 255;
            this.rightBoundaryTrack.Name = "rightBoundaryTrack";
            this.rightBoundaryTrack.Size = new System.Drawing.Size(741, 56);
            this.rightBoundaryTrack.TabIndex = 4;
            this.rightBoundaryTrack.TickFrequency = 10;
            this.rightBoundaryTrack.Value = 255;
            this.rightBoundaryTrack.Scroll += new System.EventHandler(this.RightBoundaryTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // rightBoundaryValueTb
            // 
            this.rightBoundaryValueTb.Location = new System.Drawing.Point(777, 398);
            this.rightBoundaryValueTb.Margin = new System.Windows.Forms.Padding(4);
            this.rightBoundaryValueTb.Name = "rightBoundaryValueTb";
            this.rightBoundaryValueTb.ReadOnly = true;
            this.rightBoundaryValueTb.Size = new System.Drawing.Size(104, 22);
            this.rightBoundaryValueTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // fixCb
            // 
            this.fixCb.AutoSize = true;
            this.fixCb.Location = new System.Drawing.Point(416, 406);
            this.fixCb.Margin = new System.Windows.Forms.Padding(4);
            this.fixCb.Name = "fixCb";
            this.fixCb.Size = new System.Drawing.Size(133, 21);
            this.fixCb.TabIndex = 10;
            this.fixCb.Text = "Зафиксировать";
            this.fixCb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 663);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // leftModeGb
            // 
            this.leftModeGb.Controls.Add(this.radioButton3);
            this.leftModeGb.Controls.Add(this.radioButton2);
            this.leftModeGb.Controls.Add(this.radioButton1);
            this.leftModeGb.Location = new System.Drawing.Point(939, 26);
            this.leftModeGb.Margin = new System.Windows.Forms.Padding(4);
            this.leftModeGb.Name = "leftModeGb";
            this.leftModeGb.Padding = new System.Windows.Forms.Padding(4);
            this.leftModeGb.Size = new System.Drawing.Size(377, 158);
            this.leftModeGb.TabIndex = 11;
            this.leftModeGb.TabStop = false;
            this.leftModeGb.Text = "Левее L";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 111);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(157, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Считать равными 0";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 74);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(327, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Считать равными минимальному значению 0";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Считать равными L";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rightModeGb
            // 
            this.rightModeGb.Controls.Add(this.radioButton6);
            this.rightModeGb.Controls.Add(this.radioButton7);
            this.rightModeGb.Controls.Add(this.radioButton8);
            this.rightModeGb.Location = new System.Drawing.Point(939, 191);
            this.rightModeGb.Margin = new System.Windows.Forms.Padding(4);
            this.rightModeGb.Name = "rightModeGb";
            this.rightModeGb.Padding = new System.Windows.Forms.Padding(4);
            this.rightModeGb.Size = new System.Drawing.Size(380, 150);
            this.rightModeGb.TabIndex = 12;
            this.rightModeGb.TabStop = false;
            this.rightModeGb.Text = "Правее R";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(13, 111);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(157, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Считать равными 0";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(13, 74);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(349, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Считать равными максимальному значению 255";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(13, 34);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(159, 21);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Считать равными R";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // normalizeModeRb
            // 
            this.normalizeModeRb.AutoSize = true;
            this.normalizeModeRb.Location = new System.Drawing.Point(952, 348);
            this.normalizeModeRb.Margin = new System.Windows.Forms.Padding(4);
            this.normalizeModeRb.Name = "normalizeModeRb";
            this.normalizeModeRb.Size = new System.Drawing.Size(208, 21);
            this.normalizeModeRb.TabIndex = 3;
            this.normalizeModeRb.Text = "[L, R] отображать в [0, 255]";
            this.normalizeModeRb.UseVisualStyleBackColor = true;
            this.normalizeModeRb.CheckedChanged += new System.EventHandler(this.NormalizeModeRb_CheckedChanged);
            // 
            // updateBrightBtn
            // 
            this.updateBrightBtn.AutoSize = true;
            this.updateBrightBtn.Location = new System.Drawing.Point(359, 434);
            this.updateBrightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBrightBtn.Name = "updateBrightBtn";
            this.updateBrightBtn.Size = new System.Drawing.Size(241, 28);
            this.updateBrightBtn.TabIndex = 13;
            this.updateBrightBtn.Text = "Обновить яркости изображения";
            this.updateBrightBtn.UseVisualStyleBackColor = true;
            this.updateBrightBtn.Click += new System.EventHandler(this.UpdateBrightBtn_Click);
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 690);
            this.Controls.Add(this.updateBrightBtn);
            this.Controls.Add(this.normalizeModeRb);
            this.Controls.Add(this.rightModeGb);
            this.Controls.Add(this.leftModeGb);
            this.Controls.Add(this.fixCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rightBoundaryValueTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightBoundaryTrack);
            this.Controls.Add(this.leftBoundaryValueTb);
            this.Controls.Add(this.leftBoundaryTrack);
            this.Controls.Add(this.brightAmountChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartsForm";
            this.Text = "Диаграммы";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).EndInit();
            this.leftModeGb.ResumeLayout(false);
            this.leftModeGb.PerformLayout();
            this.rightModeGb.ResumeLayout(false);
            this.rightModeGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart brightAmountChart;
        private System.Windows.Forms.TrackBar leftBoundaryTrack;
        private System.Windows.Forms.TextBox leftBoundaryValueTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rightBoundaryTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightBoundaryValueTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fixCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox leftModeGb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox rightModeGb;
        private System.Windows.Forms.RadioButton normalizeModeRb;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button updateBrightBtn;
    }
}