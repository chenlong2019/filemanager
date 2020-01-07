using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.transfer
{
    public partial class UploadForm : Form
    {
        public static UploadForm uploadForm = null;
        private UploadForm()
        {
            InitializeComponent();
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {

        }
        internal static UploadForm GetInstance()
        {
            if (uploadForm == null)
            {
                uploadForm = new UploadForm();
            }
            return uploadForm;
        }

        /// <summary>
        /// 添加UI
        /// </summary>
        /// <param name="flt"></param>
        internal void AddFli(FlowListItem flt)
        {
            this.upload_flp_list.Controls.Add(flt);
        }

        /// <summary>
        /// 移除UI
        /// </summary>
        /// <param name="flowListItem"></param>
        internal void RemoveFli(FlowListItem flowListItem)
        {
            this.upload_flp_list.Controls.Remove(flowListItem);
        }
    }
}
