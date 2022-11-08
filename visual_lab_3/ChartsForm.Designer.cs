
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine13 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine14 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.leftBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.leftBrightValueTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rightBrightValueTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fixCb = new System.Windows.Forms.CheckBox();
            this.leftModesGb = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rightModesGb = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.normalizeModeRb = new System.Windows.Forms.RadioButton();
            this.updateBrightBtn = new System.Windows.Forms.Button();
            this.leftBrightAmountTb = new System.Windows.Forms.TextBox();
            this.rightBrightAmountTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).BeginInit();
            this.leftModesGb.SuspendLayout();
            this.rightModesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightAmountChart
            // 
            chartArea7.AxisX.Interval = 15D;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea7.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            stripLine13.BackColor = System.Drawing.Color.DeepSkyBlue;
            stripLine13.BorderWidth = 0;
            stripLine13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stripLine13.StripWidth = 1D;
            stripLine13.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine13.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            stripLine14.BackColor = System.Drawing.Color.LightCoral;
            stripLine14.BorderWidth = 0;
            stripLine14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            stripLine14.IntervalOffset = 255D;
            stripLine14.StripWidth = 1D;
            stripLine14.TextAlignment = System.Drawing.StringAlignment.Near;
            stripLine14.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine14.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisX.StripLines.Add(stripLine13);
            chartArea7.AxisX.StripLines.Add(stripLine14);
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea7.CursorX.LineColor = System.Drawing.Color.Lime;
            chartArea7.CursorX.LineWidth = 5;
            chartArea7.Name = "ChartArea1";
            this.brightAmountChart.ChartAreas.Add(chartArea7);
            this.brightAmountChart.IsSoftShadows = false;
            this.brightAmountChart.Location = new System.Drawing.Point(20, 15);
            this.brightAmountChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brightAmountChart.Name = "brightAmountChart";
            this.brightAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Gray;
            series7.Name = "Series1";
            this.brightAmountChart.Series.Add(series7);
            this.brightAmountChart.Size = new System.Drawing.Size(592, 369);
            this.brightAmountChart.TabIndex = 0;
            this.brightAmountChart.Text = "chart1";
            this.brightAmountChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseDown);
            this.brightAmountChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseMove);
            this.brightAmountChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseUp);
            // 
            // leftBoundaryTrack
            // 
            this.leftBoundaryTrack.LargeChange = 1;
            this.leftBoundaryTrack.Location = new System.Drawing.Point(736, 413);
            this.leftBoundaryTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBoundaryTrack.Maximum = 255;
            this.leftBoundaryTrack.Name = "leftBoundaryTrack";
            this.leftBoundaryTrack.Size = new System.Drawing.Size(189, 45);
            this.leftBoundaryTrack.TabIndex = 1;
            this.leftBoundaryTrack.TickFrequency = 10;
            this.leftBoundaryTrack.Scroll += new System.EventHandler(this.LeftBoundaryTrack_Scroll);
            // 
            // leftBrightValueTb
            // 
            this.leftBrightValueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leftBrightValueTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftBrightValueTb.Location = new System.Drawing.Point(92, 413);
            this.leftBrightValueTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftBrightValueTb.Name = "leftBrightValueTb";
            this.leftBrightValueTb.ReadOnly = true;
            this.leftBrightValueTb.Size = new System.Drawing.Size(104, 23);
            this.leftBrightValueTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(137, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "L";
            // 
            // rightBoundaryTrack
            // 
            this.rightBoundaryTrack.LargeChange = 1;
            this.rightBoundaryTrack.Location = new System.Drawing.Point(736, 462);
            this.rightBoundaryTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBoundaryTrack.Maximum = 255;
            this.rightBoundaryTrack.Name = "rightBoundaryTrack";
            this.rightBoundaryTrack.Size = new System.Drawing.Size(183, 45);
            this.rightBoundaryTrack.TabIndex = 4;
            this.rightBoundaryTrack.TickFrequency = 10;
            this.rightBoundaryTrack.Value = 255;
            this.rightBoundaryTrack.Scroll += new System.EventHandler(this.RightBoundaryTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(553, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // rightBrightValueTb
            // 
            this.rightBrightValueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rightBrightValueTb.Location = new System.Drawing.Point(508, 413);
            this.rightBrightValueTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightBrightValueTb.Name = "rightBrightValueTb";
            this.rightBrightValueTb.ReadOnly = true;
            this.rightBrightValueTb.Size = new System.Drawing.Size(104, 23);
            this.rightBrightValueTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(27, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во:";
            // 
            // fixCb
            // 
            this.fixCb.AutoSize = true;
            this.fixCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fixCb.Location = new System.Drawing.Point(254, 413);
            this.fixCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixCb.Name = "fixCb";
            this.fixCb.Size = new System.Drawing.Size(130, 21);
            this.fixCb.TabIndex = 10;
            this.fixCb.Text = "Зафиксировать";
            this.fixCb.UseVisualStyleBackColor = true;
            // 
            // leftModesGb
            // 
            this.leftModesGb.Controls.Add(this.radioButton3);
            this.leftModesGb.Controls.Add(this.radioButton2);
            this.leftModesGb.Controls.Add(this.radioButton1);
            this.leftModesGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leftModesGb.Location = new System.Drawing.Point(623, 15);
            this.leftModesGb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftModesGb.Name = "leftModesGb";
            this.leftModesGb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftModesGb.Size = new System.Drawing.Size(377, 134);
            this.leftModesGb.TabIndex = 11;
            this.leftModesGb.TabStop = false;
            this.leftModesGb.Text = "Левее L";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 24);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Считать равными L";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 53);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(324, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Считать равными минимальному значению 0";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 82);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(154, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Считать равными 0";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rightModesGb
            // 
            this.rightModesGb.Controls.Add(this.radioButton6);
            this.rightModesGb.Controls.Add(this.radioButton7);
            this.rightModesGb.Controls.Add(this.radioButton8);
            this.rightModesGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rightModesGb.Location = new System.Drawing.Point(623, 157);
            this.rightModesGb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightModesGb.Name = "rightModesGb";
            this.rightModesGb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightModesGb.Size = new System.Drawing.Size(380, 128);
            this.rightModesGb.TabIndex = 12;
            this.rightModesGb.TabStop = false;
            this.rightModesGb.Text = "Правее R";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(8, 24);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(156, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Считать равными R";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(8, 53);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(346, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Считать равными максимальному значению 255";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(8, 82);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(154, 21);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Text = "Считать равными 0";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // normalizeModeRb
            // 
            this.normalizeModeRb.AutoSize = true;
            this.normalizeModeRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.normalizeModeRb.Location = new System.Drawing.Point(623, 293);
            this.normalizeModeRb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normalizeModeRb.Name = "normalizeModeRb";
            this.normalizeModeRb.Size = new System.Drawing.Size(205, 21);
            this.normalizeModeRb.TabIndex = 3;
            this.normalizeModeRb.Text = "[L, R] отображать в [0, 255]";
            this.normalizeModeRb.UseVisualStyleBackColor = true;
            this.normalizeModeRb.CheckedChanged += new System.EventHandler(this.NormalizeModeRb_CheckedChanged);
            // 
            // updateBrightBtn
            // 
            this.updateBrightBtn.AutoSize = true;
            this.updateBrightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateBrightBtn.Location = new System.Drawing.Point(202, 490);
            this.updateBrightBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBrightBtn.Name = "updateBrightBtn";
            this.updateBrightBtn.Size = new System.Drawing.Size(241, 28);
            this.updateBrightBtn.TabIndex = 13;
            this.updateBrightBtn.Text = "Обновить яркости изображения";
            this.updateBrightBtn.UseVisualStyleBackColor = true;
            this.updateBrightBtn.Click += new System.EventHandler(this.UpdateBrightBtn_Click);
            // 
            // leftBrightAmountTb
            // 
            this.leftBrightAmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leftBrightAmountTb.Location = new System.Drawing.Point(92, 450);
            this.leftBrightAmountTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftBrightAmountTb.Name = "leftBrightAmountTb";
            this.leftBrightAmountTb.ReadOnly = true;
            this.leftBrightAmountTb.Size = new System.Drawing.Size(104, 23);
            this.leftBrightAmountTb.TabIndex = 15;
            // 
            // rightBrightAmountTb
            // 
            this.rightBrightAmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rightBrightAmountTb.Location = new System.Drawing.Point(508, 450);
            this.rightBrightAmountTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightBrightAmountTb.Name = "rightBrightAmountTb";
            this.rightBrightAmountTb.ReadOnly = true;
            this.rightBrightAmountTb.Size = new System.Drawing.Size(104, 23);
            this.rightBrightAmountTb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(443, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кол-во:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(18, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Яркость:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(434, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Яркость:";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.normalizeModeRb);
            this.Controls.Add(this.rightBrightAmountTb);
            this.Controls.Add(this.leftBrightAmountTb);
            this.Controls.Add(this.updateBrightBtn);
            this.Controls.Add(this.rightModesGb);
            this.Controls.Add(this.leftModesGb);
            this.Controls.Add(this.fixCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightBrightValueTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightBoundaryTrack);
            this.Controls.Add(this.leftBrightValueTb);
            this.Controls.Add(this.leftBoundaryTrack);
            this.Controls.Add(this.brightAmountChart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChartsForm";
            this.Text = "Диаграмма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).EndInit();
            this.leftModesGb.ResumeLayout(false);
            this.leftModesGb.PerformLayout();
            this.rightModesGb.ResumeLayout(false);
            this.rightModesGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart brightAmountChart;
        private System.Windows.Forms.TrackBar leftBoundaryTrack;
        private System.Windows.Forms.TextBox leftBrightValueTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rightBoundaryTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightBrightValueTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fixCb;
        private System.Windows.Forms.GroupBox leftModesGb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox rightModesGb;
        private System.Windows.Forms.RadioButton normalizeModeRb;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button updateBrightBtn;
        private System.Windows.Forms.TextBox leftBrightAmountTb;
        private System.Windows.Forms.TextBox rightBrightAmountTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}