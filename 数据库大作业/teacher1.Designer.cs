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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.txtGradedrop = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStatistic);
            this.splitContainer1.Panel1.Controls.Add(this.txtGradedrop);
            this.splitContainer1.Panel1.Controls.Add(this.txtCno);
            this.splitContainer1.Panel1.Controls.Add(this.txtGrade);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(985, 482);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(824, 110);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(139, 33);
            this.btnStatistic.TabIndex = 16;
            this.btnStatistic.Text = "统计";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // txtGradedrop
            // 
            this.txtGradedrop.Location = new System.Drawing.Point(643, 49);
            this.txtGradedrop.Name = "txtGradedrop";
            this.txtGradedrop.Size = new System.Drawing.Size(139, 25);
            this.txtGradedrop.TabIndex = 15;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(643, 5);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(139, 25);
            this.txtCno.TabIndex = 14;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(315, 52);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(144, 25);
            this.txtGrade.TabIndex = 13;
            this.txtGrade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(61, 49);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(155, 25);
            this.txtCname.TabIndex = 12;
            // 
            // GradeDrop
            // 
            this.GradeDrop.AutoSize = true;
            this.GradeDrop.Location = new System.Drawing.Point(571, 55);
            this.GradeDrop.Name = "GradeDrop";
            this.GradeDrop.Size = new System.Drawing.Size(37, 15);
            this.GradeDrop.TabIndex = 11;
            this.GradeDrop.Text = "绩点";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(253, 52);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(37, 15);
            this.Grade.TabIndex = 10;
            this.Grade.Text = "成绩";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(3, 52);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(52, 15);
            this.CourseName.TabIndex = 9;
            this.CourseName.Text = "课程名";
            // 
            // CourseNo
            // 
            this.CourseNo.AutoSize = true;
            this.CourseNo.Location = new System.Drawing.Point(571, 13);
            this.CourseNo.Name = "CourseNo";
            this.CourseNo.Size = new System.Drawing.Size(52, 15);
            this.CourseNo.TabIndex = 8;
            this.CourseNo.Text = "课程号";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(315, 9);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(144, 25);
            this.txtSname.TabIndex = 7;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(253, 13);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(37, 15);
            this.StudentName.TabIndex = 6;
            this.StudentName.Text = "姓名";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(613, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(59, 6);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(157, 25);
            this.txtSno.TabIndex = 4;
            // 
            // StudentNo
            // 
            this.StudentNo.AutoSize = true;
            this.StudentNo.Location = new System.Drawing.Point(12, 9);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(37, 15);
            this.StudentNo.TabIndex = 3;
            this.StudentNo.Text = "学号";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(59, 109);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(127, 34);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(236, 109);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 34);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "录入";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(985, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // teacher1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "teacher1";
            this.Text = "学生成绩录入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.TextBox txtGradedrop;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtGrade;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}