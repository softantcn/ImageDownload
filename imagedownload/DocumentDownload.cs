using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace imagedownload
{
    class DocumentDownload
    {
        /// <summary>
        /// 下载主目录
        /// </summary>
        private string rooturi = null;
        /// <summary>
        /// 网站跟目录
        /// </summary>
        private string host = null;
        /// <summary>
        /// 链接深度
        /// </summary>
        private int levels = 0;
        /// <summary>
        /// 网页过滤规则
        /// </summary>
        string checkWebUri = null;
        /// <summary>
        /// 存放所有的链接路径
        /// </summary>
        private HashSet<string> allLinks = new HashSet<string>();
        /// <summary>
        /// 存放所有的图片路径
        /// </summary>
        private HashSet<string> allUris = new HashSet<string>();
        /// <summary>
        /// 图片下载线程队列
        /// </summary>
        LinkedList<downloadImageThread> uriList = new LinkedList<downloadImageThread>();
        
        public long succCount = 0;
        public long maxCount = 0;
        public bool isfinish = false;
        private bool isfinishDocument = false;
        Thread thmanager = null; 
        public DocumentDownload(Setting set)
        {
            this.rooturi = set.Uritxt;
            host = Utils.getHost(this.rooturi);
            this.levels = set.Levels;
            this.maxCount = set.MaxCount;
            this.checkWebUri = set.CheckWebUri;
            thmanager = new Thread(new ThreadStart(startThreak));
            thmanager.Start();
        }

        public void startThreak()
        {
            thmanager = new Thread(new ThreadStart(DownloadImageManager));
            thmanager.Start();
            downloadDocument(this.rooturi, this.levels);
            isfinishDocument = true;
        }

        public void downloadDocument(string parmuri, int parmlevel)
        {
            HashSet<string> linkset = new HashSet<string>();
            HashSet<string> uriset = new HashSet<string>();
            System.Net.WebClient client = new System.Net.WebClient();
            try
            {
                if (allUris.Count > maxCount)
                {
                    return;
                }
                byte[] bytes = client.DownloadData(parmuri);
                string sHtml = System.Text.Encoding.GetEncoding("utf-8").GetString(bytes);
                int charindex = sHtml.IndexOf("charset=");
                if (charindex > 0)
                {
                    int endindex = sHtml.IndexOf("\"",charindex);
                    string coding = sHtml.Substring(charindex + 8, endindex - charindex - 8);
                    if (!coding.Equals("utf8", StringComparison.OrdinalIgnoreCase) && !coding.Equals("utf-8", StringComparison.OrdinalIgnoreCase))
                    {
                        sHtml = System.Text.Encoding.GetEncoding(coding).GetString(bytes);
                    }
                }
                uriset = GetImageUrlList(sHtml);
                linkset = Utils.GetHrefUrlList(sHtml);
                //linkset.RemoveWhere(isNotStartHost);

                uriset.ExceptWith(allUris);
                allUris.UnionWith(uriset);
                Console.WriteLine(" ****************\n\nurisetCount:" + uriset.Count);
                if (uriset.Count > 0)
                {
                    downloadImageThread dlthread = new downloadImageThread(uriset, parmuri,this);
                    uriList.AddLast(dlthread);
                    //ImageDownload imageDownload = new ImageDownload(uriset, parmuri);
                    //imageDownload.startThread();

                    //succCount += imageDownload.getSuccessCount();
                }

                linkset.ExceptWith(allLinks);
                allLinks.UnionWith(linkset);
                Console.WriteLine(" ****************\n\nlinksetCount:" + linkset.Count);
                if (parmlevel == 0 || allUris.Count >= maxCount)
                {
                    return;
                }
                else if(parmlevel < 0 || parmlevel >20)
                {
                    parmlevel = 20;
                }
                parmlevel--;
                foreach(string link in linkset){
                    String uri = link;
                    if (!uri.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                    {
                        uri = Utils.getHost(parmuri) + link;
                    }
                    if (!isNotStartHost(uri))
                    {
                        downloadDocument(uri, parmlevel);
                    }
                }
                
            }
            catch (Exception ex) { }

        }

        private bool isNotStartHost(string link)
        {
            if (!String.IsNullOrEmpty(checkWebUri))
            {
                return !link.StartsWith(host) || !link.StartsWith(checkWebUri);
            }
            return !link.StartsWith(host) ;
        }


        public void DownloadImageManager()
        {
            int count = 0;
            int thcount = 5;
            downloadImageThread[] dlImageths = new downloadImageThread[thcount];
            while (!isfinishDocument || uriList.Count > 0)
            {
                if (uriList.Count > 0)
                {
                    for (int i = 0; i < thcount; i++)
                    {
                        if (dlImageths[i] == null || dlImageths[i].isfinish)
                        {
                            lock (uriList)
                            {
                                dlImageths[i] = uriList.ElementAt(0);
                                uriList.RemoveFirst();
                                dlImageths[i].startThread();
                            }
                            break;
                        }
                    }
                }

                if (succCount > maxCount)
                {
                    break;
                }
            }

            while (true)
            {
                count = 0;
                for (int i = 0; i < thcount; i++)
                {
                    if (dlImageths[i] == null || dlImageths[i].isfinish)
                    {
                        count++;
                    }
                }
                if (count == thcount)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 图片
        /// </summary>
        /// <param name="sHtmlText">HTML代码</param>
        /// <returns>图片的URL列表</returns>
        public HashSet<string> GetImageUrlList(string sHtmlText)
        {
            //string pattern = "thumbURL\":\"(?<imgUrl>[^\\s\t\r\n\"'<>]*)\"";
            string pattern = @"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>";
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

    class downloadImageThread
    {
        HashSet<string> urlset = new HashSet<string>();
        string searchtxt = null;
        public bool isfinish = false;
        DocumentDownload dcmtDown = null;

        public downloadImageThread(HashSet<string> urlset, string searchtxt, DocumentDownload dcmtDown)
        {
            this.urlset = urlset;
            this.searchtxt = searchtxt;
            this.dcmtDown = dcmtDown;
        }

        public void startThread()
        {
            Thread th = new Thread(new ThreadStart(downloadImage));
            th.Start();
        }

        private void downloadImage(){
            ImageDownload imageDownload = new ImageDownload(urlset, searchtxt);
            imageDownload.startThread();

            dcmtDown.succCount += imageDownload.getSuccessCount();
            isfinish = true;
        }
    }
}
