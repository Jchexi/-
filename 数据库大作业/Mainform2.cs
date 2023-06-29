using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库大作业
{
    public partial class Mainform2 : Form
    {
        public Mainform2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Mainform2_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "当前用户:"+AppConfig.UserName;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new students_inf().Show();
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
