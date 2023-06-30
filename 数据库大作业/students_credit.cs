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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 数据库大作业
{
    public partial class students_credit : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public students_credit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void students_credit_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前用户:" + AppConfig.UserName;
            txtUserName.Text = AppConfig.UserName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 成绩表 where 学生ID={0} order by 课程ID";
                strCmd = string.Format(strCmd, AppConfig.UserName);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                float credit = 0;
                if (con.State == ConnectionState.Open)
                {
                    string strCmd1 = "select * from 成绩表 where 学生ID='{0}'";
                    strCmd1 = string.Format(strCmd1, txtUserName.Text);
                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandText = strCmd1;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        credit += (float)Convert.ToSingle(dr[6]);                   
                    }
                    textBox2.Text = credit.ToString();
                }
                else
                    MessageBox.Show("找不到成绩单", "提示");
                
            }
        }
    }
}
