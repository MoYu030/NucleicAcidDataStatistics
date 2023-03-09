using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 核酸检测数据统计.Common
{
    public class HttpHelper
    {
        public string Get(string name)
        {
            try
            {
                string url = $"https://sign.youah.cc/api2/ajax.php?act=getNoHS&name={name}";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = null;
                request.KeepAlive = false;
                request.Timeout = 10000;
                request.ServicePoint.Expect100Continue = false;
                request.ServicePoint.UseNagleAlgorithm = false;
                request.ServicePoint.ConnectionLimit = 65500;
                request.AllowWriteStreamBuffering = false;
                request.Proxy = null;
                // request.Timeout = Timeout;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //获得Response的流
                Stream myResponseStream = response.GetResponseStream();
                //读取流数据
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                //读取完成  关闭数据流
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
        }
            catch
            {               
                return "";
            }
        }
    }
}
