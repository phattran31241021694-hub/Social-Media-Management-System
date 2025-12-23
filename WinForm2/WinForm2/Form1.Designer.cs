namespace WinForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.function = new System.Windows.Forms.Panel();
            this.ranking = new System.Windows.Forms.Button();
            this.advance = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.Refresh_1 = new System.Windows.Forms.Button();
            this.CtSearch = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Label();
            this.bylike = new System.Windows.Forms.Button();
            this.bydate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Fix = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.Fromdate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDpost = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.IDpost = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ranking_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.yearinp = new System.Windows.Forms.Label();
            this.textBox_Yearinp = new System.Windows.Forms.TextBox();
            this.enter_Click = new System.Windows.Forms.Button();
            this.ranking_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.time_manage = new System.Windows.Forms.Panel();
            this.averageTime = new System.Windows.Forms.DataGridView();
            this.time_collection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.escape = new System.Windows.Forms.Button();
            this.time_ex = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.function.SuspendLayout();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ranking_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranking_chart)).BeginInit();
            this.time_manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_collection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_ex)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 111);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(102, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Menu
            // 
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(24, 27);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(72, 56);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // function
            // 
            this.function.BackColor = System.Drawing.Color.Transparent;
            this.function.Controls.Add(this.escape);
            this.function.Controls.Add(this.ranking);
            this.function.Controls.Add(this.advance);
            this.function.Controls.Add(this.Home);
            this.function.Dock = System.Windows.Forms.DockStyle.Left;
            this.function.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.function.Location = new System.Drawing.Point(0, 111);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(60, 709);
            this.function.TabIndex = 0;
            this.function.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ranking
            // 
            this.ranking.BackColor = System.Drawing.Color.Transparent;
            this.ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranking.Image = ((System.Drawing.Image)(resources.GetObject("ranking.Image")));
            this.ranking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ranking.Location = new System.Drawing.Point(0, 115);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(238, 57);
            this.ranking.TabIndex = 39;
            this.ranking.Text = "Ranking";
            this.ranking.UseVisualStyleBackColor = false;
            this.ranking.Click += new System.EventHandler(this.ranking_Click);
            // 
            // advance
            // 
            this.advance.BackColor = System.Drawing.Color.Transparent;
            this.advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advance.Image = ((System.Drawing.Image)(resources.GetObject("advance.Image")));
            this.advance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advance.Location = new System.Drawing.Point(0, 190);
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(238, 57);
            this.advance.TabIndex = 38;
            this.advance.Text = "Advance";
            this.advance.UseVisualStyleBackColor = false;
            this.advance.Click += new System.EventHandler(this.advance_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 41);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(241, 59);
            this.Home.TabIndex = 37;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.Refresh_1);
            this.menu_panel.Controls.Add(this.CtSearch);
            this.menu_panel.Controls.Add(this.Sort);
            this.menu_panel.Controls.Add(this.bylike);
            this.menu_panel.Controls.Add(this.bydate);
            this.menu_panel.Controls.Add(this.dataGridView1);
            this.menu_panel.Controls.Add(this.Search);
            this.menu_panel.Controls.Add(this.Fix);
            this.menu_panel.Controls.Add(this.Delete);
            this.menu_panel.Controls.Add(this.Add);
            this.menu_panel.Controls.Add(this.label1);
            this.menu_panel.Controls.Add(this.dateTimePickerToDate);
            this.menu_panel.Controls.Add(this.Fromdate);
            this.menu_panel.Controls.Add(this.dateTimePickerFromDate);
            this.menu_panel.Controls.Add(this.textBoxContent);
            this.menu_panel.Controls.Add(this.dateTimePickerDate);
            this.menu_panel.Controls.Add(this.textBoxIDpost);
            this.menu_panel.Controls.Add(this.textBoxID);
            this.menu_panel.Controls.Add(this.Content);
            this.menu_panel.Controls.Add(this.Date);
            this.menu_panel.Controls.Add(this.IDpost);
            this.menu_panel.Controls.Add(this.ID);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_panel.Location = new System.Drawing.Point(60, 111);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1740, 709);
            this.menu_panel.TabIndex = 0;
            // 
            // Refresh_1
            // 
            this.Refresh_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Refresh_1.Location = new System.Drawing.Point(1423, 24);
            this.Refresh_1.Name = "Refresh_1";
            this.Refresh_1.Size = new System.Drawing.Size(91, 41);
            this.Refresh_1.TabIndex = 58;
            this.Refresh_1.Text = "Làm mới";
            this.Refresh_1.UseVisualStyleBackColor = true;
            this.Refresh_1.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // CtSearch
            // 
            this.CtSearch.ForeColor = System.Drawing.Color.Black;
            this.CtSearch.Location = new System.Drawing.Point(430, 349);
            this.CtSearch.Name = "CtSearch";
            this.CtSearch.Size = new System.Drawing.Size(92, 43);
            this.CtSearch.TabIndex = 57;
            this.CtSearch.Text = "Tra cứu";
            this.CtSearch.UseVisualStyleBackColor = true;
            this.CtSearch.Click += new System.EventHandler(this.CtSearch_Click);
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sort.Location = new System.Drawing.Point(620, 24);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(35, 20);
            this.Sort.TabIndex = 56;
            this.Sort.Text = "Lọc";
            // 
            // bylike
            // 
            this.bylike.ForeColor = System.Drawing.Color.Black;
            this.bylike.Location = new System.Drawing.Point(777, 14);
            this.bylike.Name = "bylike";
            this.bylike.Size = new System.Drawing.Size(89, 41);
            this.bylike.TabIndex = 54;
            this.bylike.Text = "Lượt thích";
            this.bylike.UseVisualStyleBackColor = true;
            this.bylike.Click += new System.EventHandler(this.bylike_Click);
            // 
            // bydate
            // 
            this.bydate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bydate.Location = new System.Drawing.Point(682, 14);
            this.bydate.Name = "bydate";
            this.bydate.Size = new System.Drawing.Size(89, 41);
            this.bydate.TabIndex = 53;
            this.bydate.Text = "Ngày";
            this.bydate.UseVisualStyleBackColor = true;
            this.bydate.Click += new System.EventHandler(this.bydate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(599, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(926, 515);
            this.dataGridView1.TabIndex = 52;
            // 
            // Search
            // 
            this.Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Location = new System.Drawing.Point(33, 541);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(163, 50);
            this.Search.TabIndex = 51;
            this.Search.Text = "Tìm kiếm";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Fix
            // 
            this.Fix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fix.Location = new System.Drawing.Point(402, 550);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(89, 41);
            this.Fix.TabIndex = 50;
            this.Fix.Text = "Sửa";
            this.Fix.UseVisualStyleBackColor = true;
            this.Fix.Click += new System.EventHandler(this.Fix_Click);
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(307, 550);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 41);
            this.Delete.TabIndex = 49;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(212, 550);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 41);
            this.Add.TabIndex = 48;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "ToDate:";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(124, 475);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerToDate.TabIndex = 46;
            // 
            // Fromdate
            // 
            this.Fromdate.AutoSize = true;
            this.Fromdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fromdate.Location = new System.Drawing.Point(31, 407);
            this.Fromdate.Name = "Fromdate";
            this.Fromdate.Size = new System.Drawing.Size(82, 20);
            this.Fromdate.TabIndex = 45;
            this.Fromdate.Text = "Fromdate:";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(124, 401);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerFromDate.TabIndex = 44;
            this.dateTimePickerFromDate.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxContent.Location = new System.Drawing.Point(124, 208);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(398, 135);
            this.textBoxContent.TabIndex = 43;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePickerDate.Location = new System.Drawing.Point(124, 149);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerDate.TabIndex = 42;
            // 
            // textBoxIDpost
            // 
            this.textBoxIDpost.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIDpost.Location = new System.Drawing.Point(124, 98);
            this.textBoxIDpost.MaxLength = 5;
            this.textBoxIDpost.Name = "textBoxIDpost";
            this.textBoxIDpost.Size = new System.Drawing.Size(211, 26);
            this.textBoxIDpost.TabIndex = 41;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxID.Location = new System.Drawing.Point(124, 52);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(211, 26);
            this.textBoxID.TabIndex = 40;
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Content.Location = new System.Drawing.Point(29, 208);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(70, 20);
            this.Content.TabIndex = 39;
            this.Content.Text = "Content:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.Location = new System.Drawing.Point(51, 149);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 20);
            this.Date.TabIndex = 38;
            this.Date.Text = "Date:";
            // 
            // IDpost
            // 
            this.IDpost.AutoSize = true;
            this.IDpost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDpost.Location = new System.Drawing.Point(38, 98);
            this.IDpost.Name = "IDpost";
            this.IDpost.Size = new System.Drawing.Size(65, 20);
            this.IDpost.TabIndex = 37;
            this.IDpost.Text = "ID post:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(73, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 20);
            this.ID.TabIndex = 36;
            this.ID.Text = "ID:";
            // 
            // ranking_panel
            // 
            this.ranking_panel.Controls.Add(this.yearinp);
            this.ranking_panel.Controls.Add(this.textBox_Yearinp);
            this.ranking_panel.Controls.Add(this.enter_Click);
            this.ranking_panel.Controls.Add(this.ranking_chart);
            this.ranking_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ranking_panel.Location = new System.Drawing.Point(60, 111);
            this.ranking_panel.Name = "ranking_panel";
            this.ranking_panel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.ranking_panel.Size = new System.Drawing.Size(1740, 709);
            this.ranking_panel.TabIndex = 59;
            this.ranking_panel.Visible = false;
            this.ranking_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ranking_panel_Paint_1);
            // 
            // yearinp
            // 
            this.yearinp.AutoSize = true;
            this.yearinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearinp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearinp.Location = new System.Drawing.Point(13, 20);
            this.yearinp.Name = "yearinp";
            this.yearinp.Size = new System.Drawing.Size(76, 29);
            this.yearinp.TabIndex = 7;
            this.yearinp.Text = "Năm: ";
            this.yearinp.Click += new System.EventHandler(this.yearinp_Click);
            // 
            // textBox_Yearinp
            // 
            this.textBox_Yearinp.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Yearinp.Location = new System.Drawing.Point(95, 23);
            this.textBox_Yearinp.Name = "textBox_Yearinp";
            this.textBox_Yearinp.Size = new System.Drawing.Size(202, 26);
            this.textBox_Yearinp.TabIndex = 6;
            // 
            // enter_Click
            // 
            this.enter_Click.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_Click.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enter_Click.Location = new System.Drawing.Point(303, 23);
            this.enter_Click.Name = "enter_Click";
            this.enter_Click.Size = new System.Drawing.Size(104, 45);
            this.enter_Click.TabIndex = 8;
            this.enter_Click.Text = "Xuất";
            this.enter_Click.UseVisualStyleBackColor = true;
            this.enter_Click.Click += new System.EventHandler(this.enter_Click_Click);
            // 
            // ranking_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.ranking_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ranking_chart.Legends.Add(legend5);
            this.ranking_chart.Location = new System.Drawing.Point(413, 23);
            this.ranking_chart.Name = "ranking_chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Postnumbers";
            this.ranking_chart.Series.Add(series5);
            this.ranking_chart.Size = new System.Drawing.Size(1237, 591);
            this.ranking_chart.TabIndex = 1;
            this.ranking_chart.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "title";
            title3.Text = "Thống kê bài đăng theo tháng";
            this.ranking_chart.Titles.Add(title3);
            this.ranking_chart.Click += new System.EventHandler(this.ranking_chart_Click);
            // 
            // time_manage
            // 
            this.time_manage.Controls.Add(this.label4);
            this.time_manage.Controls.Add(this.label3);
            this.time_manage.Controls.Add(this.time_ex);
            this.time_manage.Controls.Add(this.averageTime);
            this.time_manage.Controls.Add(this.time_collection);
            this.time_manage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_manage.Location = new System.Drawing.Point(60, 111);
            this.time_manage.Name = "time_manage";
            this.time_manage.Size = new System.Drawing.Size(1740, 709);
            this.time_manage.TabIndex = 60;
            // 
            // averageTime
            // 
            this.averageTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.averageTime.Location = new System.Drawing.Point(15, 115);
            this.averageTime.Name = "averageTime";
            this.averageTime.RowHeadersWidth = 62;
            this.averageTime.RowTemplate.Height = 28;
            this.averageTime.Size = new System.Drawing.Size(549, 539);
            this.averageTime.TabIndex = 1;
            // 
            // time_collection
            // 
            chartArea6.Name = "ChartArea1";
            this.time_collection.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.time_collection.Legends.Add(legend6);
            this.time_collection.Location = new System.Drawing.Point(573, 115);
            this.time_collection.Name = "time_collection";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.time_collection.Series.Add(series6);
            this.time_collection.Size = new System.Drawing.Size(952, 539);
            this.time_collection.TabIndex = 0;
            this.time_collection.Text = "chart1";
            // 
            // escape
            // 
            this.escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escape.Image = ((System.Drawing.Image)(resources.GetObject("escape.Image")));
            this.escape.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.escape.Location = new System.Drawing.Point(0, 597);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(241, 58);
            this.escape.TabIndex = 40;
            this.escape.Text = "Đăng xuất";
            this.escape.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.escape.UseVisualStyleBackColor = true;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // time_ex
            // 
            this.time_ex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_ex.Location = new System.Drawing.Point(873, 41);
            this.time_ex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time_ex.Name = "time_ex";
            this.time_ex.Size = new System.Drawing.Size(120, 26);
            this.time_ex.TabIndex = 2;
            this.time_ex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(716, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lần nhấn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time Test Information\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1800, 820);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.ranking_panel);
            this.Controls.Add(this.time_manage);
            this.Controls.Add(this.function);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.function.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ranking_panel.ResumeLayout(false);
            this.ranking_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranking_chart)).EndInit();
            this.time_manage.ResumeLayout(false);
            this.time_manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_collection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_ex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Panel function;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button ranking;
        private System.Windows.Forms.Button advance;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button CtSearch;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.Button bylike;
        private System.Windows.Forms.Button bydate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Fix;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label Fromdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxIDpost;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label IDpost;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Refresh_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ranking_chart;
        private System.Windows.Forms.Label yearinp;
        private System.Windows.Forms.TextBox textBox_Yearinp;
        private System.Windows.Forms.Button enter_Click;
        private System.Windows.Forms.FlowLayoutPanel ranking_panel;
        private System.Windows.Forms.Panel time_manage;
        private System.Windows.Forms.DataGridView averageTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart time_collection;
        private System.Windows.Forms.Button escape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown time_ex;
        private System.Windows.Forms.Label label4;
    }
}

