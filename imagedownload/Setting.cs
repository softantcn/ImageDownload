using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imagedownload
{
    class Setting
    {
        
        int maxCount = 0;
        /// <summary>
        /// 批量下载 最大下载数量
        /// </summary>
        public int MaxCount
        {
            get { return maxCount; }
            set { maxCount = value; }
        }

       
        string uritxt = null;
        /// <summary>
        /// 批量下载 网址uri路径
        /// </summary>
        public string Uritxt
        {
            get { return uritxt; }
            set { uritxt = value; }
        }

       
        bool isbaiduimage_pl = true;
        /// <summary>
        /// 批量下载 是否下载百度图片
        /// </summary>
        public bool Isbaiduimage_pl
        {
            get { return isbaiduimage_pl; }
            set { isbaiduimage_pl = value; }
        }

        
        int levels = 0;
        /// <summary>
        /// 批量下载 网页链接深度
        /// </summary>
        public int Levels
        {
            get { return levels; }
            set { levels = value; }
        }

       
        string checkWebUri = null;
        /// <summary>
        /// 批量下载 网页过滤规则
        /// </summary>
        public string CheckWebUri
        {
            get { return checkWebUri; }
            set { checkWebUri = value; }
        }

        
        string checkImgUri = null;
        /// <summary>
        /// 批量下载 网页过滤规则
        /// </summary>
        public string CheckImgUri
        {
            get { return checkImgUri; }
            set { checkImgUri = value; }
        }


    }
}
