using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_Kayıt_Sistemi
{
    class Lisans
    {
        public static bool LocalLisans()
        {
            try {
                string Email = "null";
                string Lisans = "null";
                string Activator_ = "null";
                Save_INI INI = new Save_INI();
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Fatura Kayıt Sistemi");
                Directory.CreateDirectory(specificFolder);
                specificFolder = specificFolder + @"\ayarlar_beta.ini";
                INI.Path = specificFolder;
                Email = INI.Read("Lisans", "Email");
                Lisans = INI.Read("Lisans", "Lisans");
                Activator_ = INI.Read("Lisans", "Activator");
                WebService_.WebService_SoapClient Update = new WebService_.WebService_SoapClient();
                string content = Update.CheckLisance(Email, Lisans, Activator_);
                switch (content)
                {
                    case "true":
                        {
                            bool update = false;
                            content = Update.CheckUpdate(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion);
                            string[] dönenVeri = content.Split('&');
                            if (dönenVeri[0] == "UPDATE")
                            {
                                update = true;
                            }
                            if (update)
                            {
                                DialogResult dialog = MessageBox.Show("Yeni güncellemeler var. \n\rŞimdi Yüklemek istermisiniz? \n\r Şuanki Versiyon: " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + "\n\r Güncel Versiyon: " + dönenVeri[1], "Güncelleme Bulundu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dialog == DialogResult.Yes)
                                {
                                    Process.Start(dönenVeri[2]);
                                    System.Windows.Forms.Application.Exit();
                                }
                            }
                            return true;
                        }
                    case "err_activator":
                        {
                            MessageBox.Show("Aktivayon Kodunuz Hatalı. Lütfen Destek İle Konuşun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            break;
                        }
                    case "err_key":
                        {
                            MessageBox.Show("Lisansınız Hatalı. Lütfen  Yeniden Girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lisans_giris form = new lisans_giris();
                            form.Show();
                            Modul form2 = new Modul();
                            form2.Hide();
                            return false;
                        }
                    case "err_status":
                        {
                            MessageBox.Show("Lisansınız Pasif Durumda. Lütfen Tekrar Girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Modul form2 = new Modul();
                            form2.Hide();
                            return false;
                        }
                    case "err_query":
                        {
                            MessageBox.Show("Email adresiniz sistemde bulunamadı. Lütfen tekrar girin veya destek ile konuşun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Modul form2 = new Modul();
                            lisans_giris form = new lisans_giris();
                            form.Show();
                            if (Modul.durum == true)
                            {
                                form2.Hide();
                            }
                            return false;
                        }
                }
            }
            catch //(System.Net.Sockets.SocketException)
            {
                return true;
            }

            return false;
        }
    }
}
