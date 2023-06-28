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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gveprize = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.butselect = new System.Windows.Forms.Button();
            this.butpass = new System.Windows.Forms.Button();
            this.butnpaass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gveprize)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.butnpaass);
            this.splitContainer1.Panel1.Controls.Add(this.butpass);
            this.splitContainer1.Panel1.Controls.Add(this.butselect);
            this.splitContainer1.Panel1.Controls.Add(this.txtSno);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gveprize);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 0;
            // 
            // gveprize
            // 
            this.gveprize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gveprize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gveprize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gveprize.Location = new System.Drawing.Point(0, 0);
            this.gveprize.Name = "gveprize";
            this.gveprize.RowHeadersWidth = 51;
            this.gveprize.RowTemplate.Height = 27;
            this.gveprize.Size = new System.Drawing.Size(800, 331);
            this.gveprize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(242, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生ID";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(305, 18);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(128, 25);
            this.txtSno.TabIndex = 1;
            // 
            // butselect
            // 
            this.butselect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butselect.Location = new System.Drawing.Point(108, 81);
            this.butselect.Name = "butselect";
            this.butselect.Size = new System.Drawing.Size(128, 32);
            this.butselect.TabIndex = 4;
            this.butselect.Text = "查询";
            this.butselect.UseVisualStyleBackColor = true;
            this.butselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // butpass
            // 
            this.butpass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butpass.Location = new System.Drawing.Point(322, 81);
            this.butpass.Name = "butpass";
            this.butpass.Size = new System.Drawing.Size(98, 32);
            this.butpass.TabIndex = 5;
            this.butpass.Text = "通过";
            this.butpass.UseVisualStyleBackColor = true;
            this.butpass.Click += new System.EventHandler(this.butpass_Click);
            // 
            // butnpaass
            // 
            this.butnpaass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butnpaass.Location = new System.Drawing.Point(524, 81);
            this.butnpaass.Name = "butnpaass";
            this.butnpaass.Size = new System.Drawing.Size(106, 32);
            this.butnpaass.TabIndex = 6;
            this.butnpaass.Text = "不通过";
            this.butnpaass.UseVisualStyleBackColor = true;
            this.butnpaass.Click += new System.EventHandler(this.butnpaass_Click);
            // 
            // teacher3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teacher3";
            this.Text = "奖项审核";
            this.Load += new System.EventHandler(this.teacher3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gveprize)).EndInit();
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
    }
}