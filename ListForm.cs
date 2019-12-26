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
    /// <summary>Class <c>ListForm</c> 文件下载界面</summary>
    public partial class ListForm : Form
    {
        internal MapForm mapForm = null;

        public ListForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.toolStrip1.ForeColor = Color.FromArgb(112,191,234);
            this.list_btn_search.BackColor = Color.FromArgb(112, 191, 234);
            this.list_btn_resert.BackColor = Color.FromArgb(112, 191, 234);
            LoadMapForm();
            JsonAdapter.GetProvince(this.list_cb_province);
        }

        

        /// <summary>method <c>MapForm</c> 加载地图窗体</summary>
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

        // <summary>method <c>List_btn_resert_Click</c> 重置</summary>
        private void List_btn_resert_Click(object sender, EventArgs e)
        {
            try
            {
                this.list_cb_datatype.SelectedIndex = 0;
                this.list_cb_district.SelectedIndex = 0;
                this.list_cb_province.SelectedIndex = 0;
                this.list_cb_statellite.SelectedIndex = 0;
                this.list_cb_town.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("数组异常");
            }
           
        }

        private void List_btn_search_Click(object sender, EventArgs e)
        {

        }

        // 改变省份
        private void List_cb_town_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = this.list_cb_province.Text;
            JsonAdapter.GetCity(province);
        }
    }
}
