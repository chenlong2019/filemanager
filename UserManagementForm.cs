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
            UserTable(sql);
        }
        private int rowIndex;
        public static string username;
        public static string pwd;
        public static int power;
        public static int staffnumber;

        private void user_register_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
        public MySqlConnection conn = null;
        private string sql = "";
        private void UserTable(string s)
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
        //删除数据
        private void user_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
        private void user_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable myDT = (DataTable)user_table.DataSource;
                DataRow myDR = myDT.Rows[rowIndex];
                MessageForm messageForm = MessageForm.getInstatce("确定删除用户：" + myDR[0].ToString() + " 吗？");
                if (messageForm.ShowDialog() == DialogResult.OK)
                {
                    MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("delete from user where username='" + myDR[0].ToString().Trim() + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    UserTable("select username as '人员姓名',pwd as '登陆密码',power as '人员权限',staff_number as '人员编号' from user");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("索引处无数据，请重新选择", "提示");
            }
        }
        //修改用户
        private void user_modify_Click(object sender, EventArgs e)
        {
            DataTable myDT = (DataTable)user_table.DataSource;
            DataRow myDR = myDT.Rows[rowIndex];
            username = myDR[0].ToString().Trim();
            pwd = myDR[1].ToString().Trim();
            power = Convert.ToInt32(myDR[2].ToString().Trim());
            staffnumber = Convert.ToInt32(myDR[3].ToString().Trim());
            ModifyUserForm mfForm = new ModifyUserForm();
            mfForm.ShowDialog();
            UserTable("select username as '人员姓名', pwd as '登陆密码', power as '人员权限', staff_number as '人员编号' from user");
        }
    }
}
