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
    public partial class ModifyDataForm : Form
    {
        public ModifyDataForm()
        {
            InitializeComponent();
            DataMangerForm mf = new DataMangerForm();
            mf.AddToCmbForm("select Satellite from satelliteclass ", satellite_cmb);
           // mf.AddToCmbForm("select Orbit from satelliteclass ", orbit_cmb);
            people_txt.Text = DataMangerForm.username;
            people_txt.ReadOnly = true;
            data_txt.Text = DataMangerForm.data;
            staffnum_txt.Text = DataMangerForm.staffnumber.ToString();
            
            //datatime = 
        }
        //获取时间戳
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //获取时间戳
        public static long GetUnixTime(DateTime dateTime)
        {
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        //修改数据

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                
                long l1 = GetUnixTime(datatime.Value);
                DataMangerForm mainWindow = new DataMangerForm();
                //还没有上传卫星和轨道，无法修改
                mainWindow.UpdateSql("update transfer_info set ti_staffnumber='" + staffnum_txt.Text.Trim() + "',ti_username='" + people_txt.Text.Trim() + "',ti_uploadtime='" + l1 + "',ti_state='" + satellite_cmb.Text.Trim() /*+ "',orbit='" + orbit_cmb.Text.Trim() */+ "',ti_filename='" + data_txt.Text.Trim() + "' where ti_username ='" + DataMangerForm.username + "'");
                
                MessageBox.Show("修改成功", "提示");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败！", "修改提示");
            }
        }
    }
}
