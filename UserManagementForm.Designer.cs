namespace FileManager
{
    partial class UserManagementForm
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
            this.user_register = new System.Windows.Forms.Button();
            this.user_modify = new System.Windows.Forms.Button();
            this.user_delete = new System.Windows.Forms.Button();
            this.user_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            this.SuspendLayout();
            // 
            // user_register
            // 
            this.user_register.Location = new System.Drawing.Point(41, 51);
            this.user_register.Name = "user_register";
            this.user_register.Size = new System.Drawing.Size(75, 23);
            this.user_register.TabIndex = 0;
            this.user_register.Text = "注册";
            this.user_register.UseVisualStyleBackColor = true;
            this.user_register.Click += new System.EventHandler(this.user_register_Click);
            // 
            // user_modify
            // 
            this.user_modify.Location = new System.Drawing.Point(187, 51);
            this.user_modify.Name = "user_modify";
            this.user_modify.Size = new System.Drawing.Size(75, 23);
            this.user_modify.TabIndex = 1;
            this.user_modify.Text = "修改";
            this.user_modify.UseVisualStyleBackColor = true;
            // 
            // user_delete
            // 
            this.user_delete.Location = new System.Drawing.Point(342, 51);
            this.user_delete.Name = "user_delete";
            this.user_delete.Size = new System.Drawing.Size(75, 23);
            this.user_delete.TabIndex = 2;
            this.user_delete.Text = "删除";
            this.user_delete.UseVisualStyleBackColor = true;
            this.user_delete.Click += new System.EventHandler(this.user_delete_Click);
            // 
            // user_table
            // 
            this.user_table.AllowUserToAddRows = false;
            this.user_table.AllowUserToDeleteRows = false;
            this.user_table.AllowUserToResizeColumns = false;
            this.user_table.AllowUserToResizeRows = false;
            this.user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_table.Location = new System.Drawing.Point(41, 98);
            this.user_table.Name = "user_table";
            this.user_table.RowHeadersVisible = false;
            this.user_table.RowTemplate.Height = 23;
            this.user_table.Size = new System.Drawing.Size(682, 320);
            this.user_table.TabIndex = 3;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_table);
            this.Controls.Add(this.user_delete);
            this.Controls.Add(this.user_modify);
            this.Controls.Add(this.user_register);
            this.Name = "UserManagementForm";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user_register;
        private System.Windows.Forms.Button user_modify;
        private System.Windows.Forms.Button user_delete;
        private System.Windows.Forms.DataGridView user_table;
    }
}