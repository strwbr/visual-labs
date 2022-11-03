
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine9 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine10 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rightModeGb = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).BeginInit();
            this.leftModeGb.SuspendLayout();
            this.rightModeGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightAmountChart
            // 
            chartArea5.AxisX.Interval = 50D;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea5.AxisX.Maximum = 256D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            stripLine9.BackColor = System.Drawing.Color.DeepSkyBlue;
            stripLine9.BorderWidth = 0;
            stripLine9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stripLine9.StripWidth = 1D;
            stripLine10.BackColor = System.Drawing.Color.LightCoral;
            stripLine10.BorderWidth = 0;
            stripLine10.IntervalOffset = 255D;
            stripLine10.StripWidth = 1D;
            chartArea5.AxisX.StripLines.Add(stripLine9);
            chartArea5.AxisX.StripLines.Add(stripLine10);
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.Name = "ChartArea1";
            this.brightAmountChart.ChartAreas.Add(chartArea5);
            this.brightAmountChart.IsSoftShadows = false;
            this.brightAmountChart.Location = new System.Drawing.Point(15, 12);
            this.brightAmountChart.Name = "brightAmountChart";
            this.brightAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Gray;
            series5.Name = "Series1";
            this.brightAmountChart.Series.Add(series5);
            this.brightAmountChart.Size = new System.Drawing.Size(670, 300);
            this.brightAmountChart.TabIndex = 0;
            this.brightAmountChart.Text = "chart1";
            this.brightAmountChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseDown);
            this.brightAmountChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseMove);
            this.brightAmountChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseUp);
            // 
            // leftBoundaryTrack
            // 
            this.leftBoundaryTrack.LargeChange = 1;
            this.leftBoundaryTrack.Location = new System.Drawing.Point(99, 326);
            this.leftBoundaryTrack.Margin = new System.Windows.Forms.Padding(2);
            this.leftBoundaryTrack.Maximum = 255;
            this.leftBoundaryTrack.Name = "leftBoundaryTrack";
            this.leftBoundaryTrack.Size = new System.Drawing.Size(556, 45);
            this.leftBoundaryTrack.TabIndex = 1;
            this.leftBoundaryTrack.TickFrequency = 10;
            this.leftBoundaryTrack.Scroll += new System.EventHandler(this.LeftBoundaryTrack_Scroll);
            // 
            // leftBoundaryValueTb
            // 
            this.leftBoundaryValueTb.Location = new System.Drawing.Point(15, 327);
            this.leftBoundaryValueTb.Name = "leftBoundaryValueTb";
            this.leftBoundaryValueTb.ReadOnly = true;
            this.leftBoundaryValueTb.Size = new System.Drawing.Size(79, 20);
            this.leftBoundaryValueTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "L";
            // 
            // rightBoundaryTrack
            // 
            this.rightBoundaryTrack.LargeChange = 1;
            this.rightBoundaryTrack.Location = new System.Drawing.Point(99, 375);
            this.rightBoundaryTrack.Margin = new System.Windows.Forms.Padding(2);
            this.rightBoundaryTrack.Maximum = 255;
            this.rightBoundaryTrack.Name = "rightBoundaryTrack";
            this.rightBoundaryTrack.Size = new System.Drawing.Size(556, 45);
            this.rightBoundaryTrack.TabIndex = 4;
            this.rightBoundaryTrack.TickFrequency = 10;
            this.rightBoundaryTrack.Value = 255;
            this.rightBoundaryTrack.Scroll += new System.EventHandler(this.RightBoundaryTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // rightBoundaryValueTb
            // 
            this.rightBoundaryValueTb.Location = new System.Drawing.Point(15, 379);
            this.rightBoundaryValueTb.Name = "rightBoundaryValueTb";
            this.rightBoundaryValueTb.ReadOnly = true;
            this.rightBoundaryValueTb.Size = new System.Drawing.Size(79, 20);
            this.rightBoundaryValueTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // fixCb
            // 
            this.fixCb.AutoSize = true;
            this.fixCb.Location = new System.Drawing.Point(770, 363);
            this.fixCb.Name = "fixCb";
            this.fixCb.Size = new System.Drawing.Size(106, 17);
            this.fixCb.TabIndex = 10;
            this.fixCb.Text = "Зафиксировать";
            this.fixCb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // leftModeGb
            // 
            this.leftModeGb.Controls.Add(this.radioButton4);
            this.leftModeGb.Controls.Add(this.radioButton3);
            this.leftModeGb.Controls.Add(this.radioButton2);
            this.leftModeGb.Controls.Add(this.radioButton1);
            this.leftModeGb.Location = new System.Drawing.Point(704, 21);
            this.leftModeGb.Name = "leftModeGb";
            this.leftModeGb.Size = new System.Drawing.Size(283, 156);
            this.leftModeGb.TabIndex = 11;
            this.leftModeGb.TabStop = false;
            this.leftModeGb.Text = "Левее L";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 122);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(162, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "[L, R] отображать в [0, 255]";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Считать равными 0";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(255, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Считать равными минимальному значению 0";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Считать равными L";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rightModeGb
            // 
            this.rightModeGb.Controls.Add(this.radioButton5);
            this.rightModeGb.Controls.Add(this.radioButton6);
            this.rightModeGb.Controls.Add(this.radioButton7);
            this.rightModeGb.Controls.Add(this.radioButton8);
            this.rightModeGb.Location = new System.Drawing.Point(704, 190);
            this.rightModeGb.Name = "rightModeGb";
            this.rightModeGb.Size = new System.Drawing.Size(285, 156);
            this.rightModeGb.TabIndex = 12;
            this.rightModeGb.TabStop = false;
            this.rightModeGb.Text = "Правее R";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(10, 122);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(162, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "[L, R] отображать в [0, 255]";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(10, 90);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(123, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Считать равными 0";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(10, 60);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(273, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Считать равными максимальному значению 255";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(10, 28);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(125, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Считать равными R";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 561);
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
            this.Name = "ChartsForm";
            this.Text = "Диаграммы";
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
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox rightModeGb;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}