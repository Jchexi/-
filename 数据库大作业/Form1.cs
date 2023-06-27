using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 数据库大作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCon = @"server=test;database=stum2;Integrated security=true";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            if(con.State==ConnectionState.Open)
            {
                string strCmd = "select * from teusers where teusername='{0}' and tepwd='{1}'";
                strCmd = string.Format(strCmd, txtusername.Text.Trim(), txtpwd.Text.Trim());
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = strCmd;
                SqlDataReader dr=command.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    //隐藏登录窗口
                    this.Hide();
                    //把主窗口显示出来
                    new Mainform1().Show();
                }
                else
                {
                    MessageBox.Show("用户名或者密码不正确");
                }
            }
            else
            {
                MessageBox.Show("用户名或者密码不正确");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCon1 = @"server=test;database=stum1;Integrated security=true";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = strCon1;
            con1.Open();
            if (con1.State == ConnectionState.Open)
            {
                string strCmd1 = "select * from stusers where username='{0}' and pwd='{1}'";
                strCmd1 = string.Format(strCmd1, txtusername.Text.Trim(), txtpwd.Text.Trim());
                SqlCommand command = new SqlCommand();
                command.Connection = con1;
                command.CommandText = strCmd1;
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //隐藏登录窗口
                    this.Hide();
                    //把主窗口显示出来
                    new Mainform2().Show();
                }
                else
                {
                    MessageBox.Show("用户名或者密码不正确");
                }
            }
            else
            {
                MessageBox.Show("用户名或者密码不正确");
            }
        }
    }
}
