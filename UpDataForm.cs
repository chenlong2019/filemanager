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
using FileUpload;

namespace FileManager
{
    public partial class UpDataForm : Form
    {
        private ListForm listForm;
        public UpDataForm(ListForm listForm)
        {
            InitializeComponent();
            this.listForm = listForm;
        }

        public static string serverIP = ConfigurationManager.ConnectionStrings["serverIP"].ToString();
        public static string serverUser = "jiutian";
        public static string serverPWD = "jiutian";
        public static string localDataPath="";
        public static string localDataName = "";
        public static string directory = "";

      
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choicedata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "所有文件(*.*)|*.*";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                localDataPath = openFile.FileName;
                updata_textBox.Text = openFile.FileName;
                localDataName = openFile.SafeFileName;
            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        private void UploadFile()
        {
            FileTransmitModel fileTransmitModel = new FileTransmitModel();
            fileTransmitModel.Ti_ID = System.Guid.NewGuid().ToString("N");
            fileTransmitModel.Ti_Url = "http://localhost:8080";
            if (localDataName.Equals("")) return;
            fileTransmitModel.Ti_Path = System.IO.Path.GetDirectoryName(localDataPath);
            fileTransmitModel.Ti_Filename = System.IO.Path.GetFileName(localDataPath);
            string path = fileTransmitModel.Ti_Path + @"\" + fileTransmitModel.Ti_Filename;
            System.IO.FileInfo  fileInfo = new System.IO.FileInfo(path);
            fileTransmitModel.Ti_FileSize = System.Math.Ceiling(fileInfo.Length / 1024.0) + " KB";
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            fileTransmitModel.Ti_UploadTime = Convert.ToInt64(ts.TotalMilliseconds/1000).ToString();
            this.listForm.UpLoadFile(fileTransmitModel);
        }

        private void UpDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
