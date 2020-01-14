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
            this.data_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_datamodify
            // 
            this.btn_datamodify.Location = new System.Drawing.Point(58, 12);
            this.btn_datamodify.Name = "btn_datamodify";
            this.btn_datamodify.Size = new System.Drawing.Size(75, 23);
            this.btn_datamodify.TabIndex = 0;
            this.btn_datamodify.Text = "修改";
            this.btn_datamodify.UseVisualStyleBackColor = true;
            // 
            // btn_datadelete
            // 
            this.btn_datadelete.Location = new System.Drawing.Point(234, 12);
            this.btn_datadelete.Name = "btn_datadelete";
            this.btn_datadelete.Size = new System.Drawing.Size(75, 23);
            this.btn_datadelete.TabIndex = 1;
            this.btn_datadelete.Text = "删除";
            this.btn_datadelete.UseVisualStyleBackColor = true;
            this.btn_datadelete.Click += new System.EventHandler(this.btn_datadelete_Click);
            // 
            // data_table
            // 
            this.data_table.AllowUserToAddRows = false;
            this.data_table.AllowUserToResizeColumns = false;
            this.data_table.AllowUserToResizeRows = false;
            this.data_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table.Location = new System.Drawing.Point(12, 41);
            this.data_table.Name = "data_table";
            this.data_table.ReadOnly = true;
            this.data_table.RowHeadersVisible = false;
            this.data_table.RowTemplate.Height = 23;
            this.data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_table.Size = new System.Drawing.Size(1390, 487);
            this.data_table.TabIndex = 2;
            this.data_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_table_CellClick);
            // 
            // DataMangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 540);
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.btn_datadelete);
            this.Controls.Add(this.btn_datamodify);
            this.Name = "DataMangerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据管理";
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_datamodify;
        private System.Windows.Forms.Button btn_datadelete;
        private System.Windows.Forms.DataGridView data_table;
    }
}