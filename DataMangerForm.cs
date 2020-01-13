using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class DataMangerForm : Form
    {
        public DataMangerForm()
        {
            InitializeComponent();
            DataTable(sql);
        }
        private int rowIndex;
        public MySqlConnection conn = null;
        private string sql = "";
        public int rowDataIndex;
        public static int id;
        private string sqlDataName;
        FtpWebRequest reqFTP;
        FtpWebResponse Response;
        public static string username;
        public static string data;
        public static int staffnumber;
        public static string datatime;

        public void UpdateSql(string s)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            MySqlCommand comm = new MySqlCommand(s, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public string SlipString(string s, string s1, bool Front)
        {
            int i = s.LastIndexOf(s1);
            string s2;
            if (Front)
                return s2 = s.Substring(0, i);
            else
                return s2 = s.Substring(i + 1);
        }
        private string[] Director(string strFile)
        {//(递归)得出已知路径下的所有文件
            string[] s = new string[20];
            int i = 0;
            if (strFile.Length == 0)
                return s;
            else
            {
                try
                {
                    DirectoryInfo directory = new DirectoryInfo(strFile);
                    FileSystemInfo[] fileSystemInfo = directory.GetFileSystemInfos();
                    foreach (FileSystemInfo file in fileSystemInfo)
                    {
                        if (file is DirectoryInfo)
                        {//如果是文件夹，递归调用
                            Director(file.FullName);
                        }
                        else
                        {
                            if (SlipString(file.Name, ".", false).Equals("tif") || SlipString(file.Name, ".", false).Equals("TIF") || SlipString(file.Name, ".", false).Equals("gz") || SlipString(file.Name, ".", false).Equals("GZ"))
                            {
                                s[i] = file.FullName;
                                i++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return s;
            }
        }
        private void Connect(string path)
        {
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(UpDataForm.serverUser, UpDataForm.serverPWD);
        }
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
        }//将数据库内容添加进combobox控件
        //上传数据table
        private void DataTable(string s)
        {
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            sql = "select ti_filename as '上传数据',ti_username as '上传职员',ti_staffnumber as '职员编号',date_format(FROM_UNIXTIME(ti_uploadtime),'%Y-%m-%d %H:%i:%s') as '上传时间',ti_state as '拍摄卫星',ti_filetime as '拍摄时间',ti_filesize as '数据大小',ti_path as'数据路径' from transfer_info";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(comm);
            sda.SelectCommand = comm;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_table.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
        //删除文件
        private void DeleteFile(string fileName)
        {
            //try
            //{
            //    string uri = "ftp://" + UpDataForm.serverIP + fileName;//fileName中/开头
            //    Connect(uri);
            //    reqFTP.KeepAlive = false;
            //    reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
            //    Response = (FtpWebResponse)reqFTP.GetResponse();
            //}
            //catch (Exception) { }
            //finally
            //{
            //    Response.Close();
            //}
        }
        private void DeleteDir(string dirName)
        {
            //try
            //{
            //    string uri = "ftp://" + UpDataForm.serverIP + dirName;
            //    Connect(uri);
            //    reqFTP.KeepAlive = false;
            //    reqFTP.Method = WebRequestMethods.Ftp.RemoveDirectory;
            //    Response = (FtpWebResponse)reqFTP.GetResponse();
            //}
            //catch (Exception) { }
            //finally
            //{
            //    Response.Close();
            //}
        }
        //删除数据
        private void data_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDataIndex = e.RowIndex;
        }
        private void btn_datadelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable myDT = (DataTable)data_table.DataSource;
                DataRow myDR = myDT.Rows[rowDataIndex];
                MessageForm messageForm = MessageForm.getInstatce("确定删除数据：" + myDR[0].ToString() + " 吗？");
                if (messageForm.ShowDialog() == DialogResult.OK)
                {
                    MySqlConnection conn = new MySqlConnection(LoginForm.connString);
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("delete from transfer_info where ti_filename ='" + myDR[0].ToString().Trim() + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    DataTable("select ti_filename as '上传数据',ti_username as '上传职员',ti_staffnumber as '职员编号',date_format(FROM_UNIXTIME(ti_uploadtime),'%Y-%m-%d %H:%i:%s') as '上传时间',ti_state as '拍摄卫星',ti_filetime as '拍摄时间',ti_filesize as '数据大小',ti_path as'数据路径' from transfer_info");
                    DataMangerForm main = new DataMangerForm();
                    string sqlDir = main.SlipString(sqlDataName, "/", true);
                    DeleteFile(sqlDataName);
                    DeleteDir(sqlDir);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("索引处无数据，请重新选择", "提示");
            }
        }

        //Unix时间戳转换为datetime
        public static DateTime UnixTimeToDateTime(int time)
        {
            if (time < 0)
                throw new ArgumentOutOfRangeException("time is out of range");

            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(time);
        }
        //修改上传的数据

        private void btn_datamodify_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable myDT = (DataTable)data_table.DataSource;
                DataRow myDR = myDT.Rows[rowDataIndex];
                username = myDR[1].ToString().Trim();
                data = myDR[0].ToString().Trim();
                staffnumber = Convert.ToInt32(myDR[2].ToString().Trim());
                ModifyDataForm mfForm = new ModifyDataForm();
                mfForm.ShowDialog();
                DataTable("select ti_filename as '上传数据',ti_username as '上传职员',ti_staffnumber as '职员编号',date_format(FROM_UNIXTIME(ti_uploadtime),'%Y-%m-%d %H:%i:%s') as '上传时间',ti_state as '拍摄卫星',ti_filetime as '拍摄时间',ti_filesize as '数据大小',ti_path as'数据路径' from transfer_info");
            }
            catch (Exception)
            {
                MessageBox.Show("请选择需要修改的数据");
            }
            
        }

 
    }
}
