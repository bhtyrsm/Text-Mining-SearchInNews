using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMining_SearchInNews
{
    public class News
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public News()
        {
            NewsList.Add(new News() { Title = "Anadolu Ajansı", Link = "https://www.aa.com.tr/tr/rss/default?cat=guncel" });
            NewsList.Add(new News() { Title = "Google Haberler", Link = "http://news.google.com/?output=rss" });
            NewsList.Add(new News() { Title = "Dunya.Com", Link = "https://www.dunya.com/rss" });
            NewsList.Add(new News() { Title = "Cumhuriyet(Son Dakika)", Link = "https://www.cumhuriyet.com.tr/rss/son_dakika.xml" });
            NewsList.Add(new News() { Title = "Milliyet Gündem", Link = "https://www.milliyet.com.tr/rss/rssnew/gundemrss.xml" });
            NewsList.Add(new News() { Title = "CNBC", Link = "https://www.cnbc.com/id/100727362/device/rss/rss.html" });
            NewsList.Add(new News() { Title = "CNN Türk", Link = "https://www.cnnturk.com/feed/rss/news" });
            NewsList.Add(new News() { Title = "Trt Gündem", Link = "http://www.trt.net.tr/rss/gundem.rss" });
            NewsList.Add(new News() { Title = "AliJezara", Link = "http://www.aljazeera.com.tr/rss.xml" });
            NewsList.Add(new News() { Title = "BBC", Link = "https://feeds.bbci.co.uk/turkce/rss.xml" });
            NewsList.Add(new News() { Title = "CNN Türk(Türkiye)", Link = "https://www.cnnturk.com/feed/rss/turkiye/news" });
            NewsList.Add(new News() { Title = "TRT Türkiye", Link = "http://www.trt.net.tr/rss/turkiye.rss" });
            NewsList.Add(new News() { Title = "TRT Dünya", Link = "http://www.trt.net.tr/rss/dunya.rss" });
        }

        public string Title { get; set; }
        public string Link { get; set; }

        public List<News> NewsList { get; set; }
    }
}
