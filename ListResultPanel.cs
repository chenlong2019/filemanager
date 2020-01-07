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
using FileUpload;

namespace FileManager
{
    /// <summary>
    ///  <c>ListResultPanel</c>
    ///  查询结果展示
    /// </summary>
    public partial class ListResultPanel : UserControl
    {
        private readonly FileTransmitModel transmitModel;
        private readonly ListForm listForm;
        public ListResultPanel(FileTransmitModel transmitModel,ListForm listForm)
        {
            InitializeComponent();
            this.transmitModel = transmitModel;
            this.listForm = listForm;
            this.lrp_label_filename.Text = transmitModel.Ti_Filename;
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

        public FileTransmitModel GetTransmitModel()
        {
            return transmitModel;
        }

        private void download_Click(object sender, EventArgs e)
        {
            listForm.downloadFiles(this.transmitModel);
            /*if(LoginForm.power == 1)
            {

            }
            else if(LoginForm.power == 2)
            {
<<<<<<< HEAD
                MessageBox.Show("已提交下载申请，审核通过后，在进行下载！");
=======
                MessageBox.Show("您没有权限下载数据，下载此数据需要提交申请，已提交下载申请，审核通过后，在进行下载！");


>>>>>>> 9d9cb976b90779e9e4b6b4b16b091df276ab56a5
            }
            else if(LoginForm.power == 2 || DataRepeat("select *from application where opinion='同意'"))
            {

            }*/
        }
    }
}
