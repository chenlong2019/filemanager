namespace FileManager.transfer
{
    partial class DownloadForm
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
            this.download_flp_list = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // download_flp_list
            // 
            this.download_flp_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.download_flp_list.Location = new System.Drawing.Point(0, 0);
            this.download_flp_list.Name = "download_flp_list";
            this.download_flp_list.Size = new System.Drawing.Size(800, 450);
            this.download_flp_list.TabIndex = 0;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.download_flp_list);
            this.Name = "DownloadForm";
            this.Text = "DownloadForm";
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel download_flp_list;
    }
}