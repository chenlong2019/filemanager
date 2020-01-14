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
    public partial class DataInfoForm : Form
    {
        private ImageInfoModel imageInfoModel;
        private ListForm listForm;
        public DataInfoForm(ImageInfoModel imageInfoModel,ListForm listForm)
        {
            InitializeComponent();
            this.imageInfoModel = imageInfoModel;
            this.listForm = listForm;
            imageinfodisplay();
        }
        public static long GetUnixTime(DateTime dateTime)
        {
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        public void imageinfodisplay()
        {
            try
            {
                ii_filename.Text = imageInfoModel.Ii_Filename;
                ii_satelliteIdentification.Text = imageInfoModel.Ii_SatelliteIdentification;
                ii_modelname.Text = imageInfoModel.Ii_Modelname;
                ii_productname.Text = imageInfoModel.Ii_Productname;
                ii_processinglevel.Text = imageInfoModel.Ii_Processinglevel;
                DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
                ii_starttime.Text = startTime.AddSeconds(Convert.ToDouble(imageInfoModel.Ii_Starttime)) + "";
                //ii_starttime.Text = imageInfoModel.Ii_Starttime;
                ii_endtime.Text = startTime.AddSeconds(Convert.ToDouble(imageInfoModel.Ii_Endtime)) + ""; 
                ii_missiondatatakeIdentifier.Text = imageInfoModel.Ii_MissiondatatakeIdentifier;
                ii_productuniqueIdentificationcode.Text = imageInfoModel.Ii_ProductuniqueIdentificationcode;
                if(imageInfoModel.Ii_Uploadtime != null)
                ii_uploadtime.Text = startTime.AddSeconds(Convert.ToDouble(imageInfoModel.Ii_Uploadtime)) + "";
                ii_filesize.Text = imageInfoModel.Ii_Filesize;
                ii_absoluteorbit.Text = imageInfoModel.Ii_Absoluteorbit;
                ii_log.Text = imageInfoModel.Ii_Log;
                ii_lat.Text = imageInfoModel.Ii_Lat;
            }
            catch(Exception ex)
            {
                MessageBox.Show("没有详细信息");
            }
            
        }
        /// <summary>
        /// 展示地图
        /// </summary>
        private void Dim_btn_showMap_Click(object sender, EventArgs e)
        {
            string lng = imageInfoModel.Ii_Log+"";
            string lat = imageInfoModel.Ii_Lat+"";
            if(!lng.Equals("")&& !lat.Equals(""))
            {
                Console.WriteLine(lng);
                Console.WriteLine(lat);
            }
            listForm.ShowMap(lng,lat);
        }

        /// <summary>
        /// 申请下载
        /// </summary>
        private void Dim_btn_applyDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
