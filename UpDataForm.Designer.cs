namespace FileManager
{
    partial class UpDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updata_textBox = new System.Windows.Forms.TextBox();
            this.btn_choicedata = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_updata = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // updata_textBox
            // 
            this.updata_textBox.Location = new System.Drawing.Point(33, 44);
            this.updata_textBox.Name = "updata_textBox";
            this.updata_textBox.Size = new System.Drawing.Size(354, 21);
            this.updata_textBox.TabIndex = 0;
            // 
            // btn_choicedata
            // 
            this.btn_choicedata.Location = new System.Drawing.Point(400, 44);
            this.btn_choicedata.Name = "btn_choicedata";
            this.btn_choicedata.Size = new System.Drawing.Size(100, 23);
            this.btn_choicedata.TabIndex = 1;
            this.btn_choicedata.Text = "选择文件";
            this.btn_choicedata.UseVisualStyleBackColor = true;
            this.btn_choicedata.Click += new System.EventHandler(this.btn_choicedata_Click);
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(531, 44);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(93, 23);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "选择目录";
            this.btn_file.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(436, 235);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_updata.Location = new System.Drawing.Point(140, 235);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(75, 23);
            this.btn_updata.TabIndex = 12;
            this.btn_updata.Text = "提交";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 278);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.btn_choicedata);
            this.Controls.Add(this.updata_textBox);
            this.Name = "UpDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据信息";
            this.Load += new System.EventHandler(this.UpDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updata_textBox;
        private System.Windows.Forms.Button btn_choicedata;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_updata;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}