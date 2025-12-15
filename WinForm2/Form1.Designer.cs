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
            this.ID = new System.Windows.Forms.Label();
            this.IDpost = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxIDpost = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.Fromdate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.Button();
            this.Fix = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.Button();
            this.bylike = new System.Windows.Forms.Button();
            this.bydate = new System.Windows.Forms.Button();
            this.CtSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(63, 50);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            // 
            // IDpost
            // 
            this.IDpost.AutoSize = true;
            this.IDpost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDpost.Location = new System.Drawing.Point(28, 96);
            this.IDpost.Name = "IDpost";
            this.IDpost.Size = new System.Drawing.Size(65, 20);
            this.IDpost.TabIndex = 1;
            this.IDpost.Text = "ID post:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.Location = new System.Drawing.Point(41, 147);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 20);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date:";
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Content.Location = new System.Drawing.Point(19, 206);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(70, 20);
            this.Content.TabIndex = 4;
            this.Content.Text = "Content:";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxID.Location = new System.Drawing.Point(114, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(211, 26);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxIDpost
            // 
            this.textBoxIDpost.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIDpost.Location = new System.Drawing.Point(114, 96);
            this.textBoxIDpost.MaxLength = 5;
            this.textBoxIDpost.Name = "textBoxIDpost";
            this.textBoxIDpost.Size = new System.Drawing.Size(211, 26);
            this.textBoxIDpost.TabIndex = 10;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePickerDate.Location = new System.Drawing.Point(114, 147);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxContent.Location = new System.Drawing.Point(114, 206);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(398, 135);
            this.textBoxContent.TabIndex = 20;
            // 
            // Fromdate
            // 
            this.Fromdate.AutoSize = true;
            this.Fromdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fromdate.Location = new System.Drawing.Point(21, 405);
            this.Fromdate.Name = "Fromdate";
            this.Fromdate.Size = new System.Drawing.Size(82, 20);
            this.Fromdate.TabIndex = 22;
            this.Fromdate.Text = "Fromdate:";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(114, 399);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerFromDate.TabIndex = 21;
            this.dateTimePickerFromDate.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fromdate:";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(114, 473);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(267, 26);
            this.dateTimePickerToDate.TabIndex = 23;
            // 
            // Search
            // 
            this.Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Location = new System.Drawing.Point(23, 539);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(163, 50);
            this.Search.TabIndex = 28;
            this.Search.Text = "Tìm kiếm";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Fix
            // 
            this.Fix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fix.Location = new System.Drawing.Point(392, 548);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(89, 41);
            this.Fix.TabIndex = 27;
            this.Fix.Text = "Sửa";
            this.Fix.UseVisualStyleBackColor = true;
            this.Fix.Click += new System.EventHandler(this.Fix_Click);
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(297, 548);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 41);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(202, 548);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 41);
            this.Add.TabIndex = 25;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(926, 515);
            this.dataGridView1.TabIndex = 29;
            // 
            // Refresh
            // 
            this.Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Refresh.Location = new System.Drawing.Point(1413, 22);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(89, 41);
            this.Refresh.TabIndex = 30;
            this.Refresh.Text = "Làm mới";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sort.Location = new System.Drawing.Point(610, 22);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(35, 20);
            this.Sort.TabIndex = 34;
            this.Sort.Text = "Lọc";
            // 
            // Graph
            // 
            this.Graph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Graph.Location = new System.Drawing.Point(1318, 22);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(89, 41);
            this.Graph.TabIndex = 33;
            this.Graph.Text = "Biểu đồ";
            this.Graph.UseVisualStyleBackColor = true;
            this.Graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // bylike
            // 
            this.bylike.ForeColor = System.Drawing.Color.Black;
            this.bylike.Location = new System.Drawing.Point(767, 12);
            this.bylike.Name = "bylike";
            this.bylike.Size = new System.Drawing.Size(89, 41);
            this.bylike.TabIndex = 32;
            this.bylike.Text = "Lượt thích";
            this.bylike.UseVisualStyleBackColor = true;
            this.bylike.Click += new System.EventHandler(this.bylike_Click);
            // 
            // bydate
            // 
            this.bydate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bydate.Location = new System.Drawing.Point(672, 12);
            this.bydate.Name = "bydate";
            this.bydate.Size = new System.Drawing.Size(89, 41);
            this.bydate.TabIndex = 31;
            this.bydate.Text = "Ngày";
            this.bydate.UseVisualStyleBackColor = true;
            this.bydate.Click += new System.EventHandler(this.bydate_Click);
            // 
            // CtSearch
            // 
            this.CtSearch.ForeColor = System.Drawing.Color.Black;
            this.CtSearch.Location = new System.Drawing.Point(420, 347);
            this.CtSearch.Name = "CtSearch";
            this.CtSearch.Size = new System.Drawing.Size(92, 43);
            this.CtSearch.TabIndex = 35;
            this.CtSearch.Text = "Tra cứu";
            this.CtSearch.UseVisualStyleBackColor = true;
            this.CtSearch.Click += new System.EventHandler(this.CtSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1543, 633);
            this.Controls.Add(this.CtSearch);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.bylike);
            this.Controls.Add(this.bydate);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Fix);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.Fromdate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxIDpost);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.IDpost);
            this.Controls.Add(this.ID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label IDpost;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxIDpost;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label Fromdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Fix;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.Button Graph;
        private System.Windows.Forms.Button bylike;
        private System.Windows.Forms.Button bydate;
        private System.Windows.Forms.Button CtSearch;
    }
}

