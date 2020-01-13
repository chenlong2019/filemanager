namespace FileManager.transfer
{
    partial class FinishedListItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedListItem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fli_label_filename = new System.Windows.Forms.Label();
            this.fli_label_filesize = new System.Windows.Forms.Label();
            this.fli_label_time = new System.Windows.Forms.Label();
            this.fli_label_state = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fli_label_filename
            // 
            this.fli_label_filename.AutoSize = true;
            this.fli_label_filename.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fli_label_filename.Location = new System.Drawing.Point(216, 36);
            this.fli_label_filename.Name = "fli_label_filename";
            this.fli_label_filename.Size = new System.Drawing.Size(69, 20);
            this.fli_label_filename.TabIndex = 1;
            this.fli_label_filename.Text = "label1";
            // 
            // fli_label_filesize
            // 
            this.fli_label_filesize.AutoSize = true;
            this.fli_label_filesize.Location = new System.Drawing.Point(227, 107);
            this.fli_label_filesize.Name = "fli_label_filesize";
            this.fli_label_filesize.Size = new System.Drawing.Size(41, 12);
            this.fli_label_filesize.TabIndex = 2;
            this.fli_label_filesize.Text = "label2";
            // 
            // fli_label_time
            // 
            this.fli_label_time.AutoSize = true;
            this.fli_label_time.Location = new System.Drawing.Point(387, 67);
            this.fli_label_time.Name = "fli_label_time";
            this.fli_label_time.Size = new System.Drawing.Size(41, 12);
            this.fli_label_time.TabIndex = 3;
            this.fli_label_time.Text = "label3";
            // 
            // fli_label_state
            // 
            this.fli_label_state.AutoSize = true;
            this.fli_label_state.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fli_label_state.Location = new System.Drawing.Point(535, 63);
            this.fli_label_state.Name = "fli_label_state";
            this.fli_label_state.Size = new System.Drawing.Size(56, 16);
            this.fli_label_state.TabIndex = 4;
            this.fli_label_state.Text = "label4";
            // 
            // FinishedListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fli_label_state);
            this.Controls.Add(this.fli_label_time);
            this.Controls.Add(this.fli_label_filesize);
            this.Controls.Add(this.fli_label_filename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FinishedListItem";
            this.Size = new System.Drawing.Size(653, 168);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fli_label_filename;
        private System.Windows.Forms.Label fli_label_filesize;
        private System.Windows.Forms.Label fli_label_time;
        private System.Windows.Forms.Label fli_label_state;
    }
}
