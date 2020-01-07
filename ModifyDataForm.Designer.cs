namespace FileManager
{
    partial class ModifyDataForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.staffnum_txt = new System.Windows.Forms.TextBox();
            this.people_txt = new System.Windows.Forms.TextBox();
            this.data_txt = new System.Windows.Forms.TextBox();
            this.satellite_cmb = new System.Windows.Forms.ComboBox();
            this.orbit_cmb = new System.Windows.Forms.ComboBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.datatime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "职员编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "入库人员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "入库时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "拍摄卫星：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "拍摄轨道：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "入库数据：";
            // 
            // staffnum_txt
            // 
            this.staffnum_txt.Location = new System.Drawing.Point(141, 31);
            this.staffnum_txt.Name = "staffnum_txt";
            this.staffnum_txt.Size = new System.Drawing.Size(174, 21);
            this.staffnum_txt.TabIndex = 6;
            // 
            // people_txt
            // 
            this.people_txt.Location = new System.Drawing.Point(141, 79);
            this.people_txt.Name = "people_txt";
            this.people_txt.Size = new System.Drawing.Size(174, 21);
            this.people_txt.TabIndex = 7;
            // 
            // data_txt
            // 
            this.data_txt.Location = new System.Drawing.Point(141, 310);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(174, 21);
            this.data_txt.TabIndex = 9;
            // 
            // satellite_cmb
            // 
            this.satellite_cmb.FormattingEnabled = true;
            this.satellite_cmb.Location = new System.Drawing.Point(141, 195);
            this.satellite_cmb.Name = "satellite_cmb";
            this.satellite_cmb.Size = new System.Drawing.Size(174, 20);
            this.satellite_cmb.TabIndex = 10;
            // 
            // orbit_cmb
            // 
            this.orbit_cmb.FormattingEnabled = true;
            this.orbit_cmb.Location = new System.Drawing.Point(141, 257);
            this.orbit_cmb.Name = "orbit_cmb";
            this.orbit_cmb.Size = new System.Drawing.Size(174, 20);
            this.orbit_cmb.TabIndex = 11;
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(68, 371);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 12;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(221, 371);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // datatime
            // 
            this.datatime.Location = new System.Drawing.Point(141, 136);
            this.datatime.Name = "datatime";
            this.datatime.Size = new System.Drawing.Size(174, 21);
            this.datatime.TabIndex = 14;
            // 
            // ModifyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 437);
            this.Controls.Add(this.datatime);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.orbit_cmb);
            this.Controls.Add(this.satellite_cmb);
            this.Controls.Add(this.data_txt);
            this.Controls.Add(this.people_txt);
            this.Controls.Add(this.staffnum_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox staffnum_txt;
        private System.Windows.Forms.TextBox people_txt;
        private System.Windows.Forms.TextBox data_txt;
        private System.Windows.Forms.ComboBox satellite_cmb;
        private System.Windows.Forms.ComboBox orbit_cmb;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker datatime;
    }
}