using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUpload
{
    /// <summary>
    /// 文件传输模板
    /// </summary>
    public class FileTransmitModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        private string ti_ID;
        /// <summary>
        /// 传输状态（上传/下载）
        /// </summary>
        private string ti_State;
        /// <summary>
        /// 地址
        /// </summary>
        private string ti_Url;
        /// <summary>
        /// 文件名称
        /// </summary>
        private string ti_Filename;
        /// <summary>
        /// 文件时间
        /// </summary>
        private string ti_FileTime;
        /// <summary>
        /// 传输时间
        /// </summary>
        private string ti_UploadTime;
        /// <summary>
        ///  文件大小
        /// </summary>
        private string ti_FileSize;
        /// <summary>
        /// 文件存储路径
        /// </summary>
        private string ti_Path;

        public string Ti_ID { get => ti_ID; set => ti_ID = value; }
        public string Ti_State { get => ti_State; set => ti_State = value; }
        public string Ti_Url { get => ti_Url; set => ti_Url = value; }
        public string Ti_Filename { get => ti_Filename; set => ti_Filename = value; }
        public string Ti_FileTime { get => ti_FileTime; set => ti_FileTime = value; }
        public string Ti_UploadTime { get => ti_UploadTime; set => ti_UploadTime = value; }
        public string Ti_FileSize { get => ti_FileSize; set => ti_FileSize = value; }
        public string Ti_Path { get => ti_Path; set => ti_Path = value; }
    }
}
