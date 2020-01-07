using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUpload
{
    /// <summary>
    /// Class <c>TranState</c>
    /// 传输状态
    /// <param name="state">传输状态 0 正在下载 1 正在上传 2 传输完成</param>
    /// <param name="pbValue">进度值</param>
    /// <param name="lblTime">已用时间</param>
    /// <param name="lblSpeed">平均速度</param>
    /// <param name="lblState">已上传</param>
    /// <param name="lblSize">大小</param>
    /// </summary>
    public class TranState
    {
        private int state;
        private int pbValue;
        private string lblTime;
        private string lblSpeed;
        private string lblState;
        private string lblSize;
        
        public int State { get => state; set => state = value; }
        public int PbValue { get => pbValue; set => pbValue = value; }
        public string LblTime { get => lblTime; set => lblTime = value; }
        public string LblSpeed { get => lblSpeed; set => lblSpeed = value; }
        public string LblState { get => lblState; set => lblState = value; }
        public string LblSize { get => lblSize; set => lblSize = value; }
    }
}
