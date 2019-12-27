namespace FileManager
{
    partial class MessageForm
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
            this.label_msg = new System.Windows.Forms.Label();
            this.cpw_ok = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpw_ocancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_msg
            // 
            this.label_msg.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_msg.Location = new System.Drawing.Point(73, 95);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(329, 118);
            this.label_msg.TabIndex = 1;
            this.label_msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cpw_ok
            // 
            this.cpw_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cpw_ok.FlatAppearance.BorderSize = 0;
            this.cpw_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpw_ok.Location = new System.Drawing.Point(52, 232);
            this.cpw_ok.Name = "cpw_ok";
            this.cpw_ok.Size = new System.Drawing.Size(176, 58);
            this.cpw_ok.TabIndex = 6;
            this.cpw_ok.Text = "确认";
            this.cpw_ok.UseVisualStyleBackColor = true;
            this.cpw_ok.Click += new System.EventHandler(this.Cpw_ok_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(0, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(486, 29);
            this.label.TabIndex = 0;
            this.label.Text = "提示";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cpw_ocancel);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.cpw_ok);
            this.panel1.Controls.Add(this.label_msg);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 315);
            this.panel1.TabIndex = 8;
            // 
            // cpw_ocancel
            // 
            this.cpw_ocancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cpw_ocancel.FlatAppearance.BorderSize = 0;
            this.cpw_ocancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpw_ocancel.Location = new System.Drawing.Point(256, 232);
            this.cpw_ocancel.Name = "cpw_ocancel";
            this.cpw_ocancel.Size = new System.Drawing.Size(176, 58);
            this.cpw_ocancel.TabIndex = 7;
            this.cpw_ocancel.Text = "取消";
            this.cpw_ocancel.UseVisualStyleBackColor = true;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 317);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassWordForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.Button cpw_ok;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cpw_ocancel;
    }
}