namespace 数据库大作业
{
    partial class teacher3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher3));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSnomber = new System.Windows.Forms.TextBox();
            this.butNpass = new System.Windows.Forms.Button();
            this.butpasss = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butselsct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gveaprize = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gveaprize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.txtSname);
            this.splitContainer2.Panel1.Controls.Add(this.txtSnomber);
            this.splitContainer2.Panel1.Controls.Add(this.butNpass);
            this.splitContainer2.Panel1.Controls.Add(this.butpasss);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.butselsct);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gveaprize);
            this.splitContainer2.Size = new System.Drawing.Size(818, 479);
            this.splitContainer2.SplitterDistance = 138;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(423, 22);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(130, 25);
            this.txtSname.TabIndex = 6;
            // 
            // txtSnomber
            // 
            this.txtSnomber.Location = new System.Drawing.Point(159, 22);
            this.txtSnomber.Name = "txtSnomber";
            this.txtSnomber.Size = new System.Drawing.Size(131, 25);
            this.txtSnomber.TabIndex = 5;
            // 
            // butNpass
            // 
            this.butNpass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butNpass.Location = new System.Drawing.Point(589, 104);
            this.butNpass.Name = "butNpass";
            this.butNpass.Size = new System.Drawing.Size(81, 31);
            this.butNpass.TabIndex = 4;
            this.butNpass.Text = "不通过";
            this.butNpass.UseVisualStyleBackColor = true;
            this.butNpass.Click += new System.EventHandler(this.butNpass_Click);
            // 
            // butpasss
            // 
            this.butpasss.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butpasss.Location = new System.Drawing.Point(393, 104);
            this.butpasss.Name = "butpasss";
            this.butpasss.Size = new System.Drawing.Size(90, 31);
            this.butpasss.TabIndex = 3;
            this.butpasss.Text = "通过";
            this.butpasss.UseVisualStyleBackColor = true;
            this.butpasss.Click += new System.EventHandler(this.butpasss_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(346, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学生姓名";
            // 
            // butselsct
            // 
            this.butselsct.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butselsct.Location = new System.Drawing.Point(215, 104);
            this.butselsct.Name = "butselsct";
            this.butselsct.Size = new System.Drawing.Size(90, 31);
            this.butselsct.TabIndex = 1;
            this.butselsct.Text = "查询";
            this.butselsct.UseVisualStyleBackColor = true;
            this.butselsct.Click += new System.EventHandler(this.butselsct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生ID";
            // 
            // gveaprize
            // 
            this.gveaprize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gveaprize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gveaprize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gveaprize.Location = new System.Drawing.Point(0, 0);
            this.gveaprize.Name = "gveaprize";
            this.gveaprize.RowHeadersWidth = 51;
            this.gveaprize.RowTemplate.Height = 27;
            this.gveaprize.Size = new System.Drawing.Size(818, 337);
            this.gveaprize.TabIndex = 0;
            // 
            // teacher3
            // 
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teacher3";
            this.Text = "奖项审核";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teacher3_Load_1);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gveaprize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button butnpaass;
        private System.Windows.Forms.Button butpass;
        private System.Windows.Forms.Button butselect;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gveprize;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSnomber;
        private System.Windows.Forms.Button butNpass;
        private System.Windows.Forms.Button butpasss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butselsct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gveaprize;
    }
}