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
            // 
            // btn_mydown
            // 
            this.btn_mydown.Location = new System.Drawing.Point(192, 41);
            this.btn_mydown.Name = "btn_mydown";
            this.btn_mydown.Size = new System.Drawing.Size(75, 23);
            this.btn_mydown.TabIndex = 1;
            this.btn_mydown.Text = "下载记录";
            this.btn_mydown.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(670, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // MyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_mydown);
            this.Controls.Add(this.btn_application);
            this.Name = "MyDataForm";
            this.Text = "我的数据管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_application;
        private System.Windows.Forms.Button btn_mydown;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}