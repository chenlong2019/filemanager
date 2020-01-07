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
    public partial class DownloadForm : Form
    {
        public static DownloadForm downloadForm = null;
        private DownloadForm()
        {
            InitializeComponent();
        }



        private void DownloadForm_Load(object sender, EventArgs e)
        {

        }

        internal static DownloadForm GetInstance()
        {
            if (downloadForm == null)
            {
                downloadForm = new DownloadForm();
            }
            return downloadForm;
        }

        internal void AddFli(FlowListItem flt)
        {
            this.download_flp_list.Controls.Add(flt);
        }

        internal void RemoveFli(FlowListItem flowListItem)
        {
            this.download_flp_list.Controls.Remove(flowListItem);
        }
    }
}
