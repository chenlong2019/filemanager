using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    /// <summary>
    ///  <c>ListResultPanel</c>
    ///  查询结果展示
    /// </summary>
    public partial class ListResultPanel : UserControl
    {
        public ListResultPanel()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            if(LoginForm.power == 1)
            {

            }
            else if(LoginForm.power == 2)
            {

            }
        }
    }
}
