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
        List<string> textList = Program.GetText(html, "a");//创建一个方法，获取<a></a>之间的文字

    }
    public static List<string> GetText(string str, string title)
    {
        string tmpStr = string.Format("<{0}[^>]*?>(?<Text>[^<]*)</{1}>", title, title); //获取<a>之间内容  
        MatchCollection matchCollection = Regex.Matches(str, tmpStr, RegexOptions.IgnoreCase);
        List<string> textList = new List<string>();
        foreach (Match match in matchCollection)
        {
            string result = match.Groups["Text"].Value;
            textList.Add(result);
            Console.WriteLine(result);
        }

        return textList;
    }

}
}
