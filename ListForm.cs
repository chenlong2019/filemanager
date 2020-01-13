using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using FileUpload;
using System.Threading;
using System.Net;
using FileManager.transfer;
using LitJson;
using System.Collections;
using MySql.Data.MySqlClient;

namespace FileManager
{
    /// <summary>Class 
    /// <c>ListForm</c> 
    /// 文件下载界面
    /// </summary>
    public partial class ListForm : Form
    {
        internal MapForm mapForm = null;
        private readonly Color menuBackColor = Color.FromArgb(200, 200, 169);
        private readonly Color menuMouserOverColor = Color.FromArgb(230, 206, 172);
        // 下载队列
        Queue<FlowListItem> downloadQueue = new Queue<FlowListItem>();
        // 上传队列
        Queue<FlowListItem> uploadQueue = new Queue<FlowListItem>();
        // 传输完成委托
        private delegate void RemoveListDelegate(FlowListItem flowListItem, int count,string state);
        RemoveListDelegate removeListDelegate = null;
        // 下载控制
        private static bool m_IsRunning;
        // 上传控制
        private static bool u_IsRunning;
        public ListForm()
        {
            InitializeComponent();
            if(LoginForm.power == 2)
            {
                this.usertoolStripButton.Visible = false;
                this.datatoolStripButton.Visible = false;
            }
            list_cb_statellite.Items.Add("S1A");
            list_cb_statellite.Items.Add("S1B");
            list_cb_statellite.Items.Add("所有");
            list_cb_statellite.SelectedIndex = 2;
            list_cb_datatype.Items.Add("SM");
            list_cb_datatype.Items.Add("IW");
            list_cb_datatype.Items.Add("EW");
            list_cb_datatype.Items.Add("MV");
            list_cb_datatype.Items.Add("所有");
            list_cb_datatype.SelectedIndex = 4;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.toolStrip1.ForeColor = Color.FromArgb(112,191,234);
            this.list_btn_search.BackColor = Color.FromArgb(112, 191, 234);
            this.list_btn_resert.BackColor = Color.FromArgb(112, 191, 234);
            this.list_btn_closefilepanel.BackColor = Color.FromArgb(112, 191, 234);
            LoadMapForm();
            JsonAdapter.GetProvince(this.list_cb_province, File.ReadAllText("Resources/provicecityarea.json"),"0000","p");
            LoadLayoutPanel();
            //LoadTranferForm();
        }
       

