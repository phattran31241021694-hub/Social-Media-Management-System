using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinForm2
{
    public partial class Form2 : Form
    {
        private SingleLinkedList posts;
        public Form2(SingleLinkedList posts)
        {
            InitializeComponent();
            this.posts = posts;
        }

        private void DrawChart()
        {
            if (posts == null) return;

            if (!int.TryParse(textBox1yinp.Text.Trim(), out int y))
            {
                MessageBox.Show("Năm phải là số nguyên!");
                return;
            }

            StatsList stats = posts.MonthStatistic(y);

            analystchart.Series.Clear();
            analystchart.ChartAreas.Clear();

            // Tạo ChartArea
            var area = new ChartArea("Main");
            analystchart.ChartAreas.Add(area);
            var s = analystchart.Series.Add("Posts");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;

            StatsNode cur = stats.Head;
            while (cur != null)
            {
                s.Points.AddXY(cur.Data.Month, cur.Data.PostCount);
                cur = cur.Next;
            }
        }

        private void enter_Click_Click(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void analystchart_Click(object sender, EventArgs e)
        {

        }
    }
}
