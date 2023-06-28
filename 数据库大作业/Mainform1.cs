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
    public partial class Mainform1 : Form
    {
        public Mainform1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new teacher1().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
