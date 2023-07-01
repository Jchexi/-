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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectGrade = new System.Windows.Forms.Button();
            this.btnSelectClass = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.Sno = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSelectStudentID = new System.Windows.Forms.Button();
            this.gvescore = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.splitContainer1.Size = new System.Drawing.Size(900, 540);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSelectGrade
            // 
            this.btnSelectGrade.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectGrade.Location = new System.Drawing.Point(352, 83);
            this.btnSelectGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectGrade.Name = "btnSelectGrade";
            this.btnSelectGrade.Size = new System.Drawing.Size(145, 37);
            this.btnSelectGrade.TabIndex = 9;
            this.btnSelectGrade.Text = "查询年级";
            this.btnSelectGrade.UseVisualStyleBackColor = true;
            this.btnSelectGrade.Click += new System.EventHandler(this.btnSelectGrade_Click);
            // 
            // btnSelectClass
            // 
            this.btnSelectClass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectClass.Location = new System.Drawing.Point(184, 83);
            this.btnSelectClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new System.Drawing.Size(137, 37);
            this.btnSelectClass.TabIndex = 8;
            this.btnSelectClass.Text = "查询班级";
            this.btnSelectClass.UseVisualStyleBackColor = true;
            this.btnSelectClass.Click += new System.EventHandler(this.btnSelectClass_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(687, 7);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(166, 28);
            this.txtGrade.TabIndex = 7;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(402, 8);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(173, 28);
            this.txtClass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(618, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "年级";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(330, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "班级";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(91, 8);
            this.txtSno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(166, 28);
            this.txtSno.TabIndex = 3;
            // 
            // Sno
            // 
            this.Sno.AutoSize = true;
            this.Sno.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sno.Location = new System.Drawing.Point(14, 11);
            this.Sno.Name = "Sno";
            this.Sno.Size = new System.Drawing.Size(66, 18);
            this.Sno.TabIndex = 2;
            this.Sno.Text = "学生ID";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(539, 83);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(166, 37);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出成绩";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSelectStudentID
            // 
            this.btnSelectStudentID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectStudentID.Location = new System.Drawing.Point(14, 83);
            this.btnSelectStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectStudentID.Name = "btnSelectStudentID";
            this.btnSelectStudentID.Size = new System.Drawing.Size(148, 37);
            this.btnSelectStudentID.TabIndex = 0;
            this.btnSelectStudentID.Text = "查询学生ID";
            this.btnSelectStudentID.UseVisualStyleBackColor = true;
            this.btnSelectStudentID.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvescore
            // 
            this.gvescore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvescore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvescore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvescore.Location = new System.Drawing.Point(0, 0);
            this.gvescore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvescore.Name = "gvescore";
            this.gvescore.RowHeadersWidth = 51;
            this.gvescore.RowTemplate.Height = 27;
            this.gvescore.Size = new System.Drawing.Size(900, 415);
            this.gvescore.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(740, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // teacher2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "teacher2";
            this.Text = "学生成绩导出";
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
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
    }
}