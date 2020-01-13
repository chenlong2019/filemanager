using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class DataInfoForm : Form
    {
        private ImageInfoModel imageInfoModel;

        public DataInfoForm(ImageInfoModel imageInfoModel)
        {
            InitializeComponent();
            this.imageInfoModel = imageInfoModel;
            imageinfodisplay();
        }
        public void imageinfodisplay()
        {
            try
            {
                ii_filename.Text = imageInfoModel.Ii_Filename.ToString();
                ii_satelliteIdentification.Text = imageInfoModel.Ii_SatelliteIdentification.ToString();
                ii_modelname.Text = imageInfoModel.Ii_Modelname.ToString();
                ii_productname.Text = imageInfoModel.Ii_Productname.ToString();
                ii_processinglevel.Text = imageInfoModel.Ii_Processinglevel.ToString();
                ii_starttime.Text = imageInfoModel.Ii_Starttime.ToString();
                ii_endtime.Text = imageInfoModel.Ii_Endtime.ToString();
                ii_missiondatatakeIdentifier.Text = imageInfoModel.Ii_MissiondatatakeIdentifier.ToString();
                ii_productuniqueIdentificationcode.Text = imageInfoModel.Ii_ProductuniqueIdentificationcode.ToString();
                ii_uploadtime.Text = imageInfoModel.Ii_Uploadtime.ToString();
                ii_filesize.Text = imageInfoModel.Ii_Filesize.ToString();
                ii_absoluteorbit.Text = imageInfoModel.Ii_Absoluteorbit.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("没有详细信息");
            }
            
        }
       
    }
}
