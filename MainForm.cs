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
            displayinfo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public MySqlConnection conn = null;
        private string sql = "";
        private void displayinfo()
        {
            
            //MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            //conn.Open();
            ////string sql = "select date_format(from_unixtime(ii_uploadtime),'%Y-%m-%d %H:%i:%s'),ii_username,ii_filename from image_info order by ii_id desc limit 1 ";
            //string sql1 = "select date_format(from_unixtime(application_time),'%Y-%m-%d %H:%i:%s'),satellitedata,people,opinion from application where opinion ='待审核' order by id desc limit 1";
            ////MySqlCommand comm = new MySqlCommand(sql, conn);
            //MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            ////MySqlDataReader sdr = comm.ExecuteReader();
            //MySqlDataReader sdr1 = comm1.ExecuteReader();
            ////sdr1.Read();
            //sdr1.SelectCommand = comm1;
            //DataTable dt = new DataTable();
            //sdr1.Fill(dt);
            //newmessage.DataSource = dt;
            //conn.Close();
            //conn.Dispose();

            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            sql = "select date_format(from_unixtime(application_time),'%Y-%m-%d %H:%i:%s') as '时间',satellitedata as '数据名称',people as '职员',opinion as '信息' from application where opinion ='待审核' order by id desc limit 1";
           
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(comm);
            sda.SelectCommand = comm;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            newmessage.DataSource = dt;
            conn.Close();
            //conn.Dispose();
            string sql1 = "select date_format(from_unixtime(ii_uploadtime),'%Y-%m-%d %H:%i:%s'),ii_username,ii_filename from image_info order by ii_id desc limit 1 ";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            MySqlDataAdapter sdr = new MySqlDataAdapter(comm1);
            sdr.SelectCommand = comm1;
            DataTable dl = new DataTable();
            sdr.Fill(dl);
            newmessage.DataSource = dl;
            conn.Close();
        }
        public static long GetUnixTime(DateTime dateTime)
        {
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        private void btn_REMOTE_Click(object sender, EventArgs e)
        {
            ListForm listForm = ListForm.GetListForm();
            listForm.Show();
            listForm.list_cb_statellite.Text = "S1A";
            string satellitedata = listForm.list_cb_statellite.Text;
            string modelname = listForm.list_cb_datatype.Text;
            long starttime = GetUnixTime(listForm.list_dtp_startdate.Value);
            string postdata = String.Format("satellitedata={0}&modelname={1}&starttime={2}", satellitedata, modelname, starttime);
            // 查询数据
            String url = LoginForm.serverURL+@"/searchData";
            string success = NetManager.HttpPost(url, postdata);
            JsonData datalist = JsonMapper.ToObject(success);
            foreach (JsonData data in datalist)
            {

                ImageInfoModel imageInfoModel = new ImageInfoModel();

                imageInfoModel.Ii_ID = data["ii_Id"].ToString();
                if (data["ii_Filename"] != null)
                    imageInfoModel.Ii_Filename = data["ii_Filename"].ToString();
                if (data["ii_SatelliteIdentification"] != null)
                    imageInfoModel.Ii_SatelliteIdentification = data["ii_SatelliteIdentification"].ToString();
                if (data["ii_ModelName"] != null)
                    imageInfoModel.Ii_Modelname = data["ii_ModelName"].ToString();
                if (data["ii_ProductName"] != null)
                    imageInfoModel.Ii_Productname = data["ii_ProductName"].ToString();
                if (data["ii_ProcessingLevel"] != null)
                    imageInfoModel.Ii_Productname = data["ii_ProcessingLevel"].ToString();
                if (data["ii_StartTime"] != null)
                    imageInfoModel.Ii_Starttime = data["ii_StartTime"].ToString();
                if (data["ii_EndTime"] != null)
                    imageInfoModel.Ii_Endtime = data["ii_EndTime"].ToString();
                if (data["ii_AbsoluteOrbit"] != null)
                    imageInfoModel.Ii_Absoluteorbit = data["ii_AbsoluteOrbit"].ToString();
                if (data["ii_MissionDataTakeIdentifier"] != null)
                    imageInfoModel.Ii_MissiondatatakeIdentifier = data["ii_MissionDataTakeIdentifier"].ToString();
                if (data["ii_ProductUniqueIdentificationCode"] != null)
                    imageInfoModel.Ii_ProductuniqueIdentificationcode = data["ii_ProductUniqueIdentificationCode"].ToString();
                if (data["ii_Path"] != null)
                    imageInfoModel.Ii_Path = data["ii_Path"].ToString();
                if (data["ii_Filesize"] != null)
                    imageInfoModel.Ii_Filesize = data["ii_Filesize"].ToString();
                if (data["ii_Staffnumber"] != null)
                    imageInfoModel.Ii_Staffnumber = data["ii_Staffnumber"].ToString();
                if (data["ii_Uploadtime"] != null)
                    imageInfoModel.Ii_Uploadtime = data["ii_Uploadtime"].ToString();
                if (data["ii_Log"] != null)
                    imageInfoModel.Ii_Log = data["ii_Log"].ToString();
                if (data["ii_Lat"] != null)
                    imageInfoModel.Ii_Lat = data["ii_Lat"].ToString();
                listForm.list_flp_downloadlist.Controls.Add(new ListResultPanel(imageInfoModel, listForm));
            }
        }

        private void btn_LANDSAT_Click(object sender, EventArgs e)
        {
            ListForm listForm = ListForm.GetListForm();
            listForm.list_cb_statellite.Text = "S1B";
            listForm.Show();
           
        }
    }
}
