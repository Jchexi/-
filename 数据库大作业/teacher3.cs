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
    public partial class teacher3 : Form
    {
        string strCon = @"data source=test;initial catalog=score_managerment;integrated security=true";
        public teacher3()
        {
            InitializeComponent();
        }

        /*private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }*/
        public void InitPrize()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 评优评先表";
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gveaprize.DataSource = ds.Tables[0].DefaultView;
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 评优评先表 where 学生ID={0}";
                strCmd = string.Format(strCmd, txtSno.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gveprize.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void butpass_Click(object sender, EventArgs e)
        {

        }

        private void butnpaass_Click(object sender, EventArgs e)
        {

        }

        private void teacher3_Load(object sender, EventArgs e)
        {
            InitPrize();
        }*/

        private void teacher3_Load_1(object sender, EventArgs e)
        {
            InitPrize();
        }

        private void butselsct_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from 评优评先表 where 学生ID = {0}";
                strCmd = string.Format(strCmd, txtSnomber.Text);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gveaprize.DataSource = ds.Tables[0].DefaultView;
            }
        }


        private void butpasss_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 学生ID = gveaprize.CurrentRow.Cells["学生ID"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "update 评优评先表 set 审核是否通过='{0}' ";
                    strCmd = string.Format(strCmd, butpasss.Text, 学生ID);

                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitPrize();
                }
            }
        }

        private void butNpass_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string 学生ID = gveaprize.CurrentRow.Cells["学生ID"].Value.ToString();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string strCmd = "update 评优评先表 set 审核是否通过='{0}' ";
                    strCmd = string.Format(strCmd, butNpass.Text, 学生ID);

                    SqlCommand command = new SqlCommand(strCmd, con);
                    command.ExecuteNonQuery();
                    InitPrize();
                }
            }
        }
    }
}
