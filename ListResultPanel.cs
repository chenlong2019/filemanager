using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FileManager
{
    /// <summary>
    ///  <c>ListResultPanel</c>
    ///  查询结果展示
    /// </summary>
    public partial class ListResultPanel : UserControl
    {
        public ListResultPanel()
        {
            InitializeComponent();
        }
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
        private void download_Click(object sender, EventArgs e)
        {
            if(LoginForm.power == 1)
            {

            }
            else if(LoginForm.power == 2)
            {
                MessageBox.Show("已提交下载申请，审核通过后，在进行下载！");


            }
            else if(LoginForm.power == 2 || DataRepeat("select *from application where opinion='同意'"))
            {

            }
        }
    }
}
