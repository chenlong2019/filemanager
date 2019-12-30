namespace FileManager
{
    partial class ModifyUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.pwd_txtbox = new System.Windows.Forms.TextBox();
            this.staffnumb_txtbox = new System.Windows.Forms.TextBox();
            this.power_cmd = new System.Windows.Forms.ComboBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户权限：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户编号：";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(146, 53);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(196, 21);
            this.username_txtbox.TabIndex = 4;
            // 
            // pwd_txtbox
            // 
            this.pwd_txtbox.Location = new System.Drawing.Point(146, 131);
            this.pwd_txtbox.Name = "pwd_txtbox";
            this.pwd_txtbox.Size = new System.Drawing.Size(196, 21);
            this.pwd_txtbox.TabIndex = 5;
            // 
            // staffnumb_txtbox
            // 
            this.staffnumb_txtbox.Location = new System.Drawing.Point(146, 290);
            this.staffnumb_txtbox.Name = "staffnumb_txtbox";
            this.staffnumb_txtbox.Size = new System.Drawing.Size(196, 21);
            this.staffnumb_txtbox.TabIndex = 6;
            // 
            // power_cmd
            // 
            this.power_cmd.FormattingEnabled = true;
            this.power_cmd.Location = new System.Drawing.Point(146, 208);
            this.power_cmd.Name = "power_cmd";
            this.power_cmd.Size = new System.Drawing.Size(196, 20);
            this.power_cmd.TabIndex = 7;
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(109, 385);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(294, 385);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 440);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.power_cmd);
            this.Controls.Add(this.staffnumb_txtbox);
            this.Controls.Add(this.pwd_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyUserForm";
            this.Text = "ModifyUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwd_txtbox;
        private System.Windows.Forms.TextBox staffnumb_txtbox;
        private System.Windows.Forms.ComboBox power_cmd;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox username_txtbox;
    }
}