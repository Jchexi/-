using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 数据库大作业
{
    public partial class teacher1 : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public teacher1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 成绩表 where 学生ID={0}";
                strCmd = string.Format(strCmd, txtSno.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "insert 成绩表 values({0},'{1}',{2},'{3}','{4}','{5}','{6}')";
                    strCmd = string.Format(strCmd, txtSno.Text, txtSname.Text, txtCno.Text, txtCname.Text, txtMark.Text, txtGradedrop.Text, txtcredit.Text);
                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitScore();
                }
            }
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

        private void teacher1_Load(object sender, EventArgs e)
        {
            InitScore();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
               
                string 学生ID = gvescore.CurrentRow.Cells["学生ID"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "delete from 成绩表 where 学生ID={0}";
                    strCmd = string.Format(strCmd, 学生ID);

                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitScore();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 学生ID = gvescore.CurrentRow.Cells["学生ID"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "update 成绩表 set 学生ID={0},学生姓名='{1}',课程ID={2},课程名称='{3}',成绩='{4}',绩点='{5}',学分='{6}' where 学生ID={7} and 课程ID={8}";
                    strCmd = string.Format(strCmd, txtSno.Text, txtSname.Text, txtCno.Text, txtCname.Text, txtMark.Text, txtGradedrop.Text, txtcredit.Text, 学生ID, txtCno.Text);
                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitScore();
                }

            }
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 学生ID = gvescore.CurrentRow.Cells["学生ID"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "select * from 成绩表 where 成绩<60 order by 学生ID ";
                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    gvescore.DataSource = ds.Tables[0].DefaultView;
                    // InitScore();
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitScore();
        }

        private void txtCname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
