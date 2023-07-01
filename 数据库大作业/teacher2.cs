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

        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select *  from 成绩表 where 学生ID IN (select 学生ID from 学生表 where 班级='{0}')";
                strCmd = string.Format(strCmd, txtClass.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnSelectGrade_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select *  from 成绩表 where 学生ID IN (select 学生ID from 学生表 where 年级='{0}')";
                strCmd = string.Format(strCmd, txtGrade.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvescore.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            string[] str = gvescore.Text.Split('\n');
            int i = 0;
            foreach (string s in str)
            {
                g.DrawString(str[i], fontDialog1.Font, new SolidBrush(gvescore.ForeColor),
                    new PointF(100, 80 + gvescore.Font.Height * i));
                i++;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument1.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "打印出错");
                    }
                }
            
        }
    }
}
