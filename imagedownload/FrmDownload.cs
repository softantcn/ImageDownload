using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Net;
using System.IO;

namespace imagedownload
{
    public partial class FrmDownload : Form
    {
        public FrmDownload()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 配置属性对象
        /// </summary>
        Setting setting = new Setting();

        List<DocumentDownload> downloadList = new List<DocumentDownload>();

        /// <summary>
        /// 开始批量下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_tspBtn_Click(object sender, EventArgs e)
        {
            updateUserData();

            if (setting.Isbaiduimage_pl)
            {
                //百度图片已json方式返回所以通过浏览器加载json数据
                //后期实现自动解析json
                try
                {
                    this.loaddata.Navigate(new Uri(setting.Uritxt));
                }
                catch (System.UriFormatException)
                {
                    return;
                }
            }
            else
            {
                DocumentDownload download = new DocumentDownload(setting);
                downloadList.Add(download);
            }
        }
      

        /// <summary>
        /// 批量下载 更新用户输入数据
        /// </summary>
        private void updateUserData()
        {
            setting.Uritxt = this.uri_txt.Text;
            if (String.IsNullOrEmpty(setting.Uritxt))
            {
                MessageBox.Show("请填写路径！", "系统提示");
                return;
            }

            if (!setting.Uritxt.StartsWith("http://") &&
                !setting.Uritxt.StartsWith("https://"))
            {
                setting.Uritxt = "http://" + setting.Uritxt;
            }

            setting.CheckWebUri = this.checkWebUri_txt.Text;

            setting.CheckImgUri = this.checkImgUri_txt.Text;

            setting.MaxCount = (int)this.maxCount_numUpd.Value;

            setting.Levels = (int)this.level_numUpd.Value;

            setting.Isbaiduimage_pl = this.baidu_pl_rdo.Checked;

        }


        /// <summary>
        /// *************************************************************************************************************
        /// ************************************       以下为边浏览边下载       *****************************************
        /// *************************************************************************************************************
        /// </summary>

        /// <summary>
        /// 网址uri
        /// </summary>
        string searchtxt = null;
        /// <summary>
        /// 下载过滤规则
        /// </summary>
        string checkUri = "";
        /// <summary>
        /// 标志是否下载百度图片
        /// </summary>
        bool isbaiduimage = false;
        /// <summary>
        /// 下载图片个数
        /// </summary>
        int succCount = 0;
        /// <summary>
        /// 标志是否边浏览边下载
        /// </summary>
        bool isSynchrodown = false;
        /// <summary>
        /// 存放已下载的图片路径防止重复下载
        /// </summary>
        HashSet<string> allUrlset = new HashSet<string>();

        /// <summary>
        /// 浏览按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_btn_Click(object sender, EventArgs e)
        {
            //获取用户数据
            checkSearchTxt();

            try
            {
                //给浏览器赋值uri
                this.webrow.Navigate(searchtxt);
            }
            catch (System.UriFormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

        /// <summary>
        /// 浏览器加载完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webrow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webrowser = (WebBrowser)sender;
            //获取新的请求路径显示到输入框
            searchtxt = webrowser.Url.AbsoluteUri;
            this.search_txt.Text = searchtxt;

            //如果是边浏览边下载模式则下载文档中已加载的图片
            checkSearchTxt();
            if (isSynchrodown)
            {
                Thread th = new Thread(new ParameterizedThreadStart(downloadImage));
                th.Start(webrowser.Document);
            }
        }

        /// <summary>
        /// 浏览器加载状态改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webrow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //更新下载模式
            checkSearchTxt();

            //如果是边浏览边下载模式并且文档动态加载完成
            if (isSynchrodown && checkIsloadOver(e.CurrentProgress, e.MaximumProgress))
            {
                WebBrowser loadweb = (WebBrowser)sender;

                Thread th = new Thread(new ParameterizedThreadStart(downloadImage));
                th.Start(loadweb.Document);

                Console.WriteLine(" ************************************\nisOver11111111111111111");
                Console.WriteLine(" ************************************\nimageCount:" + loadweb.Document.Images.Count);

            }
        }

