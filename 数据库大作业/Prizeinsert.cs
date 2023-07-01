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
    public partial class 学生评优评先表信息录入 : Form
    {
        
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public 学生评优评先表信息录入()
        {
            InitializeComponent();
            txtSno.Text = AppConfig.UserName;
            //txttime.Text = "输入格式为：年-月-日";
        }
        public void InitPrizeinsert()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 评优评先表 where 学生ID={0}";
                strCmd = string.Format(strCmd, AppConfig.UserName);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvePrizeinsert.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void butplease_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "insert into 评优评先表(学生ID,奖项名称,奖项等级,活动名称,获奖时间,应得学分,学生姓名) values({0},'{1}','{2}','{3}','{4}','{5}','{6}')";
                    strCmd = string.Format(strCmd, txtSno.Text, txtPna.Text, txtlevel.Text, txtActna.Text, txttime.Text, txtCredit.Text,txtSname.Text);
                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitPrizeinsert();
                }
            }
        }

        private void 学生评优评先表信息录入_Load(object sender, EventArgs e)
        {
            
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 学生ID = gvePrizeinsert.CurrentRow.Cells["学生ID"].Value.ToString();
                string 奖项名称 = gvePrizeinsert.CurrentRow.Cells["奖项名称"].Value.ToString();              
                string 奖项等级 = gvePrizeinsert.CurrentRow.Cells["奖项等级"].Value.ToString();
                string 活动名称 = gvePrizeinsert.CurrentRow.Cells["活动名称"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "update 评优评先表 set 学生ID={0},奖项名称='{1}',奖项等级='{2}',活动名称='{3}',获奖时间='{4}',应得学分='{5}',学生姓名='{6}'" +
                        "where 学生ID={7} and 奖项名称='{8}' and 奖项等级='{9}' and 活动名称='{10}'";
                    strCmd = string.Format(strCmd, txtSno.Text, txtPna.Text, txtlevel.Text, txtActna.Text, txttime.Text, txtCredit.Text,txtSname.Text, 
                        学生ID, 奖项名称, 奖项等级, 活动名称);

                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitPrizeinsert();
                }
            }
        }

        private void butselect_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 评优评先表 where 学生ID={0}";
                strCmd = string.Format(strCmd, AppConfig.UserName);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvePrizeinsert.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 奖项名称 = gvePrizeinsert.CurrentRow.Cells["奖项名称"].Value.ToString();
                string 学生ID =gvePrizeinsert.CurrentRow.Cells["学生ID"].Value.ToString();
                string 奖项等级 = gvePrizeinsert.CurrentRow.Cells["奖项等级"].Value.ToString();
                string 活动名称 = gvePrizeinsert.CurrentRow.Cells["活动名称"].Value.ToString();
                
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "delete from 评优评先表 where 学生ID={0} and 奖项名称='{1}' and 奖项等级='{2}' and 活动名称='{3}'";
                    strCmd = string.Format(strCmd, 学生ID,奖项名称,奖项等级,活动名称);

                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitPrizeinsert();
                }
            }
        }

        private void gvePrizeinsert_CurrentCellChanged(object sender, EventArgs e)
        {
          /*  if (gvePrizeinsert.CurrentCell == null)
            {
                return;
            }
            else
            {
                txtSno.Text= gvePrizeinsert.CurrentRow.Cells["学生ID"].Value.ToString();
                txtPna.Text= gvePrizeinsert.CurrentRow.Cells["奖项名称"].Value.ToString();
                txtlevel.Text= gvePrizeinsert.CurrentRow.Cells["奖项等级"].Value.ToString();
                txtActna.Text= gvePrizeinsert.CurrentRow.Cells["活动名称"].Value.ToString();
                txttime.Text= gvePrizeinsert.CurrentRow.Cells["获奖时间"].Value.ToString();
                txtCredit.Text= gvePrizeinsert.CurrentRow.Cells["应得学分"].Value.ToString();
                txtSname.Text= gvePrizeinsert.CurrentRow.Cells["学生姓名"].Value.ToString();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitPrizeinsert();
        }

        private void txttime_Click(object sender, EventArgs e)
        {
            //txttime.Text = null;
        }

        private void txttime_MouseLeave(object sender, EventArgs e)
        {
            //txttime.Text = "输入格式为：年-月-日";
        }

        private void txttime_CursorChanged(object sender, EventArgs e)
        {
            //txttime.Text = "输入格式为：年-月-日";
        }

        private void txttime_MouseEnter(object sender, EventArgs e)
        {
            //txttime.Text = null;
        }
    }
}
