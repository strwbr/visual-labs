
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine11 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine12 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.leftBrightValueTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.leftModesGb.SuspendLayout();
            this.rightModesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightAmountChart
            // 
            chartArea6.AxisX.Interval = 15D;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            stripLine11.BackColor = System.Drawing.Color.DeepSkyBlue;
            stripLine11.BorderWidth = 0;
            stripLine11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stripLine11.StripWidth = 1D;
            stripLine11.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine11.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            stripLine12.BackColor = System.Drawing.Color.LightCoral;
            stripLine12.BorderWidth = 0;
            stripLine12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            stripLine12.IntervalOffset = 255D;
            stripLine12.StripWidth = 1D;
            stripLine12.TextAlignment = System.Drawing.StringAlignment.Near;
            stripLine12.TextLineAlignment = System.Drawing.StringAlignment.Center;
            stripLine12.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea6.AxisX.StripLines.Add(stripLine11);
            chartArea6.AxisX.StripLines.Add(stripLine12);
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.CursorX.LineColor = System.Drawing.Color.Lime;
            chartArea6.CursorX.LineWidth = 5;
            chartArea6.Name = "ChartArea1";
            this.brightAmountChart.ChartAreas.Add(chartArea6);
            this.brightAmountChart.IsSoftShadows = false;
            this.brightAmountChart.Location = new System.Drawing.Point(18, 16);
            this.brightAmountChart.Margin = new System.Windows.Forms.Padding(4);
            this.brightAmountChart.Name = "brightAmountChart";
            this.brightAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Gray;
            series6.Name = "Series1";
            this.brightAmountChart.Series.Add(series6);
            this.brightAmountChart.Size = new System.Drawing.Size(518, 392);
            this.brightAmountChart.TabIndex = 0;
            this.brightAmountChart.Text = "chart1";
            this.brightAmountChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseDown);
            this.brightAmountChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseMove);
            this.brightAmountChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseUp);
            // 
            // leftBrightValueTb
            // 
            this.leftBrightValueTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftBrightValueTb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftBrightValueTb.Location = new System.Drawing.Point(84, 443);
            this.leftBrightValueTb.Margin = new System.Windows.Forms.Padding(4);
            this.leftBrightValueTb.Name = "leftBrightValueTb";
            this.leftBrightValueTb.ReadOnly = true;
            this.leftBrightValueTb.Size = new System.Drawing.Size(92, 25);
            this.leftBrightValueTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(119, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(480, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // rightBrightValueTb
            // 
            this.rightBrightValueTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightBrightValueTb.Location = new System.Drawing.Point(444, 443);
            this.rightBrightValueTb.Margin = new System.Windows.Forms.Padding(4);
            this.rightBrightValueTb.Name = "rightBrightValueTb";
            this.rightBrightValueTb.ReadOnly = true;
            this.rightBrightValueTb.Size = new System.Drawing.Size(92, 25);
            this.rightBrightValueTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(20, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во:";
            // 
            // fixCb
            // 
            this.fixCb.AutoSize = true;
            this.fixCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fixCb.Location = new System.Drawing.Point(226, 457);
            this.fixCb.Margin = new System.Windows.Forms.Padding(4);
            this.fixCb.Name = "fixCb";
            this.fixCb.Size = new System.Drawing.Size(125, 23);
            this.fixCb.TabIndex = 10;
            this.fixCb.Text = "Зафиксировать";
            this.fixCb.UseVisualStyleBackColor = true;
            // 
            // leftModesGb
            // 
            this.leftModesGb.Controls.Add(this.radioButton3);
            this.leftModesGb.Controls.Add(this.radioButton2);
            this.leftModesGb.Controls.Add(this.radioButton1);
            this.leftModesGb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftModesGb.Location = new System.Drawing.Point(556, 16);
            this.leftModesGb.Margin = new System.Windows.Forms.Padding(4);
            this.leftModesGb.Name = "leftModesGb";
            this.leftModesGb.Padding = new System.Windows.Forms.Padding(4);
            this.leftModesGb.Size = new System.Drawing.Size(373, 142);
            this.leftModesGb.TabIndex = 11;
            this.leftModesGb.TabStop = false;
            this.leftModesGb.Text = "Левее L";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 26);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Считать равными L";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 56);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(321, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Считать равными минимальному значению 0";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 87);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Считать равными 0";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rightModesGb
            // 
            this.rightModesGb.Controls.Add(this.radioButton6);
            this.rightModesGb.Controls.Add(this.radioButton7);
            this.rightModesGb.Controls.Add(this.radioButton8);
            this.rightModesGb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightModesGb.Location = new System.Drawing.Point(556, 167);
            this.rightModesGb.Margin = new System.Windows.Forms.Padding(4);
            this.rightModesGb.Name = "rightModesGb";
            this.rightModesGb.Padding = new System.Windows.Forms.Padding(4);
            this.rightModesGb.Size = new System.Drawing.Size(373, 136);
            this.rightModesGb.TabIndex = 12;
            this.rightModesGb.TabStop = false;
            this.rightModesGb.Text = "Правее R";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 26);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(152, 23);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Считать равными R";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 56);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(341, 23);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Считать равными максимальному значению 255";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 87);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(152, 23);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Text = "Считать равными 0";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // normalizeModeRb
            // 
            this.normalizeModeRb.AutoSize = true;
            this.normalizeModeRb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.normalizeModeRb.Location = new System.Drawing.Point(563, 311);
            this.normalizeModeRb.Margin = new System.Windows.Forms.Padding(4);
            this.normalizeModeRb.Name = "normalizeModeRb";
            this.normalizeModeRb.Size = new System.Drawing.Size(198, 23);
            this.normalizeModeRb.TabIndex = 3;
            this.normalizeModeRb.Text = "[L, R] отображать в [0, 255]";
            this.normalizeModeRb.UseVisualStyleBackColor = true;
            this.normalizeModeRb.CheckedChanged += new System.EventHandler(this.NormalizeModeRb_CheckedChanged);
            // 
            // updateBrightBtn
            // 
            this.updateBrightBtn.AutoSize = true;
            this.updateBrightBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateBrightBtn.Location = new System.Drawing.Point(617, 414);
            this.updateBrightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBrightBtn.Name = "updateBrightBtn";
            this.updateBrightBtn.Size = new System.Drawing.Size(253, 31);
            this.updateBrightBtn.TabIndex = 13;
            this.updateBrightBtn.Text = "Обновить яркости изображения";
            this.updateBrightBtn.UseVisualStyleBackColor = true;
            this.updateBrightBtn.Click += new System.EventHandler(this.UpdateBrightBtn_Click);
            // 
            // leftBrightAmountTb
            // 
            this.leftBrightAmountTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leftBrightAmountTb.Location = new System.Drawing.Point(84, 482);
            this.leftBrightAmountTb.Margin = new System.Windows.Forms.Padding(4);
            this.leftBrightAmountTb.Name = "leftBrightAmountTb";
            this.leftBrightAmountTb.ReadOnly = true;
            this.leftBrightAmountTb.Size = new System.Drawing.Size(92, 25);
            this.leftBrightAmountTb.TabIndex = 15;
            // 
            // rightBrightAmountTb
            // 
            this.rightBrightAmountTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rightBrightAmountTb.Location = new System.Drawing.Point(444, 482);
            this.rightBrightAmountTb.Margin = new System.Windows.Forms.Padding(4);
            this.rightBrightAmountTb.Name = "rightBrightAmountTb";
            this.rightBrightAmountTb.ReadOnly = true;
            this.rightBrightAmountTb.Size = new System.Drawing.Size(92, 25);
            this.rightBrightAmountTb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(380, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кол-во:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(14, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Яркость:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(374, 446);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Яркость:";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 545);
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
            this.Controls.Add(this.leftBrightValueTb);
            this.Controls.Add(this.brightAmountChart);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartsForm";
            this.Text = "Диаграмма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).EndInit();
            this.leftModesGb.ResumeLayout(false);
            this.leftModesGb.PerformLayout();
            this.rightModesGb.ResumeLayout(false);
            this.rightModesGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart brightAmountChart;
        private System.Windows.Forms.TextBox leftBrightValueTb;
        private System.Windows.Forms.Label label1;
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