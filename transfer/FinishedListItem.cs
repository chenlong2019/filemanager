using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileUpload;

namespace FileManager.transfer
{
    public partial class FinishedListItem : UserControl
    {
        public FinishedListItem()
        {
            InitializeComponent();
        }
        internal void applyValue(FileTransmitModel fileTransmitModel)
        {
            this.fli_label_filename.Text = fileTransmitModel.Ti_Filename;
        }
    }
}
