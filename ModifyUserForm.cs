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
    public partial class ModifyUserForm : Form
    {
        public ModifyUserForm()
        {
            InitializeComponent();
            power_cmd.Items.Add("管理员");
            power_cmd.Items.Add("普通职员");
            username_txtbox.Text = UserManagementForm.username;
            username_txtbox.ReadOnly = true;
            pwd_txtbox.Text = UserManagementForm.pwd;
            power_cmd.Text = UserManagementForm.power.ToString();
            staffnumb_txtbox.Text = UserManagementForm.staffnumber.ToString();
        }
        public void UpdateSql(string s)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            MySqlCommand comm = new MySqlCommand(s, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        //将数据库内容添加到combox中
        public void AddToCmbForm(string s, ComboBox cmb)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            sdr.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow myDR = dt.Rows[i];
                cmb.Items.Add(myDR[0].ToString());
            }
            conn.Close();
        }
        //修改用户信息
        private void btn_modify_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModifyUserForm mainWindow = new ModifyUserForm();
                if(power_cmd.Text == "管理员")
                {
                    mainWindow.UpdateSql("update user set pwd='" + pwd_txtbox.Text.Trim() + "',power=" + 1 + ",staff_number='" + staffnumb_txtbox.Text.Trim() + "' where username ='" + UserManagementForm.username + "'");
                }else if(power_cmd.Text == "普通职员")
                {
                    mainWindow.UpdateSql("update user set pwd='" + pwd_txtbox.Text.Trim() + "',power=" + 2 + ",staff_number='" + staffnumb_txtbox.Text.Trim() + "' where username ='" + UserManagementForm.username + "'");
                }
               
                MessageBox.Show("修改成功", "提示");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败！", "修改提示");
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
