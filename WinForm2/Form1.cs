using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        private SingleLinkedList posts=new SingleLinkedList();
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
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContent.Text)|| string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Không được bỏ trống thông tin");
                return;
            }
            string postid = posts.GeneratePostId();
            Post p = new Post(textBoxID.Text, textBoxContent.Text, postid, dateTimePickerDate.Value);
            posts.AddLast(p);
            MessageBox.Show($"Đã thêm thành công postid: {postid}");
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
            idNode.Data.Content = textBoxContent.Text;
            idNode.Data.Date = dateTimePickerDate.Value;
            MessageBox.Show($"Đã sửa dữ liệu thành công cho post {idpost}");
            ClearAllTextBoxes(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts.ToList();
        }

        private void bylike_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts.SortLike().ToList();
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
                    MessageBox.Show($"Đã tìm thấy {search.Count()} bài đăng phù hợp");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = search.ToList();
                }   
                else
                {
                    Node node = posts.FindPostId(idpost);
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
            SingleLinkedList ksearch= posts.FilterByKeyWordSort(k);
            MessageBox.Show($"Đã tìm thấy {ksearch.Count()} bài đăng có nội dung phù hợp");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ksearch.ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
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
            bool del = posts.RemoveByPostId(idpost);
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
            dataGridView1.DataSource = posts.SortDate().ToList();
        }

        private void graph_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(posts);
            f.Show();
        }

    }
}
