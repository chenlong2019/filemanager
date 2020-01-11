namespace FileManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_REMOTE = new System.Windows.Forms.Button();
            this.btn_MODISL1B = new System.Windows.Forms.Button();
            this.btn_DEM = new System.Windows.Forms.Button();
            this.btn_LANDSAT = new System.Windows.Forms.Button();
            this.btn_MODIS = new System.Windows.Forms.Button();
            this.btn_MODISCN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.info_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_REMOTE
            // 
            this.btn_REMOTE.Location = new System.Drawing.Point(80, 12);
            this.btn_REMOTE.Name = "btn_REMOTE";
            this.btn_REMOTE.Size = new System.Drawing.Size(117, 123);
            this.btn_REMOTE.TabIndex = 0;
            this.btn_REMOTE.UseVisualStyleBackColor = true;
            // 
            // btn_MODISL1B
            // 
            this.btn_MODISL1B.Location = new System.Drawing.Point(325, 197);
            this.btn_MODISL1B.Name = "btn_MODISL1B";
            this.btn_MODISL1B.Size = new System.Drawing.Size(117, 123);
            this.btn_MODISL1B.TabIndex = 4;
            this.btn_MODISL1B.UseVisualStyleBackColor = true;
            // 
            // btn_DEM
            // 
            this.btn_DEM.Location = new System.Drawing.Point(558, 197);
            this.btn_DEM.Name = "btn_DEM";
            this.btn_DEM.Size = new System.Drawing.Size(117, 123);
            this.btn_DEM.TabIndex = 5;
            this.btn_DEM.UseVisualStyleBackColor = true;
            // 
            // btn_LANDSAT
            // 
            this.btn_LANDSAT.Location = new System.Drawing.Point(325, 12);
            this.btn_LANDSAT.Name = "btn_LANDSAT";
            this.btn_LANDSAT.Size = new System.Drawing.Size(117, 123);
            this.btn_LANDSAT.TabIndex = 8;
            this.btn_LANDSAT.UseVisualStyleBackColor = true;
            // 
            // btn_MODIS
            // 
            this.btn_MODIS.Location = new System.Drawing.Point(558, 12);
            this.btn_MODIS.Name = "btn_MODIS";
            this.btn_MODIS.Size = new System.Drawing.Size(117, 123);
            this.btn_MODIS.TabIndex = 9;
            this.btn_MODIS.UseVisualStyleBackColor = true;
            // 
            // btn_MODISCN
            // 
            this.btn_MODISCN.Location = new System.Drawing.Point(80, 197);
            this.btn_MODISCN.Name = "btn_MODISCN";
            this.btn_MODISCN.Size = new System.Drawing.Size(117, 123);
            this.btn_MODISCN.TabIndex = 10;
            this.btn_MODISCN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(78, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "遥感数据引擎";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(323, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "LANDSAT系列数据";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(556, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "MODIS系列数据";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(78, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "MODIS中国合成产品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(323, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "MODISL1B标准产品";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(556, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "DEM数字高程数据";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(58, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "最新动态";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // info_display
            // 
            this.info_display.Location = new System.Drawing.Point(80, 415);
            this.info_display.Name = "info_display";
            this.info_display.Size = new System.Drawing.Size(623, 118);
            this.info_display.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.info_display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MODISCN);
            this.Controls.Add(this.btn_MODIS);
            this.Controls.Add(this.btn_LANDSAT);
            this.Controls.Add(this.btn_DEM);
            this.Controls.Add(this.btn_MODISL1B);
            this.Controls.Add(this.btn_REMOTE);
            this.Name = "MainForm";
            this.Text = "首页";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_REMOTE;
        private System.Windows.Forms.Button btn_MODISL1B;
        private System.Windows.Forms.Button btn_DEM;
        private System.Windows.Forms.Button btn_LANDSAT;
        private System.Windows.Forms.Button btn_MODIS;
        private System.Windows.Forms.Button btn_MODISCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label info_display;
    }
}