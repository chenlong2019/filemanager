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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            power_cmb.Items.Add("管理员");
            power_cmb.Items.Add("普通职员");
        }
        /// <summary>
        /// 判断数据是否重复
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            if (username_textBox.Text.Trim().Length == 0 || username_textBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("用户名设置不合规范（请保证在1-20字符区间）！", "注册提示");
                username_textBox.Focus();
                return;
            }
            if (pwd_textBox.Text.Trim().Length == 0 || pwd_textBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("密码设置不合规范（请保证在1-20字符区间）！", "注册提示");
                pwd_textBox.Focus();
                return;
            }
            if (!(pwd_textBox.Text.Trim().Equals(pwd2_textBox.Text.Trim())))
            {
                MessageBox.Show("二次密码不相同", "注册提示");
                pwd2_textBox.Focus();
                pwd2_textBox.SelectAll();
                return;
            }
            if (power_cmb.Text.Trim().Length == 0)
            {
                MessageBox.Show("权限不能为空", "注册提示");
                return;
            }
            if (staffnumb_textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("职员编号不能为空", "注册提示");
                staffnumb_textBox.Focus();
                return;
            }
            
            if (username_textBox.Text.Trim().Length > 0 || username_textBox.Text.Trim().Length > 20)
            {
                AddUserForm main = new AddUserForm();
                if (main.DataRepeat("select * from User where username='" + username_textBox.Text.Trim() + "' or staff_number=" + staffnumb_textBox.Text.Trim()))
                {
                    MessageBox.Show("用户名已存在,或者该职员已有账号", "注册提示");
                    username_textBox.Focus();
                    username_textBox.SelectAll();
                    return;
                }
                MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                try
                {
                    if(power_cmb.Text == "管理员")
                    {
                        string SQL = "insert into user values('" + username_textBox.Text.Trim() + "','" + pwd_textBox.Text.Trim() + "','" + 1 + "','" + staffnumb_textBox.Text.Trim() + "')";
                        //Console.WriteLine(SQL);
                        MySqlCommand comm = new MySqlCommand(SQL, conn);
                        comm.ExecuteNonQuery();
                    }
                    else if(power_cmb.Text == "普通职员")
                    {
                        string SQL = "insert into user values('" + username_textBox.Text.Trim() + "','" + pwd_textBox.Text.Trim() + "','" + 2 + "','" + staffnumb_textBox.Text.Trim() + "')";
                        //Console.WriteLine(SQL);
                        MySqlCommand comm = new MySqlCommand(SQL, conn);
                        comm.ExecuteNonQuery();
                    }
                    
                   
                    MessageBox.Show("注册成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
