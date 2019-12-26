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
    public partial class UpDataForm : Form
    {
        public UpDataForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choicedata_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "所有文件(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                updata_textBox.Text = dialog.FileName;
            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {

        }
    }
}
