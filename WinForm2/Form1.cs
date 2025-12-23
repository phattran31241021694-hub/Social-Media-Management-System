using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        private SingleLinkedList posts=new SingleLinkedList();
        private TimeLogList timehistory=new TimeLogList();
        public Form1()
        {
            InitializeComponent();

        }
        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();
                else if (c.HasChildren)
                    ClearAllTextBoxes(c);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);

            dataGridView1.GridColor = Color.LightGray;
            posts = SamplePostGenerator.Generate(2024);
            posts.LastPostNumber();
            MessageBox.Show($"Trang hiện có {posts.Count()} bài đăng");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = posts.ToList();
            menu_panel.Visible = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContent.Text)|| string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Không được bỏ trống thông tin");
                return;
            }
            string postid = "";
            RunMultipleTimes(() =>
            {
                string postid_1 = posts.GeneratePostId();
                Post p_1 = new Post(textBoxID.Text, textBoxContent.Text, postid_1, dateTimePickerDate.Value);
                posts.AddLast(p_1);
            }, "Thêm dữ liệu");
            MessageBox.Show($"Đã thêm thành công postid: {postid}"); ;
            ClearAllTextBoxes(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts.ToList();

        }

        private void Fix_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            string idpost = textBoxIDpost.Text.Trim();
            Node idNode = posts.FindPostId(idpost);
            if (idNode == null)
            {
                MessageBox.Show("Không tìm thấy PostID");
                return;
            }
            if (!string.IsNullOrWhiteSpace(id)&&!string.Equals(id, idNode.Data.Id, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("PostID không thuộc đúng Id");
                return;
            }
            RunMultipleTimes(() =>
            {
                Node idPost_1 = posts.FindPostId(idpost);
                idNode.Data.Content = textBoxContent.Text;
                idNode.Data.Date = dateTimePickerDate.Value;
            }, "Sửa dữ liệu");
            MessageBox.Show($"Đã sửa dữ liệu thành công cho post {idpost}");
            ClearAllTextBoxes(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts.ToList();
        }

        private void bylike_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Post> SortLikes = new List<Post>();
            RunMultipleTimes(() =>
            {
                SortLikes = posts.SortLike().ToList();
            }, "Lọc theo lượt thích");
            dataGridView1.DataSource = SortLikes;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            string idpost = textBoxIDpost.Text.Trim();
            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(idpost))
            {
                MessageBox.Show("Không được bỏ trống thông tin");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(idpost))
                {
                    SingleLinkedList search = posts.FindID(id);
                    RunMultipleTimes(() =>
                    {
                        SingleLinkedList search_1 = posts.FindID(id);
                    }, "Tìm kiếm theo ID");
                    MessageBox.Show($"Đã tìm thấy {search.Count()} bài đăng phù hợp");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = search.ToList();
                }   
                else
                {
                    Node node = posts.FindPostId(idpost);
                    RunMultipleTimes(() =>
                    {
                        Node node_1 = posts.FindPostId(idpost);
                    }, "Tìm kiếm theo postID");
                    if (node == null)
                    {
                        MessageBox.Show("Không tìm thấy PostID");
                        return;
                    }
                    Post id_check = node.Data.Clone();
                    if (!string.IsNullOrWhiteSpace(id)&&!string.Equals(id, id_check.Id, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("PostID không thuộc đúng Id");
                        return;
                    }
                    dataGridView1.DataSource = null;
                    SingleLinkedList n = new SingleLinkedList();
                    n.AddLast(id_check);
                    dataGridView1.DataSource = n.ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = n.ToList();
                }

            }    
        }

        private void CtSearch_Click(object sender, EventArgs e)
        {
            string k = textBoxContent.Text;
            RunMultipleTimes(() =>
            {
                SingleLinkedList ksearch_1 = posts.FilterByKeyWordSort(k);
            }, "Tra cứu theo từ khóa");
            SingleLinkedList ksearch= posts.FilterByKeyWordSort(k);
            MessageBox.Show($"Đã tìm thấy {ksearch.Count()} bài đăng có nội dung phù hợp");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ksearch.ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RunMultipleTimes(() =>
            {
                SingleLinkedList filter_1 = posts.FilterByDateTimeRange(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            }, "Lọc giữa 2 khoảng thời gian");
            SingleLinkedList filter = posts.FilterByDateTimeRange(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            MessageBox.Show($"Hiện có {filter.Count()} bài đăng");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =filter.ToList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            string id = textBoxID.Text.Trim();
            string idpost = textBoxIDpost.Text.Trim();
            Node idNode = posts.FindPostId(idpost);
            bool del=false;
            RunMultipleTimes(() =>
            {
                del = posts.RemoveByPostId(idpost);
            }, "Xóa dữ liệu");
            if (idpost == null)
            {
                MessageBox.Show("Vui lòng điền IDPost để xóa");
                return;
            }
            if (!string.IsNullOrWhiteSpace(id) && !string.Equals(id, idNode.Data.Id, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("PostID không thuộc đúng Id");
                return;
            }
            if (!del)
            {
                MessageBox.Show("Không tìm thấy PostID");
                return;
            }
            MessageBox.Show($"Đã xóa dữ liệu thành công post {textBoxIDpost.Text}");
            ClearAllTextBoxes(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts.ToList();
        }
        private void bydate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Post> SortDates = new List<Post>();
            RunMultipleTimes(() =>
            {
                SortDates = posts.SortDate().ToList();
            }, "Lọc theo ngày");
            dataGridView1.DataSource = SortDates;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (function.Width==40)
            {
                function.BackColor = Color.LightSkyBlue;
                function.Width = 160;
            }
            else
            {
                function.Width = 40;
                function.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            menu_panel.Visible = true;
            ranking_panel.Visible = false;
            time_manage.Visible = false;
        }

        private void ranking_Click(object sender, EventArgs e)
        {
            time_manage.Visible = false;
            menu_panel.Visible = false;
            ranking_panel.Visible = true;
        }
        private void DrawChart(StatsList stats)
        {
            ranking_chart.Series.Clear();
            var postSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Số bài viết");
            postSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            postSeries.IsValueShownAsLabel = true;
            StatsNode cur = stats.Head;
            while (cur != null)
            {
                postSeries.Points.AddXY(cur.Data.Month, cur.Data.PostCount);

                cur = cur.Next;
            }
            ranking_chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ranking_chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ranking_chart.Series.Add(postSeries);
        }

        private void yearinp_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Yearinp.Text, out int year))
            {
                DrawChart(posts.MonthStatistic(2024));
                time_manage.Visible = false;
                menu_panel.Visible = false;
                ranking_panel.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống, nhập năm là một số nguyên hợp lệ (Ví dụ: 2024)!");
            }
        }

        private void ranking_chart_Click(object sender, EventArgs e)
        {

        }
        private void DrawPerformanceComparison()
        {
            time_collection.Series.Clear();
            time_collection.ChartAreas[0].AxisX.Title = "Số lượng phần tử (N)";
            time_collection.ChartAreas[0].AxisY.Title = "Thời gian (ms)";

            // Danh sách các tên thuật toán tương ứng với các Series
            string[] algoNames = {
        "Lọc theo lượt thích", "Tra cứu theo từ khóa", "Lọc giữa 2 khoảng thời gian",
        "Lọc theo ngày", "Tìm kiếm theo ID", "Tìm kiếm theo postID",
        "Thêm dữ liệu", "Xóa dữ liệu", "Sửa dữ liệu"
    };

            foreach (var name in algoNames)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series(name)
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, // Quan trọng: để thấy điểm đơn lẻ
                    MarkerSize = 8
                };

                // Lọc dữ liệu từ timehistory cho series này
                int number=1;
                TimeLogNode cur = timehistory.Head;
                bool hasData = false;
                while (cur != null)
                {
                    if (cur.Data.AlgorithmName.Contains(name))
                    {
                        series.Points.AddXY(number++, cur.Data.ExecutionTimeMs);
                        hasData = true;
                    }
                    cur = cur.Next;
                }

                // Chỉ thêm vào Chart nếu Series đó có dữ liệu
                if (hasData)
                {
                    time_collection.Series.Add(series);
                }
            }

            time_collection.Invalidate(); // Ép chart vẽ lại
        }
        private void advance_Click(object sender, EventArgs e)
        {
            menu_panel.Visible = false;
            ranking_panel.Visible = false;
            DrawPerformanceComparison();
            averageTime.DataSource = null;
            averageTime.DefaultCellStyle.ForeColor = Color.Black;
            averageTime.EnableHeadersVisualStyles = false;
            averageTime.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            averageTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            averageTime.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            averageTime.GridColor = Color.LightGray;
            averageTime.DataSource = timehistory.GroupByAlgorithm().ToList();
            time_manage.Visible = true;
            time_manage.BringToFront();
        }

        private void ranking_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RunMultipleTimes(Action action, string algorithmName)
        {
            int times = (int)time_ex.Value;

            for (int i = 0; i < times; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                action();
                sw.Stop();

                timehistory.AddLog(
                    new TimeLog(algorithmName, sw.Elapsed.TotalMilliseconds,timehistory.GenerateDataId())
                );
            }
        }
        private void ranking_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
