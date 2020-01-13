namespace FileManager
{
    partial class ListResultPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListResultPanel));
            this.lrp_ip_1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.lrp_btn_download = new System.Windows.Forms.Button();
            this.lrp_label_endtime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lrp_label_starttime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lrp_label_coordinate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lrp_label_filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lrp_ip_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrp_ip_1
            // 
            this.lrp_ip_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lrp_ip_1.Image = ((System.Drawing.Image)(resources.GetObject("lrp_ip_1.Image")));
            this.lrp_ip_1.Location = new System.Drawing.Point(0, 0);
            this.lrp_ip_1.Name = "lrp_ip_1";
            this.lrp_ip_1.Size = new System.Drawing.Size(154, 196);
            this.lrp_ip_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lrp_ip_1.TabIndex = 0;
            this.lrp_ip_1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lrp_ip_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.lrp_btn_download);
            this.splitContainer1.Panel2.Controls.Add(this.lrp_label_endtime);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.lrp_label_starttime);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lrp_label_coordinate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lrp_label_filename);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(467, 196);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "详细";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lrp_btn_download
            // 
            this.lrp_btn_download.Location = new System.Drawing.Point(178, 160);
            this.lrp_btn_download.Name = "lrp_btn_download";
            this.lrp_btn_download.Size = new System.Drawing.Size(87, 31);
            this.lrp_btn_download.TabIndex = 8;
            this.lrp_btn_download.Text = "下载";
            this.lrp_btn_download.UseVisualStyleBackColor = true;
            this.lrp_btn_download.Click += new System.EventHandler(this.download_Click);
            // 
            // lrp_label_endtime
            // 
            this.lrp_label_endtime.AutoSize = true;
            this.lrp_label_endtime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrp_label_endtime.Location = new System.Drawing.Point(97, 130);
            this.lrp_label_endtime.Name = "lrp_label_endtime";
            this.lrp_label_endtime.Size = new System.Drawing.Size(199, 19);
            this.lrp_label_endtime.TabIndex = 7;
            this.lrp_label_endtime.Text = "2019-12-26 19:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(5, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "结束时间：";
            // 
            // lrp_label_starttime
            // 
            this.lrp_label_starttime.AutoSize = true;
            this.lrp_label_starttime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrp_label_starttime.Location = new System.Drawing.Point(97, 89);
            this.lrp_label_starttime.Name = "lrp_label_starttime";
            this.lrp_label_starttime.Size = new System.Drawing.Size(199, 19);
            this.lrp_label_starttime.TabIndex = 5;
            this.lrp_label_starttime.Text = "2019-12-26 19:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "开始时间：";
            // 
            // lrp_label_coordinate
            // 
            this.lrp_label_coordinate.AutoSize = true;
            this.lrp_label_coordinate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrp_label_coordinate.Location = new System.Drawing.Point(97, 50);
            this.lrp_label_coordinate.Name = "lrp_label_coordinate";
            this.lrp_label_coordinate.Size = new System.Drawing.Size(149, 19);
            this.lrp_label_coordinate.TabIndex = 3;
            this.lrp_label_coordinate.Text = "33.258,133.333";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "中心坐标：";
            // 
            // lrp_label_filename
            // 
            this.lrp_label_filename.AutoSize = true;
            this.lrp_label_filename.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrp_label_filename.Location = new System.Drawing.Point(97, 9);
            this.lrp_label_filename.Name = "lrp_label_filename";
            this.lrp_label_filename.Size = new System.Drawing.Size(79, 19);
            this.lrp_label_filename.TabIndex = 1;
            this.lrp_label_filename.Text = "MODEL-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "影像名称：";
            // 
            // ListResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListResultPanel";
            this.Size = new System.Drawing.Size(467, 196);
            ((System.ComponentModel.ISupportInitialize)(this.lrp_ip_1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lrp_ip_1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button lrp_btn_download;
        private System.Windows.Forms.Label lrp_label_endtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lrp_label_starttime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lrp_label_coordinate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lrp_label_filename;
        private System.Windows.Forms.Label label1;
    }
}
