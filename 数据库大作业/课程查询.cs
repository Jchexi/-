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
    public partial class 课程查询 : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public 课程查询()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public void Initcheack()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select distinct 课程表.课程ID,课程表.课程名称,课程表.任课老师,课程表.学期 from 课程表,学生表,学生选课表 ";
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gveCoures.DataSource = ds.Tables[0].DefaultView;
            }
        }
        
        public void Initselect()
        {
            cobterm.Items.Add("大一上");
            cobterm.Items.Add("大一下");
            cobterm.Items.Add("大二上");
            cobterm.Items.Add("大二下");
            cobterm.Items.Add("大三上");
            cobterm.Items.Add("大三下");
            cobterm.Items.Add("大四上");
            cobterm.Items.Add("大四下");
            cobmajor.Items.Add("医学信息工程");
            cobmajor.Items.Add("生物医学工程");
        }

        private void butselect_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select distinct 课程表.课程ID,课程表.课程名称,课程表.任课老师,课程表.学期 from 课程表,学生表,学生选课表 where 课程表.课程ID=学生选课表.课程ID AND 学生表.学生ID=学生选课表.学生ID AND  学期='{0}' AND 专业='{1}'";
                strCmd = string.Format(strCmd,cobterm.Text,cobmajor.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gveCoures.DataSource = ds.Tables[0].DefaultView;
            }
       
        }

        private void 课程查询_Load(object sender, EventArgs e)
        {
            Initselect();
            Initcheack();
        }
    }
}
