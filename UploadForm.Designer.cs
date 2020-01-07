namespace FileManager
{
    partial class UploadForm
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.dataDGV = new System.Windows.Forms.DataGridView();
            this.my_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(12, 21);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "添加文件";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // dataDGV
            // 
            this.dataDGV.AllowUserToAddRows = false;
            this.dataDGV.AllowUserToResizeColumns = false;
            this.dataDGV.AllowUserToResizeRows = false;
            this.dataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDGV.Location = new System.Drawing.Point(12, 58);
            this.dataDGV.Name = "dataDGV";
            this.dataDGV.ReadOnly = true;
            this.dataDGV.RowTemplate.Height = 23;
            this.dataDGV.Size = new System.Drawing.Size(776, 380);
            this.dataDGV.TabIndex = 1;
            // 
            // my_data
            // 
            this.my_data.Location = new System.Drawing.Point(153, 21);
            this.my_data.Name = "my_data";
            this.my_data.Size = new System.Drawing.Size(102, 23);
            this.my_data.TabIndex = 2;
            this.my_data.Text = "我已上传文件";
            this.my_data.UseVisualStyleBackColor = true;
            this.my_data.Click += new System.EventHandler(this.my_data_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.my_data);
            this.Controls.Add(this.dataDGV);
            this.Controls.Add(this.btn_upload);
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传文件";
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.DataGridView dataDGV;
        private System.Windows.Forms.Button my_data;
    }
}