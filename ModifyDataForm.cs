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
        }
       
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //修改数据
        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                DataMangerForm mainWindow = new DataMangerForm();
                Console.WriteLine("update stroage set staff_number='" + staffnum_txt.Text.Trim() + "',people='" + people_txt.Text.Trim() + "',phototime=" + datatime.Text.Trim() + ",satellite='" + satellite_cmb.Text.Trim() + "',orbit='" + orbit_cmb.Text.Trim() + "',satellitedata='" + data_txt.Text.Trim() + "' where people ='" + DataMangerForm.people + "'");
                mainWindow.UpdateSql("update stroage set staff_number='" + staffnum_txt.Text.Trim() + "',people='" + people_txt.Text.Trim() + "',phototime=" + datatime.Text.Trim() + ",satellite='" + satellite_cmb.Text.Trim() + "',orbit='" + orbit_cmb.Text.Trim() + "',satellitedata='" + data_txt.Text.Trim() + "' where people ='" + DataMangerForm.people + "'");
                
                MessageBox.Show("修改成功", "提示");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败！", "修改提示");
            }
        }
    }
}
