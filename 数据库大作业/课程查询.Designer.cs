namespace 数据库大作业
{
    partial class 课程查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(课程查询));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gveCoures = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butselect = new System.Windows.Forms.Button();
            this.cobterm = new System.Windows.Forms.ComboBox();
            this.cobmajor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gveCoures)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cobmajor);
            this.splitContainer1.Panel1.Controls.Add(this.cobterm);
            this.splitContainer1.Panel1.Controls.Add(this.butselect);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gveCoures);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // gveCoures
            // 
            this.gveCoures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gveCoures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gveCoures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gveCoures.Location = new System.Drawing.Point(0, 0);
            this.gveCoures.Name = "gveCoures";
            this.gveCoures.RowHeadersWidth = 51;
            this.gveCoures.RowTemplate.Height = 27;
            this.gveCoures.Size = new System.Drawing.Size(800, 255);
            this.gveCoures.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(263, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "专业";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // butselect
            // 
            this.butselect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butselect.Location = new System.Drawing.Point(354, 152);
            this.butselect.Name = "butselect";
            this.butselect.Size = new System.Drawing.Size(83, 36);
            this.butselect.TabIndex = 4;
            this.butselect.Text = "查询";
            this.butselect.UseVisualStyleBackColor = true;
            this.butselect.Click += new System.EventHandler(this.butselect_Click);
            // 
            // cobterm
            // 
            this.cobterm.FormattingEnabled = true;
            this.cobterm.Location = new System.Drawing.Point(326, 25);
            this.cobterm.Name = "cobterm";
            this.cobterm.Size = new System.Drawing.Size(136, 23);
            this.cobterm.TabIndex = 5;
            // 
            // cobmajor
            // 
            this.cobmajor.FormattingEnabled = true;
            this.cobmajor.Location = new System.Drawing.Point(326, 93);
            this.cobmajor.Name = "cobmajor";
            this.cobmajor.Size = new System.Drawing.Size(136, 23);
            this.cobmajor.TabIndex = 6;
            // 
            // 课程查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "课程查询";
            this.Text = "课程查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.课程查询_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gveCoures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gveCoures;
        private System.Windows.Forms.Button butselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobmajor;
        private System.Windows.Forms.ComboBox cobterm;
    }
}