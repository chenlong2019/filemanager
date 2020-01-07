using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FileManager
{
    public partial class MyDataForm : Form
    {
        public MyDataForm()
        {
            InitializeComponent();
            if(LoginForm.power == 2)
            {
                btn_Agree.Visible = false;
                btn_refuse.Visible = false;
                
            }
            UserOpinion(sql);
        }
        
        private int rowIndex;
        //public static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public MySqlConnection conn = null;
        private string sql = "";

        private void btn_mydown_Click(object sender, EventArgs e)
        {

           if(LoginForm.power == 1)
            {
                
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',staff_number as '职员编号',people as '下载人员',satellitedata as '下载数据',download_time as '下载时间'  from download_log ";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            } else if (LoginForm.power == 2)
            {
                
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',staff_number as '职员编号',people as '下载人员',satellitedata as '下载数据',download_time as '下载时间'  from download_log where staff_number=" + LoginForm.staff_Number;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
        }

        private void btn_application_Click(object sender, EventArgs e)
        {
            if (LoginForm.power == 1)
            {
               
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application  where opinion='待审核'";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }else if(LoginForm.power == 2)
            {
                
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application where opinion='待审核' && staff_number=" + LoginForm.staff_Number;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
           
        }
        //已审核过的申请
        private void btn_audited_Click(object sender, EventArgs e)
        {
            if(LoginForm.power == 1)
            {
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application  where opinion='同意'|| opinion='拒绝'";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            else if(LoginForm.power == 2)
            {
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application  where opinion='同意'|| opinion='拒绝' && staff_number=" + LoginForm.staff_Number;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            
        }
        //打开界面显示不同用户的待审核文件
        private void UserOpinion(string s1)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            if (LoginForm.power == 1)
            {
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application  where opinion = '待审核'";
            }
            else if (LoginForm.power == 2)
            {
                sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application  where opinion = '待审核' && staff_number =" + LoginForm.staff_Number;
            }
            MySqlDataAdapter sdr = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            
        }
        private void AddOpinion(string s)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable data = (DataTable)dataGridView1.DataSource;
                DataRow row = data.Rows[rowIndex];
                int xh = Convert.ToInt32(row[0]);
                string s = "update application set opinion='同意' where id ="+xh;
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                MySqlCommand comm = new MySqlCommand(s, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("没有要审核的内容！", "提示");
            }
            AddOpinion("select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application where Opinion='待审核'");
            
        }


        private void btn_refuse_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable data = (DataTable)dataGridView1.DataSource;
                DataRow row = data.Rows[rowIndex];
                int xh = Convert.ToInt32(row[0]);
                string s = "update application set opinion='拒绝'where id =" + xh;
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                MySqlCommand comm = new MySqlCommand(s, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("没有要审核的内容！", "提示");
            }
            AddOpinion("select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application where Opinion='待审核'");
            
        }
    }
}