        /// <summary>
        /// <c>LoadLayoutPanel</c>
        /// 展示查询结果
        /// </summary>
        private void LoadLayoutPanel()
        {
            for(int i = 0; i < 10; i++)
            {
                
            }
            
        }

       
        /// <summary>
        /// 文件上传
        /// </summary>
        internal void UpLoadFile(FileTransmitModel fileTransmitModel)
        {
            UploadForm uploadForm = UploadForm.GetInstance();
            ChangeState(this.list_btn_uploading, uploadForm);
            lock (uploadQueue)
            {
                // 添加控件
                FlowListItem flowListItem = new FlowListItem(fileTransmitModel);
                uploadQueue.Enqueue(flowListItem);
                removeListDelegate = new RemoveListDelegate(DownloadFinished);
                foreach (FlowListItem flt in uploadQueue)
                {
                    uploadForm.AddFli(flt);
                }
            }
            uploadForm.BeginInvoke(removeListDelegate, null, uploadQueue.Count,"upload");
            Console.WriteLine(uploadQueue.Count);
            if (!u_IsRunning)
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    StartUpLoadFile();
                });
            }
        }

        // 开始文件上传队列
        private void StartUpLoadFile()
        {
            UploadForm uploadForm = UploadForm.GetInstance();
            while (true)
            {

                u_IsRunning = true;
                FlowListItem flowListItem = null;
                if (uploadQueue.Count == 0)
                {
                    u_IsRunning = false;
                    return;
                }
                flowListItem = uploadQueue.ElementAt(0);
                flowListItem.tranStateDelegate = new FlowListItem.TranStateDelegate(flowListItem.RefershUI);
                FileTransmitModel fileTransmitModel = flowListItem.GetFileTransmitModel();
                try
                {
                    string url = fileTransmitModel.Ti_Url+ @"/fileUpload";
                    string name = fileTransmitModel.Ti_Path + @"\" + fileTransmitModel.Ti_Filename;
                    // NetManager.HttpDownloadFile(url, filename.ToString(), this, upLoadDelgate);
                    NetManager.HttpUploadFile(url, name, this, flowListItem.tranStateDelegate, fileTransmitModel);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                lock (uploadQueue)
                {
                    uploadQueue.Dequeue();
                }
                uploadForm.BeginInvoke(removeListDelegate, flowListItem, uploadQueue.Count, "upload");
            }
        }

        /// <summary>
        /// <c>MapForm</c> 
        /// 加载地图窗体
        /// </summary>
        private void LoadMapForm()
        {
            MapForm mapForm = new MapForm(this);
            if (mapForm != null)
            {
                mapForm.TopLevel = false;
                mapForm.Parent = this.list_mappanel;
                mapForm.Dock = DockStyle.Fill;
            }
            mapForm.Show();
        }

        /// <summary>method <c>List_btn_resert_Click</c> 
        /// 重置
        /// </summary>
        private void List_btn_resert_Click(object sender, EventArgs e)
        {
            try
            {
                this.list_panel_result.Dispose();
                //list_panel_result.Visiblity = Visiblity.Visible;
                this.list_cb_datatype.SelectedIndex = 0;
                this.list_cb_area.SelectedIndex = 0;
                this.list_cb_province.SelectedIndex = 0;
                this.list_cb_statellite.SelectedIndex = 0;
                this.list_cb_city.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("数组异常");
            }
           
        }

        /// <summary>method <c>List_btn_search_Click</c> 
        /// 开始查询
        /// </summary>
        //获取时间戳
        public static long GetUnixTime(DateTime dateTime)
        {
            return (long)(dateTime - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        //按拍摄时间选择数据
        private void List_btn_search_Click(object sender, EventArgs e)
        {
            /*long l1 = GetUnixTime(list_dtp_startdate.Value);
            long l2 = GetUnixTime(list_dtp_enddate.Value);
            MySqlConnection conn = new MySqlConnection(LoginForm.connString);
            conn.Open();
            string sql = "select ii_filename from image_info where ii_starttime>="+l1+ " and ii_endtime<="+l2;
            Console.WriteLine(sql);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader sdr = comm.ExecuteReader();*/
            string satellitedata = this.list_cb_statellite.Text;
            string modelname = this.list_cb_datatype.Text;
            long starttime = GetUnixTime(list_dtp_startdate.Value);
            string postdata = String.Format("satellitedata={0}&modelname={1}&starttime={2}", satellitedata, modelname, starttime);
            // 查询数据
            String url = "http://localhost:8080/searchData";
            string success = NetManager.HttpPost(url, postdata);
            JsonData datalist = JsonMapper.ToObject(success);
            foreach (JsonData data in datalist)
            {
                ImageInfoModel imageInfoModel = new ImageInfoModel();
                imageInfoModel.Ii_ID = data["ii_Id"].ToString();
                if (data["ii_Filename"] != null)
                    imageInfoModel.Ii_Filename = data["ii_Filename"].ToString();
                if (data["ii_SatelliteIdentification"] != null)
                    imageInfoModel.Ii_SatelliteIdentification = data["ii_SatelliteIdentification"].ToString();
                if (data["ii_ModelName"] != null)
                    imageInfoModel.Ii_Modelname = data["ii_ModelName"].ToString();
                if (data["ii_ProductName"] != null)
                    imageInfoModel.Ii_Productname = data["ii_ProductName"].ToString();
                if (data["ii_ProcessingLevel"] != null)
                    imageInfoModel.Ii_Productname = data["ii_ProcessingLevel"].ToString();
                if (data["ii_StartTime"] != null)
                    imageInfoModel.Ii_Starttime = data["ii_StartTime"].ToString();
                if (data["ii_EndTime"] != null)
                    imageInfoModel.Ii_Endtime = data["ii_EndTime"].ToString();
                if (data["ii_AbsoluteOrbit"] != null)
                    imageInfoModel.Ii_Absoluteorbit = data["ii_AbsoluteOrbit"].ToString();
                if (data["ii_MissionDataTakeIdentifier"] != null)
                    imageInfoModel.Ii_MissiondatatakeIdentifier = data["ii_MissionDataTakeIdentifier"].ToString();
                if (data["ii_ProductUniqueIdentificationCode"] != null)
                    imageInfoModel.Ii_ProductuniqueIdentificationcode = data["ii_ProductUniqueIdentificationCode"].ToString();
                if (data["ii_Path"] != null)
                    imageInfoModel.Ii_Path = data["ii_Path"].ToString();
                if (data["ii_Filesize"] != null)
                    imageInfoModel.Ii_Filesize = data["ii_Filesize"].ToString();
                if (data["ii_Staffnumber"] != null)
                    imageInfoModel.Ii_Staffnumber = data["ii_Staffnumber"].ToString();
                if (data["ii_Uploadtime"] != null)
                    imageInfoModel.Ii_Uploadtime = data["ii_Uploadtime"].ToString();
                if (data["ii_Log"] != null)
                    imageInfoModel.Ii_Log = data["ii_Log"].ToString();
                if (data["ii_Lat"] != null)
                    imageInfoModel.Ii_Lat = data["ii_Lat"].ToString();
                this.list_flp_downloadlist.Controls.Add(new ListResultPanel(imageInfoModel, this));
            }
        }



        private void uploadtoolStripButton_Click(object sender, EventArgs e)
        {
            UpDataForm upfrom = new UpDataForm(this);
            if (upfrom.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void minetoolStripButton_Click(object sender, EventArgs e)
        {
            MyDataForm mydataform = new MyDataForm();
            mydataform.Show();
        }

        private void List_cb_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboxModel comboxModel = this.list_cb_province.SelectedItem as ComboxModel;
            string json = comboxModel.Json;
            JsonAdapter.GetProvince(this.list_cb_city, json, "00", "c");
        }

        private void List_cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboxModel comboxModel = this.list_cb_city.SelectedItem as ComboxModel;
            string json = comboxModel.Json;
            JsonAdapter.GetProvince(this.list_cb_area, json, "", "a");
        }

        private void List_cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void usertoolStripButton_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
        }

        private void datatoolStripButton_Click(object sender, EventArgs e)
        {
            DataMangerForm dataMangerForm = new DataMangerForm();
            dataMangerForm.Show();
        }

        /// <summary>
        ///  窗体关闭
        /// </summary>
        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // 查看文件传输列表
        private void ListfileuploadtoolStripButton_Click(object sender, EventArgs e)
        {
            this.list_panel_fileupload.Visible = true;
            this.layout_panel_tra.Visible = true;
            addButton(this.list_btn_downloading);
            addButton(this.list_btn_uploading);
            addButton(this.list_btn_finished);
        }
        /// <summary>
        /// 填充button
        /// </summary>
        /// <param name="btn"></param>
        private void addButton(Button btn)
        {
            //btn样式
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = menuMouserOverColor;
            btn.FlatAppearance.BorderSize = 0;
            //btn宽、高
            btn.Width = list_flp_btnlist.Width;
            btn.Height = 40;
            //设置button间的margin为0
            Padding pd = new Padding();
            pd.All = 0;
            btn.Margin = pd;
            //引用鼠标点击事件
            //btn.MouseClick += new MouseEventHandler(btn_OnClick);
            list_flp_btnlist.BackColor = menuBackColor;
        }

        // 影藏传输列表
        private void List_btn_closefilepanel_Click(object sender, EventArgs e)
        {
            this.list_panel_fileupload.Visible = false;
            this.layout_panel_tra.Visible = false;
        }

        /// <summary>
        /// 正在下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_btn_downloading_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            DownloadForm downloadForm = DownloadForm.GetInstance();
            ChangeState(bt, downloadForm);
        }

        private void ChangeState(Button bt, Form form)
        {
            this.list_btn_downloading.BackColor = Color.FromArgb(255, 255, 0);
            this.list_btn_finished.BackColor = Color.FromArgb(255, 255, 0);
            this.list_btn_uploading.BackColor = Color.FromArgb(255, 255, 0);
            bt.BackColor = Color.FromArgb(0, 255, 0);
            if (form != null)
            {
                this.layout_panel_tra.Controls.Clear();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Parent = this.layout_panel_tra;
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                this.layout_panel_tra.Controls.Add(form);
                form.Show();
            }
        }

        // 正在上传
        private void List_btn_uploading_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            UploadForm upLoadForm = UploadForm.GetInstance();
            ChangeState(bt, upLoadForm);
        }

        // 传输完成
        private void List_btn_finished_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            FinishedListForm finishedListForm = FinishedListForm.GetInstance();
            ChangeState(bt, finishedListForm);
        }

        // 下载测试
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            //downloadFiles();
        }

        public void downloadFiles(ImageInfoModel imageInfoModel)
        {
            DownloadForm downloadForm = DownloadForm.GetInstance();
            ChangeState(this.list_btn_downloading, downloadForm);
            downloadFile(imageInfoModel);
        }
        // 单个文件下载完成
        private void DownloadFinished(FlowListItem flowListItem, int count,string state)
        {
            if (flowListItem != null)
            {
                if (state == "download")
                {
                    DownloadForm downloadForm = DownloadForm.GetInstance();
                    downloadForm.RemoveFli(flowListItem);
                }
                else if (state == "upload")
                {
                    UploadForm uploadForm = UploadForm.GetInstance();
                    uploadForm.RemoveFli(flowListItem);
                }
               
                FinishedListForm finishedListForm = FinishedListForm.GetInstance();
                if (flowListItem.GetImageInfoModel() != null)
                {
                    // 传输完成列表添加此项
                    finishedListForm.Add(flowListItem.GetImageInfoModel());
                }
                
                int finishedcount = finishedListForm.GetItemCount();
                layout_label_finished.Visible = true;
                if (finishedcount < 100)
                {
                    if (finishedcount > 0)
                    {

                        layout_label_finished.Text = finishedcount.ToString();
                    }
                    else
                    {
                        layout_label_finished.Visible = false;
                    }
                }
                else
                {
                    layout_label_finished.Text = "99+";
                }

            }

            if (count == 0)
            {
                layout_label_downloading.Visible = false;
            }
            else
            {
                layout_label_downloading.Visible = true;
            }

            if (count < 100)
            {
                layout_label_downloading.Text = count.ToString();
            }
            else
            {
                layout_label_downloading.Text = "99+";
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="fileTransmitModel">下载参数</param>
        private void downloadFile(ImageInfoModel imageInfoModel)
        {
            DownloadForm downloadForm = DownloadForm.GetInstance();
            lock (downloadQueue)
            {
                // 添加控件
                FlowListItem flowListItem = new FlowListItem(imageInfoModel);
                downloadQueue.Enqueue(flowListItem);
                removeListDelegate = new RemoveListDelegate(DownloadFinished);
                foreach (FlowListItem flt in downloadQueue)
                {
                    downloadForm.AddFli(flt);
                }
            }
            downloadForm.BeginInvoke(removeListDelegate, null, downloadQueue.Count, "download");
            Console.WriteLine(downloadQueue.Count);
            if (!m_IsRunning)
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    StartDawnload();
                });
            }
        }

        private string FileIsExists(string name, string path,int index)
        {
            if (System.IO.File.Exists(path))
            {
                string filepath = System.IO.Path.GetDirectoryName(path) + @"\" + name + "(" + index + ")" + System.IO.Path.GetExtension(path);
                return FileIsExists(name,filepath, index+1);
            }
            return path;
        }
        private void StartDawnload()
        {
            DownloadForm downloadForm = DownloadForm.GetInstance();
            while (true)
            {

                m_IsRunning = true;
                FlowListItem flowListItem = null;
                if (downloadQueue.Count == 0)
                {
                    m_IsRunning = false;
                    return;
                }
                flowListItem = downloadQueue.ElementAt(0);
                flowListItem.tranStateDelegate = new FlowListItem.TranStateDelegate(flowListItem.RefershUI);
                ImageInfoModel imageInfoModel = flowListItem.GetImageInfoModel();
                TranState tranState;
                try
                {
                    string url = LoginForm.serverURL + @"/download?filename="+ imageInfoModel.Ii_Filename; 
                    string path = @"E:\文件管理数据\下载" + @"\" + imageInfoModel.Ii_Filename;
                    string name=System.IO.Path.GetFileNameWithoutExtension(path);
                    string filepath=FileIsExists(name,path, 1);
                    // NetManager.HttpDownloadFile(url, filename.ToString(), this, upLoadDelgate);
                    NetManager.DownloadFile(url, filepath, this, flowListItem.tranStateDelegate);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                lock (downloadQueue)
                {
                    downloadQueue.Dequeue();
                }
                downloadForm.BeginInvoke(removeListDelegate, flowListItem, downloadQueue.Count, "download");
            }
        }

        // 上传测试
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        // 网络测试
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8080/allfile";
            string success = NetManager.HttpPost(url, "");// "{\"ti_ID\":\"f1b7f6ff26934e33819008cc41ef7951\",\"ti_Filename\":\"2019100108-11.rar\",\"ti_Url\":\"http://localhost:8080/fileUpload\",\"ti_State\":\"0\",\"ti_FileSize\":\"4353 KB\",\"ti_UploadTime\":\"1578362206\",\"ti_FileTime\":null,\"ti_Path\":\"F:\\xu\\201909301811\"},{\"ti_ID\":\"d13cda6e96dc4889a6a7f94b2c4e94e4\",\"ti_Filename\":\"2019100108-11.rar\",\"ti_Url\":\"http://localhost:8080/fileUpload\",\"ti_State\":\"0\",\"ti_FileSize\":\"4353 KB\",\"ti_UploadTime\":\"1578359650\",\"ti_FileTime\":null,\"ti_Path\":\"F:\\xu\\201909301811\"},{\"ti_ID\":\"89e9ebc72367401aa55b5e7b48cc15fc\",\"ti_Filename\":\"093000.rar\",\"ti_Url\":\"http://localhost:8080/fileUpload\",\"ti_State\":\"0\",\"ti_FileSize\":\"939 KB\",\"ti_UploadTime\":\"1578362217\",\"ti_FileTime\":null,\"ti_Path\":\"F:\\xu\\201909301811\"}";
            //""//
            Console.WriteLine("success:" + success);
            JsonData datalist = JsonMapper.ToObject(success);
            Console.WriteLine("success:" + datalist);
            foreach (JsonData data in datalist)
            {
                FileTransmitModel fileTransmitModel = new FileTransmitModel();
                fileTransmitModel.Ti_ID=data["ti_ID"].ToString();
                if (data["ti_Path"] != null)
                    fileTransmitModel.Ti_Path = data["ti_Path"].ToString();
                if (data["ti_State"] != null)
                    fileTransmitModel.Ti_State = data["ti_State"].ToString();
                if (data["ti_UploadTime"] != null)
                    fileTransmitModel.Ti_UploadTime = data["ti_UploadTime"].ToString();
                if (data["ti_Url"] != null)
                    fileTransmitModel.Ti_Url = data["ti_Url"].ToString();
                if (data["ti_FileSize"] != null)
                    fileTransmitModel.Ti_FileSize = data["ti_FileSize"].ToString();
                if (data["ti_Filename"] != null)
                    fileTransmitModel.Ti_Filename = data["ti_Filename"].ToString();
                if(data["ti_FileTime"]!=null)
                    fileTransmitModel.Ti_FileTime = data["ti_FileTime"].ToString();
                this.list_flp_downloadlist.Controls.Add(new ListResultPanel(fileTransmitModel,this));
            }
        }

        private void indextoolStripButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

    }
}
