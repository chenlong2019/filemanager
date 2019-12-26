using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FileManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString(), Namer;
        public bool ifom = false;
        public static int power = 1, staff_Number;
        private void Txt_Pwd_KeyDown(object sender,KeyEventArgs e)
        {
            if(txt_userpwd.Text.Length == 0)
            {
                return;
            }
            if (e.KeyValue == 13)
                btn_login_Click(null, null);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
                txt_username.Focus();
                return;
            }
            if(txt_userpwd.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空！");
                txt_userpwd.Focus();
                return;
            }
            if(txt_username.Text.Length != 0 && txt_userpwd.Text.Length != 0)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                try
                {
                    string s ="select *from user where username='" + txt_username.Text +"'and Pwd='" + txt_userpwd.Text + "'";
                    MySqlCommand com = new MySqlCommand(s, conn);
                    MySqlDataReader sdr = com.ExecuteReader();
                    bool l1 = sdr.Read();
                    power = Convert.ToInt32(sdr[2].ToString().Trim());
                    staff_Number = Convert.ToInt32(sdr[3].ToString().Trim());
                    Namer = sdr[4].ToString().Trim();
                    conn.Close();
                    if (l1)
                    {
                        ifom = true;
                        this.Hide();
                        ListForm listForm = new ListForm();
                        listForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("账号或密码不正确！");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
