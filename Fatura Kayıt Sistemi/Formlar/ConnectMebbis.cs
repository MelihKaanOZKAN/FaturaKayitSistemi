using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
namespace Fatura_Kayıt_Sistemi.Formlar
{
    public partial class ConnectMebbis : Form
    {
        public ConnectMebbis()
        {
            InitializeComponent();
        }

        private void ConnectMebbis_Load(object sender, EventArgs e)
        {
            webBrowserMebbis.Refresh();


        }

        private void webBrowserMebbis_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            HtmlElementCollection htmlcol = webBrowserMebbis.Document.Images;
            foreach (HtmlElement htmlel in htmlcol)
            {
                string imgUrl = htmlel.GetAttribute("src");
                if (imgUrl.StartsWith("https://mebbis.meb.gov.tr/randomimage.aspx?"))
                {
                    Uri rl = new Uri(imgUrl);
                    webBrowser1.Url = rl;
                    webBrowser1.Refresh();
                }
            }
            Uri url = new Uri("https://mebbis.meb.gov.tr/OTM/otm01001.aspx");
            if (webBrowserMebbis.Url.ToString() == "https://mebbis.meb.gov.tr/main.aspx")
            {
                webBrowserMebbis.Url = url;
                webBrowserMebbis.Refresh();
            }
           else if (webBrowserMebbis.Url.ToString() == "https://mebbis.meb.gov.tr/OTM/otm01001.aspx")
            {
                url = new Uri("https://mebbis.meb.gov.tr/OTM/OTM03001.aspx");
                webBrowserMebbis.Url = url;
                webBrowserMebbis.Refresh();
            }
          else  if (webBrowserMebbis.Url.ToString() == "https://mebbis.meb.gov.tr/OTM/otm01001.aspx")
            {
                url = new Uri("https://mebbis.meb.gov.tr/OTM/OTM03001.aspx");
                webBrowserMebbis.Url = url;
                webBrowserMebbis.Refresh();
            }
            else if (webBrowserMebbis.Url.ToString() == "https://mebbis.meb.gov.tr/OTM/OTM03001.aspx")
            {
               webBrowserMebbis.Document.GetElementById("incToolbarActive1_yeniKayit_b").GetElementsByTagName("img")[0].InvokeMember("click");
                while (webBrowserMebbis.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
                    List<string> Subs = new List<string>();
                    List<string> values = new List<string>();
            HtmlElement element = webBrowserMebbis.Document.GetElementById("cmbAboneNo");
                // element = element.GetElementsByTagName("cmbAboneNo")[0];
                Clipboard.SetText(element.InnerHtml);
                    MessageBox.Show(element.GetAttribute("opinion"));


                    object objElement = element.DomElement;
                    object objSelectedIndex = objElement.GetType().InvokeMember("selectedIndex",
                    BindingFlags.GetProperty, null, objElement, null);
                    int selectedIndex = (int)objSelectedIndex;
                    if (selectedIndex != -1)
                    {
                        Subs.Add(element.Children[selectedIndex].InnerText);
                    }
                    foreach (HtmlElement item in element.Children)
                    {
                        if (item.GetAttribute("value") == webBrowserMebbis.Document.GetElementById("cmbAboneNo").GetAttribute("value"))
                        {
                            values.Add(item.GetAttribute("value"));
                        }
                    }

                    
            }

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowserMebbis.Document.GetElementById("txtKullaniciAd").SetAttribute("value", textBox1.Text);
            webBrowserMebbis.Document.GetElementById("txtSifre").SetAttribute("value", textBox2.Text);
            webBrowserMebbis.Document.GetElementById("txtGuvenlikKod").SetAttribute("value", textBox3.Text);
            webBrowserMebbis.Document.GetElementById("btnGiris").InvokeMember("click");
        }
    }
}

