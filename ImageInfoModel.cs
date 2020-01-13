using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class ImageInfoModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        private string ii_ID;
        
        /// <summary>
        /// 文件名称
        /// </summary>
        private string ii_Filename;
        
        /// <summary>
        /// 卫星标识
        /// </summary>
        private string ii_SatelliteIdentification;
        
        /// <summary>
        /// 模式名称
        /// </summary>
        private string ii_Modelname;
        

        /// <summary>
        /// 产品名称及分辨率
        /// </summary>
        private string ii_Productname;

        /// <summary>
        /// 处理级别,产品类型,极化方式
        /// </summary>
        private string ii_Processinglevel;
        
        ///  /// <summary>
        ///  产品开始时间
        /// </summary>
        private string ii_Starttime;
       
        /// <summary>
        /// 产品结束时间
        /// </summary>
        private string ii_Endtime;
        
        /// <summary>
        /// 绝对轨道号
        /// </summary>
        private string ii_Absoluteorbit;
        
        /// <summary>
        /// 数据利用标识符
        /// </summary>
        private string ii_MissiondatatakeIdentifier;
        
        /// <summary>
        /// 产品唯一识别码
        /// </summary>
        private string ii_ProductuniqueIdentificationcode;


        /// <summary>
        /// 文件存储路径
        /// </summary>
        private string ii_Path;


        /// <summary>
        /// 上传员工
        /// </summary>
        private string ii_Username;


        /// <summary>
        /// 上传文件大小
        /// </summary>
        private string ii_Filesize;


        /// <summary>
        /// 上传职员编号
        /// </summary>
        private string ii_Staffnumber;


        /// <summary>
        /// 上传文件时间
        /// </summary>
        private string ii_Uploadtime;

        /// <summary>
        /// 中心经度
        /// </summary>
        private String ii_Log;

        /// <summary>
        /// 中心纬度
        /// </summary>
        private String ii_Lat;

        public string Ii_ID { get => ii_ID; set => ii_ID = value; }
        public string Ii_Filename { get => ii_Filename; set => ii_Filename = value; }
        public string Ii_SatelliteIdentification { get => ii_SatelliteIdentification; set => ii_SatelliteIdentification = value; }
        public string Ii_Modelname { get => ii_Modelname; set => ii_Modelname = value; }
        public string Ii_Productname { get => ii_Productname; set => ii_Productname = value; }
        public string Ii_Processinglevel { get => ii_Processinglevel; set => ii_Processinglevel = value; }
        public string Ii_Starttime { get => ii_Starttime; set => ii_Starttime = value; }
        public string Ii_Endtime { get => ii_Endtime; set => ii_Endtime = value; }
        public string Ii_Absoluteorbit { get => ii_Absoluteorbit; set => ii_Absoluteorbit = value; }
        public string Ii_MissiondatatakeIdentifier { get => ii_MissiondatatakeIdentifier; set => ii_MissiondatatakeIdentifier = value; }
        public string Ii_ProductuniqueIdentificationcode { get => ii_ProductuniqueIdentificationcode; set => ii_ProductuniqueIdentificationcode = value; }
        public string Ii_Path { get => ii_Path; set => ii_Path = value; }
        public string Ii_Username { get => ii_Username; set => ii_Username = value; }
        public string Ii_Filesize { get => ii_Filesize; set => ii_Filesize = value; }
        public string Ii_Staffnumber { get => ii_Staffnumber; set => ii_Staffnumber = value; }
        public string Ii_Uploadtime { get => ii_Uploadtime; set => ii_Uploadtime = value; }
        public string Ii_Log { get => ii_Log; set => ii_Log = value; }
        public string Ii_Lat { get => ii_Lat; set => ii_Lat = value; }
    }
}
