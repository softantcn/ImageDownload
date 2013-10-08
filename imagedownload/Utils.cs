using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace imagedownload
{
    class Utils
    {
        /// <summary>
        /// 获取网站跟目录
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string getHost(string uri)
        {
            int index = uri.IndexOf("/", 8);
            if (index > 8)
            {
                return uri.Substring(0, index);
            }
            else
            {
                return uri;
            }
        }
        /// <summary>
        /// 获取网站路径名称
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string getWebName(string uri)
        {
            return (getHost(uri)).Substring(8);
        }

        /// <summary>
        /// 解析百度图片
        /// </summary>
        /// <param name="sHtmlText">HTML代码</param>
        /// <returns>图片的URL列表</returns>
        public static HashSet<string> GetBaiduImageUrlList(string sHtmlText)
        {
            //string pattern = "thumbURL\":\"(?<imgUrl>[^\\s\t\r\n\"'<>]*)\"";
            string pattern = "hoverURL\":\"(?<imgUrl>[^\\s\t\r\n\"'<>]*)\"";
            // 定义正则表达式用来匹配 img 标签
            Regex regImg = new Regex(pattern, RegexOptions.IgnoreCase);

            // 搜索匹配的字符串
            MatchCollection matches = regImg.Matches(sHtmlText);

            HashSet<string> urlset = new HashSet<string>();

            // 取得匹配项列表
            foreach (Match match in matches)
            {
                urlset.Add(match.Groups["imgUrl"].Value);
            }
            return urlset;
        }

        /// <summary>
        /// 解析HTML中所有图片的 URL。
        /// </summary>
        /// <param name="sHtmlText">HTML代码</param>
        /// <returns>图片的URL列表</returns>
        public string[] GetHtmlImageUrlList(string sHtmlText)
        {
            string pattern = @"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>";
            // 定义正则表达式用来匹配 img 标签
            Regex regImg = new Regex(pattern, RegexOptions.IgnoreCase);

            // 搜索匹配的字符串
            MatchCollection matches = regImg.Matches(sHtmlText);

            int i = 0;
            string[] sUrlList = new string[matches.Count];

            // 取得匹配项列表
            foreach (Match match in matches)
            {
                sUrlList[i++] = match.Groups["imgUrl"].Value;
            }
            return sUrlList;
        }

        /// <summary>
        /// <a> 连接
        /// </summary>
        /// <param name="sHtmlText">HTML代码</param>
        /// <returns>连接的URL列表</returns>
        public static HashSet<string> GetHrefUrlList(string sHtmlText)
        {
            //string pattern = "thumbURL\":\"(?<imgUrl>[^\\s\t\r\n\"'<>]*)\"";
            string pattern = @"<a\b[^<>]*?\bhref[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>";
            // 定义正则表达式用来匹配 img 标签
            Regex regImg = new Regex(pattern, RegexOptions.IgnoreCase);

            // 搜索匹配的字符串
            MatchCollection matches = regImg.Matches(sHtmlText);

            HashSet<string> urlset = new HashSet<string>();

            // 取得匹配项列表
            foreach (Match match in matches)
            {
                urlset.Add(match.Groups["imgUrl"].Value);
            }
            return urlset;
        }
    }
}
