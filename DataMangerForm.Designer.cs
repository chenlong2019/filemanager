namespace FileManager
{
    partial class DataMangerForm
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
            this.btn_datamodify = new System.Windows.Forms.Button();
            this.btn_datadelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_datamodify
            // 
            this.btn_datamodify.Location = new System.Drawing.Point(48, 48);
            this.btn_datamodify.Name = "btn_datamodify";
            this.btn_datamodify.Size = new System.Drawing.Size(75, 23);
            this.btn_datamodify.TabIndex = 0;
            this.btn_datamodify.Text = "修改";
            this.btn_datamodify.UseVisualStyleBackColor = true;
            // 
            // btn_datadelete
            // 
            this.btn_datadelete.Location = new System.Drawing.Point(235, 48);
            this.btn_datadelete.Name = "btn_datadelete";
            this.btn_datadelete.Size = new System.Drawing.Size(75, 23);
            this.btn_datadelete.TabIndex = 1;
            this.btn_datadelete.Text = "删除";
            this.btn_datadelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(599, 316);
            this.dataGridView1.TabIndex = 2;
            // 
            // DataMangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_datadelete);
            this.Controls.Add(this.btn_datamodify);
            this.Name = "DataMangerForm";
            this.Text = "数据管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_datamodify;
        private System.Windows.Forms.Button btn_datadelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}