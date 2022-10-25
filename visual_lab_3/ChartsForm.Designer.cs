
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.leftBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.leftBoundaryValueTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightBoundaryTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rightBoundaryValueTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // brightAmountChart
            // 
            chartArea1.AxisX.Interval = 50D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Maximum = 256D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.brightAmountChart.ChartAreas.Add(chartArea1);
            this.brightAmountChart.IsSoftShadows = false;
            this.brightAmountChart.Location = new System.Drawing.Point(72, 12);
            this.brightAmountChart.Name = "brightAmountChart";
            this.brightAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.brightAmountChart.Series.Add(series1);
            this.brightAmountChart.Size = new System.Drawing.Size(320, 300);
            this.brightAmountChart.TabIndex = 0;
            this.brightAmountChart.Text = "chart1";
            this.brightAmountChart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brightAmountChart_KeyDown);
            this.brightAmountChart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.brightAmountChart_KeyUp);
            this.brightAmountChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseDown);
            this.brightAmountChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseMove);
            this.brightAmountChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightAmountChart_MouseUp);
            // 
            // leftBoundaryTrack
            // 
            this.leftBoundaryTrack.LargeChange = 1;
            this.leftBoundaryTrack.Location = new System.Drawing.Point(110, 317);
            this.leftBoundaryTrack.Margin = new System.Windows.Forms.Padding(2);
            this.leftBoundaryTrack.Maximum = 255;
            this.leftBoundaryTrack.Name = "leftBoundaryTrack";
            this.leftBoundaryTrack.Size = new System.Drawing.Size(282, 45);
            this.leftBoundaryTrack.TabIndex = 1;
            this.leftBoundaryTrack.TickFrequency = 10;
            this.leftBoundaryTrack.ValueChanged += new System.EventHandler(this.LeftBoundaryTrack_ValueChanged);
            // 
            // leftBoundaryValueTb
            // 
            this.leftBoundaryValueTb.Location = new System.Drawing.Point(26, 318);
            this.leftBoundaryValueTb.Name = "leftBoundaryValueTb";
            this.leftBoundaryValueTb.ReadOnly = true;
            this.leftBoundaryValueTb.Size = new System.Drawing.Size(79, 20);
            this.leftBoundaryValueTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "L";
            // 
            // rightBoundaryTrack
            // 
            this.rightBoundaryTrack.LargeChange = 1;
            this.rightBoundaryTrack.Location = new System.Drawing.Point(110, 366);
            this.rightBoundaryTrack.Margin = new System.Windows.Forms.Padding(2);
            this.rightBoundaryTrack.Maximum = 255;
            this.rightBoundaryTrack.Name = "rightBoundaryTrack";
            this.rightBoundaryTrack.Size = new System.Drawing.Size(282, 45);
            this.rightBoundaryTrack.TabIndex = 4;
            this.rightBoundaryTrack.TickFrequency = 10;
            this.rightBoundaryTrack.Value = 255;
            this.rightBoundaryTrack.ValueChanged += new System.EventHandler(this.RightBoundaryTrack_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // rightBoundaryValueTb
            // 
            this.rightBoundaryValueTb.Location = new System.Drawing.Point(26, 370);
            this.rightBoundaryValueTb.Name = "rightBoundaryValueTb";
            this.rightBoundaryValueTb.ReadOnly = true;
            this.rightBoundaryValueTb.Size = new System.Drawing.Size(79, 20);
            this.rightBoundaryValueTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightBoundaryValueTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightBoundaryTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftBoundaryValueTb);
            this.Controls.Add(this.leftBoundaryTrack);
            this.Controls.Add(this.brightAmountChart);
            this.Name = "ChartsForm";
            this.Text = "Диаграммы";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightAmountChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBoundaryTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBoundaryTrack)).EndInit();
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
        private System.Windows.Forms.Label label5;
    }
}