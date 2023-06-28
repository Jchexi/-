namespace 数据库大作业
{
    partial class teacher2
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
            this.gvescore = new System.Windows.Forms.DataGridView();
            this.btnSelectStudentID = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.Sno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSelectClass = new System.Windows.Forms.Button();
            this.btnSelectGrade = new System.Windows.Forms.Button();
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectGrade);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectClass);
            this.splitContainer1.Panel1.Controls.Add(this.txtGrade);
            this.splitContainer1.Panel1.Controls.Add(this.txtClass);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSno);
            this.splitContainer1.Panel1.Controls.Add(this.Sno);
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectStudentID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvescore);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // gvescore
            // 
            this.gvescore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvescore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvescore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvescore.Location = new System.Drawing.Point(0, 0);
            this.gvescore.Name = "gvescore";
            this.gvescore.RowHeadersWidth = 51;
            this.gvescore.RowTemplate.Height = 27;
            this.gvescore.Size = new System.Drawing.Size(800, 346);
            this.gvescore.TabIndex = 0;
            // 
            // btnSelectStudentID
            // 
            this.btnSelectStudentID.Location = new System.Drawing.Point(12, 69);
            this.btnSelectStudentID.Name = "btnSelectStudentID";
            this.btnSelectStudentID.Size = new System.Drawing.Size(132, 31);
            this.btnSelectStudentID.TabIndex = 0;
            this.btnSelectStudentID.Text = "查询学生ID";
            this.btnSelectStudentID.UseVisualStyleBackColor = true;
            this.btnSelectStudentID.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(611, 69);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 31);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出成绩";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // Sno
            // 
            this.Sno.AutoSize = true;
            this.Sno.Location = new System.Drawing.Point(23, 0);
            this.Sno.Name = "Sno";
            this.Sno.Size = new System.Drawing.Size(53, 15);
            this.Sno.TabIndex = 2;
            this.Sno.Text = "学生ID";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(84, 0);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(148, 25);
            this.txtSno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "年级";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(362, 0);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(154, 25);
            this.txtClass.TabIndex = 6;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(621, 0);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(148, 25);
            this.txtGrade.TabIndex = 7;
            // 
            // btnSelectClass
            // 
            this.btnSelectClass.Location = new System.Drawing.Point(225, 69);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new System.Drawing.Size(122, 31);
            this.btnSelectClass.TabIndex = 8;
            this.btnSelectClass.Text = "查询班级";
            this.btnSelectClass.UseVisualStyleBackColor = true;
            // 
            // btnSelectGrade
            // 
            this.btnSelectGrade.Location = new System.Drawing.Point(413, 69);
            this.btnSelectGrade.Name = "btnSelectGrade";
            this.btnSelectGrade.Size = new System.Drawing.Size(129, 31);
            this.btnSelectGrade.TabIndex = 9;
            this.btnSelectGrade.Text = "查询班级";
            this.btnSelectGrade.UseVisualStyleBackColor = true;
            // 
            // teacher2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "teacher2";
            this.Text = "teacher2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teacher2_Load);
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
        private System.Windows.Forms.DataGridView gvescore;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label Sno;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSelectStudentID;
        private System.Windows.Forms.Button btnSelectGrade;
        private System.Windows.Forms.Button btnSelectClass;
    }
}