using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUpload
{
    class NetManager
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="url">上传地址</param>
        /// <param name="path">文件所在路径</param>
        /// <returns></returns>
        public static string HttpUploadFile(string url,string path, Form form1, Delegate upLoadDelgate,FileTransmitModel fileTransmitModel)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            CookieContainer cookieContainer = new CookieContainer();
            request.CookieContainer = cookieContainer;
            request.AllowAutoRedirect = true;
            request.Method = "POST";
            string boundary = DateTime.Now.Ticks.ToString("X");
            request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;
            byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
            int pos = path.LastIndexOf("\\");
            string fileName = path.Substring(pos + 1);
            StringBuilder stringBuilder = new StringBuilder(string.Format("Content-Disposition:form-data;name=\"fileName\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n", fileName));
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fs);
            long fileLength = fs.Length;
            long length = fileLength + postHeaderBytes.Length + endBoundaryBytes.Length;
            int bufferLength = 1024;
            byte[] bArr = new byte[bufferLength];
            long offset = 0;
            DateTime startTime = DateTime.Now;
            int size= binaryReader.Read(bArr, 0, bufferLength);
            Stream postStream = request.GetRequestStream();
            postStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
            postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
            TranState tranState = new TranState();
            int count = 0;
            while (size > 0)
            {
                postStream.Write(bArr, 0, bArr.Length);
                offset += size;
                int Value = (int)Math.Round((offset * 100.0 / length), MidpointRounding.AwayFromZero);
                tranState.PbValue = Value;
                TimeSpan span = DateTime.Now - startTime;
                double second = span.TotalSeconds;
                string Text = "已用时：" + second.ToString("F2") + "秒";
                tranState.LblState = Text;
                if (second > 0.001)
                {
                    string lblSpeed= " 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒";
                    tranState.LblSpeed = lblSpeed;
                }
                else
                {
                    tranState.LblSpeed = " 正在连接…";
                }
                string lblState = "已上传：" + (offset * 100.0 / length).ToString("F2") + "%";
                tranState.LblState = lblState;
                if (Value == 100)
                {
                    tranState.LblState= "已上传：99%";
                }
                
                string lblSize = (offset / 1048576.0).ToString("F2") + "M/" + (fileLength / 1048576.0).ToString("F2") + "M";
                tranState.LblSize= lblSize;
                Application.DoEvents();
                if (Value > count)
                {
                    count = Value;
                    form1.Invoke(upLoadDelgate, tranState);
                }
               
                size = binaryReader.Read(bArr, 0, bufferLength);
            }
                fs.Close();
            postStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            postStream.Close();
            HttpWebResponse response =request.GetResponse() as HttpWebResponse;
            Stream instream = response.GetResponseStream();
            StreamReader sr = new StreamReader(instream, Encoding.UTF8);
            string content = sr.ReadToEnd();
            tranState.LblState = "已上传：100%";
            form1.Invoke(upLoadDelgate, tranState);
            Console.WriteLine(" 上传完成…");
            UploadFinished(fileTransmitModel);
            return content;
        }

        // 下载完成
        private static void UploadFinished(FileTransmitModel fileTransmitModel)
        {
            string url = "http://localhost:8080/insertTransferInfo";
            string postData=JsonMapper.ToJson(fileTransmitModel);
            string json = "fileinfo="+ postData;
            HttpPost(url, json);
        }

        public string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        public static string HttpPost(string url, string postDataStr)
        {
            string strReturn;
            //在转换字节时指定编码格式
            byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);

            //配置Http协议头
            HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);
            resquest.Method = "POST";
            resquest.ContentType = "application/x-www-form-urlencoded";
            resquest.ContentLength = byteData.Length;

            //发送数据
            using (Stream resquestStream = resquest.GetRequestStream())
            {
                resquestStream.Write(byteData, 0, byteData.Length);
            }

            //接受并解析信息
            using (WebResponse response = resquest.GetResponse())
            {
                //解决乱码：utf-8 + streamreader.readToEnd
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                strReturn = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }

            return strReturn;
        }

        /// <summary>
        /// Http下载文件
        /// </summary>
        public static string HttpDownloadFile(string url, string path, Form form1, Delegate upLoadDelgate)
        {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            //创建本地文件写入流
            Stream stream = new FileStream(path, FileMode.Create);

            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                stream.Write(bArr, 0, size);
                Console.WriteLine(size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            stream.Close();
            responseStream.Close();
            return path;
        }

        /// <summary>
        /// Http方式下载文件
        /// </summary>
        /// <param name="url">http地址</param>
        /// <param name="localfile">本地文件</param>
        /// <returns></returns>
        public static int DownloadFile(string url, string localfile,Form form1, Delegate upLoadDelgate)
        {
            int ByteSize = 1024;
            // 下载中的后缀，下载完成去掉
            string Suffix = ".downloading";
            int ret = 0;
            string localfileReal = localfile;
            string localfileWithSuffix = localfileReal + Suffix;
            // 记录下载信息
            TranState tranState = new TranState();
            try
            {
                long startPosition = 0;
                FileStream writeStream = null;

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(localfileReal))
                    return 1;

                //取得远程文件长度
                long remoteFileLength = GetHttpLength(url);
                
                if (remoteFileLength == 0)
                    return 2;

                if (File.Exists(localfileReal))
                    return 0;

                //判断要下载的文件是否存在
                if (File.Exists(localfileWithSuffix))
                {
                    writeStream = File.OpenWrite(localfileWithSuffix);
                    startPosition = writeStream.Length;
                    if (startPosition > remoteFileLength)
                    {
                        writeStream.Close();
                        File.Delete(localfileWithSuffix);
                        writeStream = new FileStream(localfileWithSuffix, FileMode.Create);
                    }
                    else if (startPosition == remoteFileLength)
                    {
                        DownloadFileOk(localfileReal, localfileWithSuffix);
                        writeStream.Close();
                        return 0;
                    }
                    else
                        writeStream.Seek(startPosition, SeekOrigin.Begin);
                }
                else
                    writeStream = new FileStream(localfileWithSuffix, FileMode.Create);
                HttpWebRequest req = null;
                HttpWebResponse rsp = null;
                try
                {
                    req = (HttpWebRequest)HttpWebRequest.Create(url);
                    if (startPosition > 0)
                        req.AddRange((int)startPosition);

                    rsp = (HttpWebResponse)req.GetResponse();
                    using (Stream readStream = rsp.GetResponseStream())
                    {
                        byte[] btArray = new byte[ByteSize];
                        long currPostion = startPosition;
                        int contentSize = 0;
                        DateTime startTime = DateTime.Now;
                        
                        while ((contentSize = readStream.Read(btArray, 0, btArray.Length)) > 0)
                        {
                            writeStream.Write(btArray, 0, contentSize);
                            currPostion += contentSize;
                            // 进度条
                            tranState.PbValue = (int)(currPostion * 100 / remoteFileLength);
                            string lblState = "已下载：" + (int)(currPostion * 100 / remoteFileLength) + "%";
                            tranState.LblState = lblState;
                            // 下载大小
                            tranState.LblSize = (currPostion / 1048576.0).ToString("F2") + "M/" + (remoteFileLength / 1048576.0).ToString("F2") + "M";
                            TimeSpan span = DateTime.Now - startTime;
                            double second = span.TotalSeconds;
                            string Text = "已用时：" + second.ToString("F2") + "秒";
                            tranState.LblTime = Text;
                            if (second > 0.001)
                            {
                                string lblSpeed = " 平均速度：" + (currPostion / 1024 / second).ToString("0.00") + "KB/秒";
                                tranState.LblSpeed = lblSpeed;
                            }
                            else
                            {
                                tranState.LblSpeed = " 正在连接…";
                            }
                            if (tranState.PbValue == 100)
                            {
                                tranState.PbValue = 99;
                            }
                            Application.DoEvents();
                            form1.Invoke(upLoadDelgate, tranState);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("获取远程文件失败！exception：\n" + ex.ToString());
                    ret = 3;
                }
                finally
                {
                    if (writeStream != null)
                        writeStream.Close();
                    if (rsp != null)
                        rsp.Close();
                    if (req != null)
                        req.Abort();

                    if (ret == 0)
                    {
                        DownloadFileOk(localfileReal, localfileWithSuffix);
                        TranState tranStateend = new TranState();
                        tranStateend.PbValue = 100;
                        tranStateend.LblState = "100%";
                        form1.Invoke(upLoadDelgate, tranStateend);
                    }
                       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("获取远程文件失败！exception：\n" + ex.ToString());
                ret = 4;
            }

            return ret;
        }

        /// <summary>
        /// 下载完成
        /// </summary>
        private static void DownloadFileOk(string localfileReal, string localfileWithSuffix)
        {
            try
            {
                //去掉.downloading后缀
                FileInfo fi = new FileInfo(localfileWithSuffix);
                fi.MoveTo(localfileReal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //通知完成

                Console.WriteLine("下载完成"+100);
            }
        }

        // 从文件头得到远程文件的长度
        private static long GetHttpLength(string url)
        {
            long length = 0;
            HttpWebRequest req = null;
            HttpWebResponse rsp = null;
            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(url);
                rsp = (HttpWebResponse)req.GetResponse();
                if (rsp.StatusCode == HttpStatusCode.OK)
                    length = rsp.ContentLength;
            }
            catch (Exception ex)
            {
                Console.WriteLine("获取远程文件大小失败！exception：\n" + ex.ToString());
            }
            finally
            {
                if (rsp != null)
                    rsp.Close();
                if (req != null)
                    req.Abort();
            }

            return length;
        }

    }
}
