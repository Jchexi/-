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
    public partial class teacher2 : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public teacher2()
        {
            InitializeComponent();
        }

        private void teacher2_Load(object sender, EventArgs e)
        {
            InitScore();
        }
        public void InitScore()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 成绩表";
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 成绩表 where 学生ID='{0}'";
                strCmd = string.Format(strCmd, txtSno.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
