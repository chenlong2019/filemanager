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
using System.Windows;

namespace FileManager
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            UserTable();
        }
        private int rowIndex;

        private void user_register_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
        public MySqlConnection conn = null;
        private string sql = "";
        private void UserTable()
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            sql = "select username as '人员姓名',pwd as '登陆密码',power as '人员权限',staff_number as '人员编号' from user";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(comm);
            sda.SelectCommand = comm;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            user_table.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void user_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable myDT = (DataTable)user_table.DataSource;
                DataRow myDR = myDT.Rows[rowIndex];
                MessageBoxResult result = MessageBox.Show("确定删除用户：" + myDR[0].ToString() + " 吗？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("delete from [User] where UserName='" + myDR[0].ToString().Trim() + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    UserTable("select UserName as 用户名,Pwd as 密码,Power as 权限,Staff_Number as 职员编号,People as 姓名 from [User]");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("索引处无数据，请重新选择", "提示");
            }
        }
    }
}
