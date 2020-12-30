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
            this.NewsList = new List<News>();

        }
        public string Source { get; set; }
        public string Link { get; set; }

        public List<News> NewsList { get; set; }

        public void initializeLinks()
        {
            this.NewsList.Add(new News() { Source = "Anadolu Ajansı", Link = "https://www.aa.com.tr/tr/rss/default?cat=guncel" });
            this.NewsList.Add(new News() { Source = "Google Haberler", Link = "http://news.google.com/?output=rss" });
            this.NewsList.Add(new News() { Source = "Dunya.Com", Link = "https://www.dunya.com/rss" });
            this.NewsList.Add(new News() { Source = "Cumhuriyet(Son Dakika)", Link = "https://www.cumhuriyet.com.tr/rss/son_dakika.xml" });
            this.NewsList.Add(new News() { Source = "Milliyet Gündem", Link = "https://www.milliyet.com.tr/rss/rssnew/gundemrss.xml" });
            this.NewsList.Add(new News() { Source = "CNBC", Link = "https://www.cnbc.com/id/100727362/device/rss/rss.html" });
            this.NewsList.Add(new News() { Source = "CNN Türk", Link = "https://www.cnnturk.com/feed/rss/news" });
            this.NewsList.Add(new News() { Source = "Trt Gündem", Link = "http://www.trt.net.tr/rss/gundem.rss" });
            this.NewsList.Add(new News() { Source = "AliJezara", Link = "http://www.aljazeera.com.tr/rss.xml" });
            this.NewsList.Add(new News() { Source = "BBC", Link = "https://feeds.bbci.co.uk/turkce/rss.xml" });
            this.NewsList.Add(new News() { Source = "CNN Türk(Türkiye)", Link = "https://www.cnnturk.com/feed/rss/turkiye/news" });
            this.NewsList.Add(new News() { Source = "TRT Türkiye", Link = "http://www.trt.net.tr/rss/turkiye.rss" });
            this.NewsList.Add(new News() { Source = "TRT Dünya", Link = "http://www.trt.net.tr/rss/dunya.rss" });
        }
    }


    public class NewsDetail
    {
        public int Row { get; set; }
        public string Source { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
        public string NewsLink { get; set; }
    }
}
