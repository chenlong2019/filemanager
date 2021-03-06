﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileUpload;

namespace FileManager.transfer
{
    public partial class FlowListItem : UserControl
    {
        // 定义委托更新UI
        public delegate void TranStateDelegate(TranState tranState);
        public TranStateDelegate tranStateDelegate;
        private readonly ImageInfoModel imageInfoModel;
        private readonly FileTransmitModel transmitModel;
        public FlowListItem(FileUpload.FileTransmitModel transmitModel)
        {
            InitializeComponent();
            tranStateDelegate = new TranStateDelegate(RefershUI);
            this.transmitModel = transmitModel;
            this.lblname.Text = transmitModel.Ti_Filename;
        }

        public FlowListItem(ImageInfoModel imageInfoModel)
        {
            InitializeComponent();
            tranStateDelegate = new TranStateDelegate(RefershUI);
            this.imageInfoModel = imageInfoModel;
            this.lblname.Text = imageInfoModel.Ii_Filename;
        }

        /// <summary>
        /// 刷新UI
        /// </summary>
        public void RefershUI(TranState tranState)
        {
            this.progressBar1.Value = tranState.PbValue;
            if (GetFileTransmitModel() != null)
            {
                this.lblname.Text = GetFileTransmitModel().Ti_Filename;
            }
            else if(GetImageInfoModel() != null)
            {
                this.lblname.Text = GetImageInfoModel().Ii_Filename;
            }
            else
            {
                this.lblname.Text ="未知";
            }
            
            this.lblState.Text = tranState.LblState;
            this.lblSpeed.Text = tranState.LblSpeed;
            this.lblSize.Text = tranState.LblSize;
        }

        public FileTransmitModel GetFileTransmitModel()
        {
            return this.transmitModel;
        }
        public ImageInfoModel GetImageInfoModel()
        {
            return this.imageInfoModel;
        }
    }
}
