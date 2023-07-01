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
    public partial class 成绩查询 : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public 成绩查询()
        {
            InitializeComponent();
            txtSno.Text = AppConfig.UserName;
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
        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 成绩表 where 学生ID={0}";
                strCmd = string.Format(strCmd, AppConfig.UserName);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void txtSno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
