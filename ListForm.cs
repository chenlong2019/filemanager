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

namespace FileManager
{
    /// <summary>Class 
    /// <c>ListForm</c> 
    /// 文件下载界面
    /// </summary>
    public partial class ListForm : Form
    {
        internal MapForm mapForm = null;
        
        public ListForm()
        {
            InitializeComponent();
            if(LoginForm.power == 2)
            {
                this.usertoolStripButton.Visible = false;
                this.datatoolStripButton.Visible = false;
            }
           
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.toolStrip1.ForeColor = Color.FromArgb(112,191,234);
            this.list_btn_search.BackColor = Color.FromArgb(112, 191, 234);
            this.list_btn_resert.BackColor = Color.FromArgb(112, 191, 234);
            LoadMapForm();
            JsonAdapter.GetProvince(this.list_cb_province, File.ReadAllText("Resources/provicecityarea.json"),"0000","p");
            LoadLayoutPanel();
        }

        /// <summary>
        /// <c>LoadLayoutPanel</c>
        /// 展示查询结果
        /// </summary>
        private void LoadLayoutPanel()
        {
            this.tableLayoutPanel1.Height = this.list_panel_result.Height + 1;
            this.tableLayoutPanel1.Width = this.list_panel_result.Width - 1;
            for (int i = 1; i <= 10; i++)
            {
                AddRow();
            }
        }

        /// <summary>
        /// 添加行
        /// </summary>
        private void AddRow()
        {
            tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 201;
            int i = tableLayoutPanel1.RowCount;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200));
            ListResultPanel listResultPanel = new ListResultPanel();
            listResultPanel.Height = 195;
            listResultPanel.Top = 3;
            tableLayoutPanel1.Controls.Add(listResultPanel, 0,i);
            tableLayoutPanel1.RowCount++;
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
        private void List_btn_search_Click(object sender, EventArgs e)
        {

        }

        

        private void uploadtoolStripButton_Click(object sender, EventArgs e)
        {
            UploadForm uploadform = new UploadForm();
            uploadform.Show();
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
    }
}
