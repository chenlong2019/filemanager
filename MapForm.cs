﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    /// <summary>Class <c>MapForm</c> 地图显示窗体</summary>
    ///
    public partial class MapForm : Form
    {
        public static MapForm mapForm = null;
        private ListForm listForm;
        /// <summary>method <c>MapForm</c> </summary>
        /// <param name="ListForm">窗体面板</param>
        private MapForm(ListForm listForm)
        {
            InitializeComponent();
            this.listForm = listForm;
        }

        public static MapForm GetMapForm(ListForm listForm)
        {
            
            if (mapForm == null)
            {
                mapForm = new MapForm(listForm);
            }
            return mapForm;
        }

        /// <summary>method <c>MapForm_Load</c> 窗体加载 </summary>
        private void MapForm_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string str_url = path + "/Resources/index.html";
            webBrowser1.Navigate(str_url);
        }

        internal void ShowMap(string lng, string lat)
        {
            this.webBrowser1.Document.InvokeScript("showMap", new string[] { lng, lat});
        }
    }
}
