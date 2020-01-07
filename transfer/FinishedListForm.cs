using FileUpload;
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
    public partial class FinishedListForm : Form
    {
        private static FinishedListForm finishedListForm;
        public FinishedListForm()
        {
            InitializeComponent();
        }

        private void FinishedListForm_Load(object sender, EventArgs e)
        {

        }
        public int GetItemCount()
        {
            return this.finished_flp_list.Controls.Count;
        }

        public static FinishedListForm GetInstance()
        {
            if (finishedListForm == null)
            {
                finishedListForm = new FinishedListForm();
            }
            return finishedListForm;
        }

        internal void Add(FileTransmitModel fileTransmitModel)
        {
            FinishedListItem finishedListItem = new FinishedListItem();
            finishedListItem.Width = this.finished_flp_list.Width;
            finishedListItem.Height = 130;
            finishedListItem.BackColor = Color.FromArgb(211, 220, 217);
            finishedListItem.applyValue(fileTransmitModel);
            this.finished_flp_list.Controls.Add(finishedListItem);
        }

    }
}
