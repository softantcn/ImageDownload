using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;

namespace imagedownload
{
    class ImageDownload
    {
        private int successCount = 0;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void addCount()
        {
            successCount++;
        }

        public int getSuccessCount()
        {
            return successCount;
        }

        public bool isStoped = false;
        HashSet<string> urlset = null;
        string searchtxt = null;
        public ImageDownload(HashSet<string> urlset, string searchtxt)
        {
            this.urlset = urlset;
            this.searchtxt = searchtxt;
        }

        public void startThread()
        {
            DownloadThread[] threads = new DownloadThread[20];
            int thcount = 5;
            foreach (string uilpath in urlset)
            {
                bool isPass = false;
                while (!isPass)
                {
                    for (int i = 0; i < thcount; i++)
                    {
                        if (threads[i] == null || threads[i].isStoped)
                        {
                            threads[i] = new DownloadThread(uilpath, searchtxt, this);
                            isPass = true;
                            break;
                        }
                    }
                }
            }

            while (true)
            {
                int count = 0;
                for (int i = 0; i < thcount; i++)
                {
                    if (threads[i] == null || threads[i].isStoped)
                    {
                        count++;
                    }
                }
                if (count == thcount)
                {
                    break;
                }
            }
            isStoped = true;
        }

        
    }

    class DownloadThread
    {
        string uilpath = null;
        string searchtxt = null;
        string referer = null;
        public bool isStoped = false;
        ImageDownload imageDownload = null;
        public DownloadThread(string uilpath, string searchtxt, ImageDownload imageDownload)
        {
            if (uilpath != null)
            {
                this.uilpath = uilpath;
                this.referer = searchtxt;
                if (!uilpath.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                {
                    this.uilpath = Utils.getHost(this.referer) + uilpath;
                }
                this.searchtxt = new Uri(searchtxt).ToString();
     
                this.imageDownload = imageDownload;
                Thread th = new Thread(new ThreadStart(duwnload));
                th.Start();
            }
            else
            {
                isStoped = true;
            }
        }

        public void duwnload()
        {
            String url = uilpath;

            url = url.Replace("\\/", "/");

            url = url.Replace("\\", "/");

            string filename = url.Substring(url.LastIndexOf('/') + 1);

            string searchName = getSearchName();

            if (!searchName.Equals(""))
            {
                searchName = "/" + searchName;
            }

            string filedir = "e:/imagedownload" + searchName;
            DirectoryInfo dir = new DirectoryInfo(filedir);
            if (!dir.Exists)
            {
                dir.Create();
            }

            string filepath = filedir + "/" +filename;

            if (!File.Exists(filepath))
            {
                //文件不存在则下载
                try
                {

                    System.Net.WebClient web = new System.Net.WebClient();
                    web.Headers.Add("Accept", "*/*");
                    web.Headers.Add("Referer", referer);
                    //web.Headers.Add("Accept-Encoding", "gzip,deflate");
                    //web.Headers.Add("Accept-Language", "zh-CN");
                    //web.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; .NET4.0C; .NET4.0E)");
                    //web.Headers.Add("Connection", "keep-alive");
                    //web.Headers.Add("Cookie:BAIDUID=53BE25DED70E81E23B072CE793BD0C52:FG=1; BDUSS=XVnNFBCSEdRfngxNFVKZ1ZqVmYwdGZoeU43Q3o3UHhxWDhZMllFbjZ5d343anRTQVFBQUFBJCQAAAAAAAAAAAEAAACAxp8faHhseTIwMTIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

                    Stream reader = web.OpenRead(url);
                    FileStream writer = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                    byte[] buff = new byte[512];
                    int c = 0; //实际读取的字节数
                    while ((c = reader.Read(buff, 0, buff.Length)) > 0)
                    {
                        writer.Write(buff, 0, c);
                    }
                    writer.Close();
                    writer.Dispose();
                    reader.Close();
                    reader.Dispose();
                    imageDownload.addCount();
                    //web.Credentials = CredentialCache.DefaultCredentials; // 添加授权证书
                    //web.DownloadFile(url, filepath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(" ************************************\n\nurl:" + url + "\nException: " + e.Message);
                }
            }
            isStoped = true;
        }

        private string getSearchName()
        {
            string searchName = Utils.getWebName(searchtxt);
            int nameIndex = searchtxt.IndexOf("channel#");
            if (nameIndex > 0)
            {
                int centIndex = searchtxt.IndexOf("&", nameIndex);
                if (centIndex < 0)
                {
                    centIndex = searchtxt.Length;
                    if (nameIndex > 0 && nameIndex + 8 < searchtxt.Length)
                    {
                        searchName = searchName + "/" + searchtxt.Substring(nameIndex + 8, centIndex - nameIndex - 8);
                    }
                }
                else
                {
                    searchName = searchName + "/" + searchtxt.Substring(nameIndex + 8, centIndex - nameIndex - 8);
                    int endIndex = searchtxt.IndexOf("&", centIndex + 1);
                    if (endIndex < 0)
                    {
                        endIndex = searchtxt.Length;
                    }
                    if (centIndex + 1 < searchtxt.Length)
                    {
                        searchName = searchName + "/" + searchtxt.Substring(centIndex + 1, endIndex - centIndex - 1);
                    }
                }
            }
            else
            {
                int colIndex = searchtxt.IndexOf("column=");
                if (colIndex > 0)
                {
                    int endIndex = searchtxt.IndexOf("&", colIndex);
                    if (endIndex < 0)
                    {
                        endIndex = searchtxt.Length;
                        if (endIndex > 0 && colIndex + 7 < searchtxt.Length)
                        {
                            searchName = searchName + "/" + searchtxt.Substring(endIndex + 7, endIndex - colIndex - 7);
                        }
                    }
                    else
                    {
                        searchName = searchName + "/" + searchtxt.Substring(colIndex + 7, endIndex - colIndex - 7);
                    }
                }
                int tagIndex = searchtxt.IndexOf("tag=");
                if (tagIndex > 0)
                {
                    int endIndex = searchtxt.IndexOf("&", tagIndex);
                    if (endIndex < 0)
                    {
                        endIndex = searchtxt.Length;
                        if (nameIndex > 0 && nameIndex + 4 < searchtxt.Length)
                        {
                            if (searchName.Length != 0)
                            {
                                searchName = searchName + "/" + searchtxt.Substring(tagIndex + 4, endIndex - tagIndex - 4);
                            }
                            else
                            {
                                searchName = searchName + "/" + searchtxt.Substring(tagIndex + 4, endIndex - tagIndex - 4);
                            }
                        }
                    }
                    else
                    {
                        if (searchName.Length != 0)
                        {
                            searchName = searchName + "/" + searchtxt.Substring(tagIndex + 4, endIndex - tagIndex - 4);
                        }
                        else
                        {
                            searchName = searchName + "/" + searchtxt.Substring(tagIndex + 4, endIndex - tagIndex - 4);
                        }
                    }
                }
                
            }
            nameIndex = searchtxt.IndexOf("word=");
            if (nameIndex > 0)
            {
                int endIndex = searchtxt.IndexOf("&", nameIndex);
                if (endIndex < 0)
                {
                    endIndex = searchtxt.Length;
                }

                if (nameIndex > 0 && nameIndex + 5 < searchtxt.Length)
                {
                    if (searchName.Equals(""))
                    {
                        searchName = searchName + "/" + searchtxt.Substring(nameIndex + 5, endIndex - nameIndex - 5);
                    }
                    else
                    {
                        searchName = searchName + "/" + searchtxt.Substring(nameIndex + 5, endIndex - nameIndex - 5);
                    }
                }
            }

            return searchName;
        }
    }
}
