namespace FileManager
{
    partial class AddUserForm
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwd2_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.power_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.staffnumb_textBox = new System.Windows.Forms.TextBox();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册用户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(129, 70);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(190, 21);
            this.username_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码";
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(129, 139);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(190, 21);
            this.pwd_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "确认密码";
            // 
            // pwd2_textBox
            // 
            this.pwd2_textBox.Location = new System.Drawing.Point(129, 205);
            this.pwd2_textBox.Name = "pwd2_textBox";
            this.pwd2_textBox.Size = new System.Drawing.Size(190, 21);
            this.pwd2_textBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "权限设置";
            // 
            // power_cmb
            // 
            this.power_cmb.FormattingEnabled = true;
            this.power_cmb.Location = new System.Drawing.Point(129, 264);
            this.power_cmb.Name = "power_cmb";
            this.power_cmb.Size = new System.Drawing.Size(190, 20);
            this.power_cmb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "职员编号";
            // 
            // staffnumb_textBox
            // 
            this.staffnumb_textBox.Location = new System.Drawing.Point(129, 327);
            this.staffnumb_textBox.Name = "staffnumb_textBox";
            this.staffnumb_textBox.Size = new System.Drawing.Size(190, 21);
            this.staffnumb_textBox.TabIndex = 10;
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(129, 395);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(75, 23);
            this.btn_adduser.TabIndex = 11;
            this.btn_adduser.Text = "注册";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(244, 395);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 451);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.staffnumb_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.power_cmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pwd2_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwd_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "注册用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwd2_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox power_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox staffnumb_textBox;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_close;
    }
}