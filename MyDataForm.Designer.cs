namespace FileManager
{
    partial class MyDataForm
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
            this.btn_application = new System.Windows.Forms.Button();
            this.btn_mydown = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_audited = new System.Windows.Forms.Button();
            this.btn_Agree = new System.Windows.Forms.Button();
            this.btn_refuse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_application
            // 
            this.btn_application.Location = new System.Drawing.Point(56, 41);
            this.btn_application.Name = "btn_application";
            this.btn_application.Size = new System.Drawing.Size(75, 23);
            this.btn_application.TabIndex = 0;
            this.btn_application.Text = "待审核";
            this.btn_application.UseVisualStyleBackColor = true;
            this.btn_application.Click += new System.EventHandler(this.btn_application_Click);
            // 
            // btn_mydown
            // 
            this.btn_mydown.Location = new System.Drawing.Point(291, 41);
            this.btn_mydown.Name = "btn_mydown";
            this.btn_mydown.Size = new System.Drawing.Size(75, 23);
            this.btn_mydown.TabIndex = 1;
            this.btn_mydown.Text = "下载记录";
            this.btn_mydown.UseVisualStyleBackColor = true;
            this.btn_mydown.Click += new System.EventHandler(this.btn_mydown_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(670, 336);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_audited
            // 
            this.btn_audited.Location = new System.Drawing.Point(165, 41);
            this.btn_audited.Name = "btn_audited";
            this.btn_audited.Size = new System.Drawing.Size(75, 23);
            this.btn_audited.TabIndex = 3;
            this.btn_audited.Text = "已审核";
            this.btn_audited.UseVisualStyleBackColor = true;
            this.btn_audited.Click += new System.EventHandler(this.btn_audited_Click);
            // 
            // btn_Agree
            // 
            this.btn_Agree.Location = new System.Drawing.Point(417, 41);
            this.btn_Agree.Name = "btn_Agree";
            this.btn_Agree.Size = new System.Drawing.Size(75, 23);
            this.btn_Agree.TabIndex = 4;
            this.btn_Agree.Text = "同意";
            this.btn_Agree.UseVisualStyleBackColor = true;
            this.btn_Agree.Click += new System.EventHandler(this.btn_Agree_Click);
            // 
            // btn_refuse
            // 
            this.btn_refuse.Location = new System.Drawing.Point(539, 41);
            this.btn_refuse.Name = "btn_refuse";
            this.btn_refuse.Size = new System.Drawing.Size(75, 23);
            this.btn_refuse.TabIndex = 5;
            this.btn_refuse.Text = "拒绝";
            this.btn_refuse.UseVisualStyleBackColor = true;
            this.btn_refuse.Click += new System.EventHandler(this.btn_refuse_Click);
            // 
            // MyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 449);
            this.Controls.Add(this.btn_refuse);
            this.Controls.Add(this.btn_Agree);
            this.Controls.Add(this.btn_audited);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_mydown);
            this.Controls.Add(this.btn_application);
            this.Name = "MyDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的数据管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_application;
        private System.Windows.Forms.Button btn_mydown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_audited;
        private System.Windows.Forms.Button btn_Agree;
        private System.Windows.Forms.Button btn_refuse;
    }
}