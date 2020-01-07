using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
            MyupData(sql);
        }
        public MySqlConnection conn = null;
        private string sql = "";
        private void MyupData(string s1)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            if (LoginForm.power == 1)
            {
                sql = "select staff_number as '职员编号',date_format(FROM_UNIXTIME(phototime),'%Y-%m-%d %H:%i') as '上传时间',people as '上传职员',satellite as '卫星类型',orbit as '卫星轨道',satellitedata as '上传数据' from stroage ";
            }
            else if (LoginForm.power == 2)
            {
                sql = "select staff_number as '职员编号',date_format(FROM_UNIXTIME(phototime),'%Y-%m-%d %H:%i') as '上传时间',people as '上传职员',satellite as '卫星类型',orbit as '卫星轨道',satellitedata as '上传数据' from stroage  where staff_number =" + LoginForm.staff_Number;
            }
            MySqlDataAdapter sdr = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sdr.Fill(ds);
            dataDGV.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            UpDataForm upfrom = new UpDataForm();
            upfrom.Show();
        }

        private void my_data_Click(object sender, EventArgs e)
        {
            if (LoginForm.power == 1)
            {

                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select staff_number as '职员编号',date_format(FROM_UNIXTIME(phototime),'%Y-%m-%d %H:%i') as '上传时间',people as '上传职员',satellite as '卫星类型',orbit as '卫星轨道',satellitedata as '上传数据' from stroage ";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataDGV.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            else if (LoginForm.power == 2)
            {

                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                sql = "select staff_number as '职员编号',date_format(FROM_UNIXTIME(phototime),'%Y-%m-%d %H:%i') as '上传时间',people as '上传职员',satellite as '卫星类型',orbit as '卫星轨道',satellitedata as '上传数据' from stroage  where staff_number =" + LoginForm.staff_Number;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                //comm.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(comm);
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataDGV.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
