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
        }
        //public static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public MySqlConnection conn = null;
        private string sql = "";
        private void btn_mydown_Click(object sender, EventArgs e)
        {

            
            conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            sql = "select id as '序号',staff_number as '职员编号',people as '下载人员',satellitedata as '下载数据',download_time as '下载时间'  from download_log where staff_number="+LoginForm.staff_Number;
            MySqlCommand comm = new MySqlCommand(sql,conn);
            //comm.ExecuteNonQuery();
            MySqlDataAdapter sda = new MySqlDataAdapter(comm);
            sda.SelectCommand = comm;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            conn.Dispose();

        }

        private void btn_application_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            sql = "select id as '序号',satellitedata as '申请数据',application_time as '申请时间',staff_number as '职员编号',people as '申请人员',opinion as '审核状态' from application";
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
}
