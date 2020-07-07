

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace scrapy
{
    class Program 
    { 

    static void Main(string[] args)
    {
        string url = @"https://docs.microsoft.com/en-us/dotnet/csharp/";//input the URL

        WebClient client = new WebClient();//创建webClient对象
        client.Credentials = CredentialCache.DefaultCredentials;//获取或设置发送到主机并用于对请求进行身份验证的网络凭据
        byte[] data = client.DownloadData(url);//下载网页内容保存到data中

        string html = Encoding.UTF8.GetString(data);//以UTF8编码方式转换数组为字串
        Program.Get(html);//创建一个方法，获取text和URL

    }
    public static List<string> Get(string str)
    {
        Program pg = new Program();
        string tmpStr = string.Format("<{0}[^>]*?>(?<Text>[^<]*)</{1}>", "a", "a"); //获取<a>之间内容 
        string URLstr = string.Format("(?<=href=\")[^\"]+(?=\")");

        MatchCollection matchCollection = Regex.Matches(str, tmpStr, RegexOptions.IgnoreCase);
        List<string> textList = new List<string>();

        MatchCollection matchCollection_2 = Regex.Matches(str, URLstr, RegexOptions.IgnoreCase);
        List<string> urlList = new List<string>();
        string Path = @"C:/clawer/text.txt";
            foreach (Match match in matchCollection)
         {
            string result = match.Groups["Text"].Value;
            textList.Add(result);
            pg.Write(Path, result);
            //Console.WriteLine(result);
         }

            foreach (Match match in matchCollection_2)
         {
                string result = match.Groups[0].Value;
                urlList.Add(result);
                pg.Write(Path, result);
                //Console.WriteLine(result);
          }
            return null;
    }
        public void Write(string path, string str)//输出内容到一个txt文件
        {
            using (StreamWriter sw = new StreamWriter(path,true)) { 
            sw.WriteLine(str);
            }
        }

        public static void cycleURL(List<String> url)//循环读取URL
        {
            foreach(string url_path in url)
            {
                Program.Get(url_path);
            }
        }



    }
}


















