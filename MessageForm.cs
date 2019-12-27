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
    /// <summary>
    /// Class <c>消息弹出窗体</c>
    /// </summary>
    public partial class MessageForm : Form
    {
        private static MessageForm messageForm = null;
        private MessageForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// 弹出窗体
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static MessageForm getInstatce(string msg)
        {
            if (messageForm == null)
            {
                messageForm = new MessageForm();
            }
            messageForm.label_msg.Text = msg;
            return messageForm;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(50, 118, 255); //FromArgb(45, 75, 207);
            this.panel1.BackColor = Color.FromArgb(28, 51, 156);
            this.panel1.Width = this.Width - 6;
            this.panel1.Height = this.Height - 6;
            this.panel1.Left = 3;
            this.panel1.Top = 3;
            this.label_msg.Width = this.panel1.Width - 60;
            this.label_msg.Left = 30;
            this.cpw_ok.Width = this.Width / 2;
            this.cpw_ok.BackColor= Color.FromArgb(63, 99, 255);
            this.Opacity = 0.9;
            this.TopMost = true;
        }

        // 添加
        private void Cpw_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