        /// <summary>
        /// 解析document 下载图片
        /// </summary>
        /// <param name="document"></param>
        private void downloadImage(object document)
        {
            //存放解析图片的url路径集合
            HashSet<string> urlset = new HashSet<string>();
            //判断document是否是HtmlDocument对象
            HtmlDocument htducument = document as HtmlDocument;
            if (htducument != null)
            {
                mshtml.IHTMLImgElement imageElement = null;
                try
                {
                    //循环HtmlDocument对象的图片集合数组
                    foreach (HtmlElement image in htducument.Images)
                    {
                        imageElement = (mshtml.IHTMLImgElement)image.DomElement;
                        urlset.Add(imageElement.src);
                    }
                }
                catch (Exception ex) { }
            }
            else
            {
                //如果document不是HtmlDocument对象则以文本方式解析
                urlset = Utils.GetBaiduImageUrlList((string)document);
            }
            //加锁处理allUrlset
            lock (allUrlset)
            {
                urlset.ExceptWith(allUrlset);

                if (urlset.Count != 0)
                {
                    allUrlset.UnionWith(urlset);
                }
            }

            if (urlset.Count != 0)
            {

                ImageDownload imageDownload = new ImageDownload(urlset, searchtxt);
                imageDownload.startThread();

                succCount += imageDownload.getSuccessCount();
            }

        }


        /// <summary>
        /// 检查文档是否动态加载完毕
        /// 判断条件：((currentProgress == 0 || currentProgress == -1 )&& maximumProgress == 0 )
        /// </summary>
        /// <param name="currentProgress">已下载字节数</param>
        /// <param name="maximumProgress">全部字节数</param>
        /// <returns></returns>
        private bool checkIsloadOver(long currentProgress, long maximumProgress)
        {
            bool isover = false;
            if ((currentProgress == 0 || currentProgress == -1) && maximumProgress == 0)
            {
                isover = true;
            }
            return isover;
        }

        /// <summary>
        /// 获取用户输入数据
        /// </summary>
        private void checkSearchTxt()
        {
            //获取url路径
            searchtxt = this.search_txt.Text;
            if (String.IsNullOrEmpty(searchtxt))
            {
                MessageBox.Show("请填写路径！", "系统提示");
                return;
            }

            if (!searchtxt.StartsWith("http://") &&
                !searchtxt.StartsWith("https://"))
            {
                searchtxt = "http://" + searchtxt;
            }
            //获取下载过滤规则
            checkUri = this.checkUri_txt.Text;
            //获取是否下载百度图片
            isbaiduimage = this.baidu_rdo.Checked;
            //获取是否边浏览边下载
            isSynchrodown = this.synchrodown_chkBox.Checked;
        }
        /// <summary>
        /// 防止在新窗口打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webrow_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            try
            {
                this.webrow.Navigate(this.webrow.StatusText);
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 更新下载数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void succCountUpdate_tim_Tick(object sender, EventArgs e)
        {
            this.succCount_lab.Text = succCount + "";
        }

        /// <summary>
        /// url 输入框获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_txt_Enter(object sender, EventArgs e)
        {
            this.search_txt.SelectAll();
        }
        /// <summary>
        /// url 输入框获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_txt_MouseUp(object sender, MouseEventArgs e)
        {
            this.search_txt.SelectAll();
        }
        /// <summary>
        /// 过滤规则 输入框获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkUri_txt_MouseUp(object sender, MouseEventArgs e)
        {
            this.checkUri_txt.SelectAll();
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.webrow.GoBack();
        }

        /// <summary>
        /// 前进
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forword_btn_Click(object sender, EventArgs e)
        {
            this.webrow.GoForward();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            this.webrow.Refresh();
        }
        
    }
}
