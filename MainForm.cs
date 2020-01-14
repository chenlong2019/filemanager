using FileUpload;
using LitJson;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void displayinfo()
        {
            //MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            //conn.Open();
            //string sql = "select date_format(from_unixtime(ti_uploadtime),'%Y-%m-%d %H:%i:%s'),ti_username,ti_filename from transfer_info order by ti_id desc limit 1 ";
            //string sql1 = "select date_format(from_unixtime(application_time),'%Y-%m-%d %H:%i:%s'),satellitedata,people,opinion from application where opinion ='待审核' order by id desc limit 1";
            //MySqlCommand comm = new MySqlCommand(sql, conn);
            //MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            //comm.ExecuteNonQuery();
            //comm1.ExecuteNonQuery();
            //conn.Close();

        }

    }
}
