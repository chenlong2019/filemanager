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
            mf.AddToCmbForm("select Orbit from satelliteclass ", orbit_cmb);
            people_txt.Text = DataMangerForm.people;
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
        {//获取时间戳
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        //修改数据

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                
                long l1 = GetUnixTime(datatime.Value);
                DataMangerForm mainWindow = new DataMangerForm();
                mainWindow.UpdateSql("update stroage set staff_number='" + staffnum_txt.Text.Trim() + "',people='" + people_txt.Text.Trim() + "',phototime='" + l1 + "',satellite='" + satellite_cmb.Text.Trim() + "',orbit='" + orbit_cmb.Text.Trim() + "',satellitedata='" + data_txt.Text.Trim() + "' where people ='" + DataMangerForm.people + "'");
                
                MessageBox.Show("修改成功", "提示");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败！", "修改提示");
            }
        }
    }
}
