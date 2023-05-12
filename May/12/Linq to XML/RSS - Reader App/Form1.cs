using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSS___Reader_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            List<News> news = XmlToList();

            listBoxNews.DataSource = news;
        }

        private List<News> XmlToList()
        {
            string url = txtBoxUrl.Text;

            List<News> newsList = new List<News>();

            XDocument xmlSource = XDocument.Load(url);

            List<XElement> rows = xmlSource.Descendants("item").ToList();

            foreach (var item in rows)
            {
                News news = new News();

                news.Header = item.Element("title").Value;
                news.Url = item.Element("link").Value;
                news.Description = item.Element("description").Value;

                newsList.Add(news);
            }

            return newsList;
        }

        private void listBoxNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            News selectedNews = (News)listBox.SelectedItem;

            //newsBrowser.DocumentText = selectedNews.Description;

            newsBrowser.Url = new Uri(selectedNews.Url);
            newsBrowser.ScriptErrorsSuppressed = true;
        }
    }
}
