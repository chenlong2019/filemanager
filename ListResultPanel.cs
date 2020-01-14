using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FileUpload;

namespace FileManager
{
    /// <summary>
    ///  <c>ListResultPanel</c>
    ///  查询结果展示
    /// </summary>
    public partial class ListResultPanel : UserControl
    {
        private readonly ListForm listForm;
        private readonly ImageInfoModel imageInfoModel;
       
        private String GetDateTime(long unixTimeStamp)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            DateTime dt = startTime.AddSeconds(unixTimeStamp);
           return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public ListResultPanel(ImageInfoModel imageInfoModel, ListForm listForm)
        {
            InitializeComponent();
            this.imageInfoModel = imageInfoModel;
            this.listForm = listForm;
            this.lrp_label_filename.Text = imageInfoModel.Ii_Filename;
            this.lrp_label_coordinate.Text = imageInfoModel.Ii_Lat +","+ imageInfoModel.Ii_Log;
            try
            {
                this.lrp_label_starttime.Text = GetDateTime(long.Parse(imageInfoModel.Ii_Starttime));
            }
            catch
            {
                Console.WriteLine("开始日期转换错误!");
            }
            try
            {
                this.lrp_label_endtime.Text = GetDateTime(long.Parse(imageInfoModel.Ii_Endtime));
            }
            catch
            {
                Console.WriteLine("结束日期转换错误!");
            }
            
            //this.lrp_label_starttime.Text=imageInfoModel.
        }

        public bool DataRepeat(string s)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            MySqlCommand comm = new MySqlCommand(s, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            bool ifRepetion = reader.Read();
            if (ifRepetion)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public ImageInfoModel GetImageInfoModel()
        {
            return imageInfoModel;
        }
        public static long GetUnixTime(DateTime dateTime)
        {
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        private void download_Click(object sender, EventArgs e)
        {

            
            if (LoginForm.power == 1)
            {
                long nowtime = GetUnixTime(DateTime.Now.ToLocalTime());
                listForm.downloadFiles(this.imageInfoModel);
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                string sql = "insert into download_log (staff_number,people,download_time,satellitedata) values('" + LoginForm.staff_Number + "','" + LoginForm.Namer + "','" + nowtime + "','" + lrp_label_filename.Text.Trim()+"')";
                Console.WriteLine(sql);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else if (LoginForm.power == 2 && DataRepeat("select *from application where satellitedata='"+ lrp_label_filename.Text.ToString()+"' and opinion = '同意'"))
            {
                long nowtime = GetUnixTime(DateTime.Now.ToLocalTime());
                listForm.downloadFiles(this.imageInfoModel);
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                string sql = "insert into download_log (staff_number,people,download_time,satellitedata) values('" + LoginForm.staff_Number + "','" + LoginForm.Namer + "','" + nowtime + "','" + lrp_label_filename.Text.Trim() + "')";
                Console.WriteLine(sql);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else if(LoginForm.power == 2 && DataRepeat(" select *from application where satellitedata='" + lrp_label_filename.Text.ToString() + "' and opinion='待审核'"))
            {
                MessageBox.Show("您的下载申请正在审核，请耐心等待审核通过后下载");
            }
            else
            {
                long nowtime = GetUnixTime(DateTime.Now.ToLocalTime());
                MessageBox.Show("您没有权限下载数据，下载此数据需要提交申请，已提交下载申请，审核通过后，在进行下载！");
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                string sql = "insert into application (staff_number,application_time,satellitedata,opinion,people) values('" + LoginForm.staff_Number + "','" + nowtime + "','" + lrp_label_filename.Text.Trim() + "','" + "待审核" + "','"+LoginForm.Namer +"')";
                Console.WriteLine(sql);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataInfoForm dataInfoForm = new DataInfoForm(imageInfoModel,this.listForm);
            dataInfoForm.Show();
        }
    }
}
