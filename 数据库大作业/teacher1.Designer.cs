namespace 数据库大作业
{
    partial class teacher1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.txtGradedrop = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.GradeDrop = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.CourseNo = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.StudentNo = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gvescore = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvescore)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStatistic);
            this.splitContainer1.Panel1.Controls.Add(this.txtGradedrop);
            this.splitContainer1.Panel1.Controls.Add(this.txtCno);
            this.splitContainer1.Panel1.Controls.Add(this.txtMark);
            this.splitContainer1.Panel1.Controls.Add(this.txtCname);
            this.splitContainer1.Panel1.Controls.Add(this.GradeDrop);
            this.splitContainer1.Panel1.Controls.Add(this.Grade);
            this.splitContainer1.Panel1.Controls.Add(this.CourseName);
            this.splitContainer1.Panel1.Controls.Add(this.CourseNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtSname);
            this.splitContainer1.Panel1.Controls.Add(this.StudentName);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.txtSno);
            this.splitContainer1.Panel1.Controls.Add(this.StudentNo);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvescore);
            this.splitContainer1.Size = new System.Drawing.Size(1108, 578);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistic.Location = new System.Drawing.Point(927, 132);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(156, 40);
            this.btnStatistic.TabIndex = 16;
            this.btnStatistic.Text = "统计";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtGradedrop
            // 
            this.txtGradedrop.Location = new System.Drawing.Point(723, 59);
            this.txtGradedrop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGradedrop.Name = "txtGradedrop";
            this.txtGradedrop.Size = new System.Drawing.Size(156, 28);
            this.txtGradedrop.TabIndex = 15;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(723, 6);
            this.txtCno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(156, 28);
            this.txtCno.TabIndex = 14;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(354, 62);
            this.txtMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(162, 28);
            this.txtMark.TabIndex = 13;
            this.txtMark.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(69, 59);
            this.txtCname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(174, 28);
            this.txtCname.TabIndex = 12;
            // 
            // GradeDrop
            // 
            this.GradeDrop.AutoSize = true;
            this.GradeDrop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GradeDrop.Location = new System.Drawing.Point(642, 66);
            this.GradeDrop.Name = "GradeDrop";
            this.GradeDrop.Size = new System.Drawing.Size(46, 18);
            this.GradeDrop.TabIndex = 11;
            this.GradeDrop.Text = "绩点";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Grade.Location = new System.Drawing.Point(285, 62);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(46, 18);
            this.Grade.TabIndex = 10;
            this.Grade.Text = "成绩";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseName.Location = new System.Drawing.Point(3, 62);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(65, 18);
            this.CourseName.TabIndex = 9;
            this.CourseName.Text = "课程名";
            // 
            // CourseNo
            // 
            this.CourseNo.AutoSize = true;
            this.CourseNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseNo.Location = new System.Drawing.Point(642, 16);
            this.CourseNo.Name = "CourseNo";
            this.CourseNo.Size = new System.Drawing.Size(66, 18);
            this.CourseNo.TabIndex = 8;
            this.CourseNo.Text = "课程ID";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(354, 11);
            this.txtSname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(162, 28);
            this.txtSname.TabIndex = 7;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentName.Location = new System.Drawing.Point(285, 16);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(46, 18);
            this.StudentName.TabIndex = 6;
            this.StudentName.Text = "姓名";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(690, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 40);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(66, 7);
            this.txtSno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(176, 28);
            this.txtSno.TabIndex = 4;
            // 
            // StudentNo
            // 
            this.StudentNo.AutoSize = true;
            this.StudentNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentNo.Location = new System.Drawing.Point(0, 14);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(66, 18);
            this.StudentNo.TabIndex = 3;
            this.StudentNo.Text = "学生ID";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(66, 131);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 41);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(472, 131);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.Location = new System.Drawing.Point(266, 131);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 41);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "录入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gvescore
            // 
            this.gvescore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvescore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvescore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvescore.Location = new System.Drawing.Point(0, 0);
            this.gvescore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvescore.Name = "gvescore";
            this.gvescore.RowHeadersWidth = 51;
            this.gvescore.RowTemplate.Height = 27;
            this.gvescore.Size = new System.Drawing.Size(1108, 401);
            this.gvescore.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(927, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacher1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 578);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "teacher1";
            this.Text = "学生成绩录入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teacher1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvescore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.TextBox txtGradedrop;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label GradeDrop;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CourseNo;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label StudentNo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView gvescore;
        private System.Windows.Forms.Button button1;
    }
}