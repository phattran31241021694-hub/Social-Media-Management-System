namespace WinForm2
{
    partial class Form2
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
            this.yearinp = new System.Windows.Forms.Label();
            this.textBox1yinp = new System.Windows.Forms.TextBox();
            this.enter_Click = new System.Windows.Forms.Button();
            this.analystchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.analystchart)).BeginInit();
            this.SuspendLayout();
            // 
            // yearinp
            // 
            this.yearinp.AutoSize = true;
            this.yearinp.Location = new System.Drawing.Point(967, 22);
            this.yearinp.Name = "yearinp";
            this.yearinp.Size = new System.Drawing.Size(42, 20);
            this.yearinp.TabIndex = 3;
            this.yearinp.Text = "Năm";
            // 
            // textBox1yinp
            // 
            this.textBox1yinp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1yinp.Location = new System.Drawing.Point(1029, 22);
            this.textBox1yinp.Name = "textBox1yinp";
            this.textBox1yinp.Size = new System.Drawing.Size(202, 26);
            this.textBox1yinp.TabIndex = 2;
            // 
            // enter_Click
            // 
            this.enter_Click.Location = new System.Drawing.Point(1114, 54);
            this.enter_Click.Name = "enter_Click";
            this.enter_Click.Size = new System.Drawing.Size(117, 35);
            this.enter_Click.TabIndex = 5;
            this.enter_Click.Text = "Xuất";
            this.enter_Click.UseVisualStyleBackColor = true;
            this.enter_Click.Click += new System.EventHandler(this.enter_Click_Click);
            // 
            // analystchart
            // 
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.analystchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.analystchart.Legends.Add(legend1);
            this.analystchart.Location = new System.Drawing.Point(12, 12);
            this.analystchart.Name = "analystchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            this.analystchart.Series.Add(series1);
            this.analystchart.Size = new System.Drawing.Size(846, 564);
            this.analystchart.TabIndex = 6;
            this.analystchart.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 608);
            this.Controls.Add(this.analystchart);
            this.Controls.Add(this.enter_Click);
            this.Controls.Add(this.yearinp);
            this.Controls.Add(this.textBox1yinp);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.analystchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yearinp;
        private System.Windows.Forms.TextBox textBox1yinp;
        private System.Windows.Forms.Button enter_Click;
        private System.Windows.Forms.DataVisualization.Charting.Chart analystchart;
    }
}