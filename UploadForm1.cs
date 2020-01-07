using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.transfer;

namespace FileManager
{
    public partial class UploadForm1 : Form
    {
        public static UploadForm1 uploadForm;
        public UploadForm1()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            UpDataForm upfrom = new UpDataForm(new ListForm());
            upfrom.Show();
        }

        internal static UploadForm1 GetInstance()
        {
            if (uploadForm == null)
            {
                uploadForm = new UploadForm1();
            }
            return uploadForm;
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
