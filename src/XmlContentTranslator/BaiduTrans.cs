using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace XmlContentTranslator
{
    internal class BaiduTrans
    {
        private static string appId = "";
        private static string secretKey = "";

        private static void readKey()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../transKey.xml");
            appId = xmlDocument.DocumentElement.SelectSingleNode("baidu/key").InnerText;
            secretKey = xmlDocument.DocumentElement.SelectSingleNode("baidu/secret").InnerText;
        }

        /// <summary>
        /// 原文
        /// </summary>
        /// <param name="q"></param>
        public List<string> Trans(List<string> lsit)
        {
            if (appId=="" || secretKey=="")
            {
                readKey();
                if (appId == "" || secretKey == "")
                {
                    MessageBox.Show("appId or secretKey is Empty");
                    return null;
                }                    
            }
            string q = string.Empty;

            foreach (string s in lsit)
            {
                q = q + s + "\n";
            }
            q=q.TrimEnd();

            // 源语言
            string from = "en";
            // 目标语言
            string to = "zh";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            string sign = EncryptString(appId + q + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(q);
            url += "&from=" + from;
            url += "&to=" + to;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 6000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            //{"from":"en","to":"zh","trans_result":[{"src":"en","dst":"en"},{"src":"en","dst":"en"}]}
            BaiduResult BaiduResult = new BaiduResult();

            BaiduResult = JsonConvert.DeserializeObject<BaiduResult>(retString);

            var resultList = new List<string>();
            foreach (TransResult transResult in BaiduResult.Trans_result)
            {
                resultList.Add(transResult.Dst);
            }
            return resultList;
        }

        // 计算MD5值
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
    }
}
