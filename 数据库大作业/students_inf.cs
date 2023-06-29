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
    public partial class students_inf : Form
    {
        public students_inf()
        {
            InitializeComponent();
            textBox1.Text = AppConfig.UserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strCon1 = @"server=test;database=score_managerment;Integrated security=true";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = strCon1;
            con1.Open();
            if (con1.State == ConnectionState.Open)
            {
                string strCmd1 = "select * from 学生表 where 学生ID='{0}'";
                strCmd1 = string.Format(strCmd1, AppConfig.UserName);
                SqlCommand command = new SqlCommand();
                command.Connection = con1;
                command.CommandText = strCmd1;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    textBox4.Text = dr[3].ToString();
                    textBox5.Text = dr[4].ToString();
                }
                else
                    MessageBox.Show("找不到信息", "提示");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void students_inf_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "当前用户:" + AppConfig.UserName;
        }
    }
}
