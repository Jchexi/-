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
using Microsoft.Office.Interop.Excel;


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
        /*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
        }*/

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件|*.xlsx|Word文件|*.docx";
            sfd.FilterIndex = 0;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //连接数据库，查询数据
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("select * from 成绩表", conn))
                    {
                        using (System.Data.DataTable dt = new System.Data.DataTable())
                        {
                            //将数据库中查到的数据填充到DataTable数据表
                            sda.Fill(dt);
                            //调用导出Excel的方法，传入DataTable数据表和路径
                            ExportExcel(dt, sfd.FileName);
                        }
                    }
                }
            }
        }
        void ExportExcel(System.Data.DataTable dt, string filepath)
        {
            //创建Excel应用程序类的一个实例，相当于从电脑开始菜单打开Excel
            ApplicationClass xlsxapp = new ApplicationClass();
            //新建一张Excel工作簿
            Workbook wbook = xlsxapp.Workbooks.Add(true);
            //第一个sheet页
            Worksheet wsheet = (Worksheet)wbook.Worksheets.get_Item(1);
            //将DataTable的列名显示在Excel表第一行
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                //注意Excel表的行和列的索引都是从1开始的
                wsheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }
            //遍历DataTable，给Excel赋值
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    //从第二行第一列开始写入数据
                    wsheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                }
            }
            //保存文件
            wbook.SaveAs(filepath);
            //释放资源
            xlsxapp.Quit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InitScore();
        }
    }
}
