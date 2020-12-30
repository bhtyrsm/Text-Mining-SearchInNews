using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TextMining_SearchInNews
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// CTR
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

      

        /// <summary>
        /// Page Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGetNews_Click(object sender, EventArgs e)
        {
            News news = new News();
            news.initializeLinks();

            List<NewsDetail> totalNews = new List<NewsDetail>();
            if (news.NewsList != null && news.NewsList.Count() > 0)
            {
                foreach (var item in news.NewsList)
                {
                    var responses = GetNews(item.Source, item.Link);
                    totalNews.AddRange(responses);
                }
            }
           
            gridViewNews.DataSource = totalNews;
        }

        private void btnSeacrh_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            gridViewNews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewNews.ClearSelection();
            try
            {
                foreach (DataGridViewRow row in gridViewNews.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }

                    if (row.Cells[2].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private static string ExtractText(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var chunks = new List<string>();
            foreach (var item in doc.DocumentNode.DescendantsAndSelf())
            {
                if (item.NodeType == HtmlNodeType.Text)
                {
                    if (item.InnerText.Trim() != "")
                    {
                        chunks.Add(item.InnerText.Trim());
                    }
                }
            }
            return String.Join(" ", chunks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<NewsDetail> GetNews(string source, string link)
        {
            try
            {
                bool in_item = false;
                string[] arr = { "", "", "" ,""};
                List<NewsDetail> newsDetails = new List<NewsDetail>();

                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                Uri address = new Uri(link);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                using (Stream data = client.OpenRead(link))
                {
                    using (StreamReader stream = new StreamReader(data))
                    {
                        XmlTextReader reader = null;
                        reader = new XmlTextReader(stream);
                        while (reader.Read())
                        {
                            switch (reader.NodeType)
                            {
                                case XmlNodeType.Element: // The node is an Element.
                                    if (reader.Name == "item")
                                    {
                                        in_item = true;
                                    }
                                    if ((reader.Name == "title") && (in_item))
                                    {
                                        arr[1] = reader.ReadString();
                                    }
                                    if ((reader.Name == "guid") && (in_item))
                                    {
                                        arr[0] = reader.ReadString();

                                    }

                                    if ((reader.Name == "link") && (in_item))
                                    {
                                        arr[3] = reader.ReadString();

                                    }
                                    
                                    if ((reader.Name == "description") && (in_item))
                                    {
                                        arr[2] = reader.ReadString();

                                        arr[2] = ExtractText(arr[2]);
                                        arr[2] = RemoveObsolete(arr[2]);

                                        arr[3] = ExtractText(arr[3]);
                                        arr[3] = RemoveObsolete(arr[3]);

                                        NewsDetail newsDetail = new NewsDetail();
                                        newsDetail.Source = source;
                                        newsDetail.Title = arr[1];
                                        newsDetail.Desciption = arr[2];
                                        newsDetail.NewsLink = arr[3];
                                        newsDetails.Add(newsDetail);
                                    }

                                    break;
                                case XmlNodeType.Text:
                                    break;
                                case XmlNodeType.EndElement:
                                    if (reader.Name == "item")
                                    {
                                        in_item = false;
                                    }
                                    break;
                            }
                        }

                        return newsDetails;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string RemoveObsolete(string str)
        {
            str = str.Replace("&nbsp;", " ");
            str = str.Replace("&quot", " ");
            str = str.Replace("&raquo;", " ");
            str = str.Replace("...", " ");
            str = str.Replace("&#39;", "");
            return str;
        }


    }
}
