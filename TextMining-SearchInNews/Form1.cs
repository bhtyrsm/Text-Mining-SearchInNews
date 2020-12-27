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
            if (news.NewsList != null && news.NewsList.Count() > 0)
            {
                gridViewNews.DataSource = news.NewsList;
            }
        }

        private void btnSeacrh_Click(object sender, EventArgs e)
        {

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
        //public static List<DataRow> GetNews(string title,string link)
        //{
        //    try
        //    {

        //        bool in_item = false;
        //        DataTable dt = new DataTable();

        //        string[] arr = { "", "", "" };

        //        DataRow dr;
        //        dt.Columns.Add("id");
        //        dt.Columns.Add("title");
        //        dt.Columns.Add("desc");

        //        WebClient client = new WebClient();
        //        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

        //        Uri address = new Uri(link);
        //        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

        //        using (Stream data = client.OpenRead(link))
        //        {
        //            using (StreamReader stream = new StreamReader(data))
        //            {
        //                XmlTextReader reader = null;
        //                reader = new XmlTextReader(stream);
        //                while (reader.Read())
        //                {
        //                    switch (reader.NodeType)
        //                    {
        //                        case XmlNodeType.Element: // The node is an Element.
        //                            if (reader.Name == "item")
        //                            {
        //                                in_item = true;
        //                            }
        //                            if ((reader.Name == "title") && (in_item))
        //                            {
        //                                arr[1] = reader.ReadString();
        //                            }
        //                            if ((reader.Name == "guid") && (in_item))
        //                            {
        //                                arr[0] = reader.ReadString();

        //                            }
        //                            if ((reader.Name == "description") && (in_item))
        //                            {
        //                                arr[2] = reader.ReadString();

        //                                dr = dt.NewRow();
        //                                dr["id"] = arr[0];
        //                                dr["title"] = arr[1];
        //                                // prepare the text
        //                                arr[2] = ExtractText(arr[2]);
        //                                arr[2] = RemoveObsolete(arr[2]);

        //                                dr["desc"] = arr[2];
        //                                dt.Rows.Add(dr);
        //                            }

        //                            break;
        //                        case XmlNodeType.Text: //Display the text in each element.
        //                            // MessageBox.Show(reader.Value);
        //                            break;
        //                        case XmlNodeType.EndElement: //Display end of element.
        //                            // MessageBox.Show("</" + reader.Name);
        //                            if (reader.Name == "item")
        //                            {
        //                                in_item = false;
        //                            }
        //                            break;
        //                    }

        //                }


        //                // string s = reader.ReadToEnd();
        //                // ds.ReadXml(reader);
        //                return dt;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}

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
