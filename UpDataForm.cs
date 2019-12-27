using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using MySql.Data.MySqlClient;

namespace FileManager
{
    public partial class UpDataForm : Form
    {
        public UpDataForm()
        {
            InitializeComponent();
        }

        public static string serverIP = ConfigurationManager.ConnectionStrings["serverIP"].ToString();
        public static string serverUser = "jiutian";
        public static string serverPWD = "jiutian";
        public static string localDataPath;
        public static string localDataName;
        public static string directory;

        private int RasterSaveAs(IRaster raster, string fileName)//将栅格信息保存到指定路径下
        {
            int result = 0;
            try
            {
                IWorkspaceFactory pWKSF = new RasterWorkspaceFactoryClass();
                IWorkspace pWorkspace = pWKSF.OpenFromFile(System.IO.Path.GetDirectoryName(fileName), 0);
                ISaveAs pSaveAs = raster as ISaveAs;
                pSaveAs.SaveAs(System.IO.Path.GetFileName(fileName), pWorkspace, "TIFF");
                result = 0;
            }
            catch (Exception)
            {
                result = 1;
            }
            return result;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choicedata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "所有文件(*.*)|*.*";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                localDataPath = openFile.FileName;
                updata_textBox.Text = openFile.FileName;
                localDataName = openFile.SafeFileName;
            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            directory = localDataName;
            string sqlData = localDataName;
            int sqlTime = time.Year * 10000 + time.Month * 100 + time.Day;
            if (updata_textBox.Text.Length == 0)
            {
                MessageBox.Show("传入的数据不能为空");
                return;
            }

            string staff_number = "select staff_number from user";
            string people = "select people from user";
            string s = "insert into Storage values('" + staff_number + "', '" + people + "', '" + sqlTime + "','" + satellite.Text.Trim() + "', '" + orbit.Text.Trim() + "', '" + sqlData + "','" + datatype + "')";

            //读取上传栅格数据的属性信息
            IWorkspaceFactory myWorkFact = new RasterWorkspaceFactoryClass();
            string rasterData = updata_textBox.Text;
            IRasterWorkspace myRasterWorkspce = myWorkFact.OpenFromFile(System.IO.Path.GetDirectoryName(rasterData), 0) as IRasterWorkspace;
            IRasterDataset3 myRasterDataset3 = myRasterWorkspce.OpenRasterDataset(System.IO.Path.GetFileName(rasterData)) as IRasterDataset3;
            IRasterLayer myRasterLayer = new RasterLayerClass();
            myRasterLayer.CreateFromDataset(myRasterDataset3);
            IRasterProps myRasterProp = myRasterLayer.Raster as IRasterProps;
            //行数
            string row = myRasterProp.Height.ToString();
            //列数
            string clonmun = myRasterProp.Width.ToString();
            //像素类型
            string pixeltype = myRasterProp.PixelType.ToString();
            //波段数
            string band = (myRasterLayer.Raster as IRasterBandCollection).Count.ToString();
            //压缩类型
            string compressionType = myRasterDataset3.CompressionType.ToString();
            //四个角点的最大最小坐标
            string XMax = myRasterProp.Extent.XMax.ToString();
            string XMin = myRasterProp.Extent.XMin.ToString();
            string YMax = myRasterProp.Extent.YMax.ToString();
            string YMin = myRasterProp.Extent.YMin.ToString();
            //四个角点的坐标
            string LowerLeftX = myRasterProp.Extent.LowerLeft.X.ToString();
            string LowerLeftY = myRasterProp.Extent.LowerLeft.Y.ToString();
            string UpperLeftX = myRasterProp.Extent.UpperLeft.X.ToString();
            string UpperLeftY = myRasterProp.Extent.UpperLeft.Y.ToString();
            string LowerRightX = myRasterProp.Extent.LowerRight.X.ToString();
            string LowerRightY = myRasterProp.Extent.LowerRight.Y.ToString();
            string UpperRightX = myRasterProp.Extent.UpperRight.X.ToString();
            string UpperRightY = myRasterProp.Extent.UpperRight.Y.ToString();
            //X和Y坐标的格网分辨率
            string pixelX = myRasterProp.MeanCellSize().X.ToString();
            string pixelY = myRasterProp.MeanCellSize().Y.ToString();

            //参考坐标信息

            ISpatialReference pSpatialReference = myRasterProp.SpatialReference;
            //空间参考
            string spatial = pSpatialReference.Name.ToString();

            //投影坐标系

            IProjectedCoordinateSystem pcs = pSpatialReference as IProjectedCoordinateSystem;
            string coordinate = "";
            string datumplan = "";
            string spheroid = "";
            string projection = "";
            string centralMeridian = "";
            string coordinateUnit = "";
            string scaleFactor = "";
            string sensorType = "";
            string format = "";

            //地理坐标系
            if (pcs != null)
            {
                coordinate = pcs.GeographicCoordinateSystem.Name;
                //基准面
                datumplan = pcs.GeographicCoordinateSystem.Datum.Name;
                //参考椭球
                spheroid = pcs.GeographicCoordinateSystem.Datum.Spheroid.Name;
                //投影坐标系
                projection = pcs.Projection.Name;
                //中央子午线
                centralMeridian = pcs.get_CentralMeridian(true).ToString();
                //线性单位
                coordinateUnit = pcs.CoordinateUnit.Name.ToString();
                //尺度因子
                scaleFactor = pcs.ScaleFactor.ToString();
                //传感器型号
                sensorType = myRasterDataset3.SensorType.ToString();
                //数据类型
                format = myRasterDataset3.Format.ToString();

            }
            //写入数据库
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(LoginForm.connString);
                conn.Open();
                MySqlCommand comm = new MySqlCommand("insert into raster_info values('" + sensorType + "','" + format + "','" + row + "','" + clonmun + "','" + pixeltype + "','" + band + "','" + compressionType + "','" + XMax + "','" + XMin + "','" + YMax + "','" + YMin + "','" + LowerLeftX + "','" + LowerLeftY + "','" + UpperLeftX + "','" + UpperLeftY + "','" + LowerRightX + "','" + LowerRightY + "','" + UpperRightX + "','" + UpperRightY + "','" + pixelX + "','" + pixelY + "','" + spatial + "','" + coordinate + "','" + datumplan + "','" + spheroid + "','" + projection + "','" + centralMeridian + "','" + coordinateUnit + "','" + scaleFactor + "')", conn);
                comm.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
