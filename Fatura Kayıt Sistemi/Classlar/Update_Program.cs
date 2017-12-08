using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_Kayıt_Sistemi
{
    class Update_Program
    {
        public static string versiyon;
        public static string link;
        public static void UpdateKontrol()
        {
            if (CheckUpdate())
            {
                DialogResult dialog = MessageBox.Show("Yeni güncellemeler var. \n\rŞimdi Yüklemek istermisiniz? \n\r Şuanki Versiyon: " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + "\n\r Güncel Versiyon: " + versiyon, "Güncelleme Bulundu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(updateMe));
                    t.Start();
                }
            }
        }

        public static void updateMe()
        {
           Process.Start(link);
            Application.Exit();
        }

        public static Boolean CheckUpdate()
        { 
            Boolean ret;
            try
            {
                WebClient client = new WebClient();
                Clipboard.SetText("http://updateserver.melihozkan.com/check.php?v=" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + "&pID=129e7155-a2ea-41f6-a8a5-77d187c5f4d2");
                Stream stream = client.OpenRead("http://updateserver.melihozkan.com/check.php?v=" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + "&pID=129e7155-a2ea-41f6-a8a5-77d187c5f4d2");
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                string[] dönenVeri = content.Split('&');
                if (dönenVeri[0] == "UPDATE") 
                {
                    ret = true;
                    versiyon = dönenVeri[1];
                    link = dönenVeri[2];
                }
                else
                {
                    ret = false;
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
        }
    }
}
