namespace FileManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userpwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(638, 192);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(113, 21);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "admin";
            // 
            // txt_userpwd
            // 
            this.txt_userpwd.Location = new System.Drawing.Point(638, 228);
            this.txt_userpwd.Name = "txt_userpwd";
            this.txt_userpwd.PasswordChar = '*';
            this.txt_userpwd.Size = new System.Drawing.Size(113, 21);
            this.txt_userpwd.TabIndex = 3;
            this.txt_userpwd.Text = "admin";
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(597, 299);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(65, 20);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(686, 299);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(65, 20);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_userpwd);
            this.Controls.Add(this.txt_username);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userpwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
    }
}