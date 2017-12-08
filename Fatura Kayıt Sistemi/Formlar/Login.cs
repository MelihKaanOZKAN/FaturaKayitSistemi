using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Fatura_Kayıt_Sistemi.Formlar;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Login_Fatura_Kayit_Sistemi : Form
    {

        private const int SC_CLOSE = 0xF060;
        private const int MF_GRAYED = 0x1;
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

        private bool debugLogin = false;
        public static string mode;
        public Login_Fatura_Kayit_Sistemi()
        {
            try
            {
                InitializeComponent();
            }
            catch
            {
            }
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_GRAYED);
                Save_INI INI = new Save_INI();
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Kayıt Otomasyonu");
                Directory.CreateDirectory(specificFolder);
                specificFolder = specificFolder + @"\ayarlar_beta.ini";
                INI.Path = specificFolder;
                string CompanyName = "";
                    string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                    DataTable dt = Connect_DB.getQuery(query);
                    CompanyName = dt.Rows[0]["SetValue"].ToString();


                    query = "SELECT [ProgramLogo] FROM [dbo].[ProgramSettings] ";
                    PB_Logo.Image = Connect_DB.getImage(query);
                    PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                    string form_adi = CompanyName + " Kullanıcı Girişi";
                    this.Text = form_adi;
                    if (mode == "FKS")
                    {
                         form_adi = CompanyName + " Fatura Kayıt Sistemi Giriş Ekranı";
                        this.Text = form_adi;
                    }
                    if (mode == "Settings")
                    {
                         form_adi = CompanyName + " Yönetim Paneli Giriş Ekranı";
                        this.Text = form_adi;
                    }
                
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
                DialogResult dr = MessageBox.Show("Kayıt defteri bilgileri eksik veya yanlış. Yeniden Oluşturulacak.", "Kritik Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    Save_INI INI = new Save_INI();
                    INI.Path = Application.StartupPath + "ayarlar.ini";
                    INI.Write("program", "durum", "kurulmadı");
                    Application.Restart();
                }
                else if (dr == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }

        }

        public static string Encrypt(string gelen)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(gelen);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string permMain = "";
            try
            {
                var query="";
                query = "SELECT [UserPassword], [UserInfo],  [UserPerm], [UserPermList], [UserId], [UserSchoolId] FROM [dbo].[UserList] WHERE [UserName]=@paramUserName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramUserName", Tbox_Username.Text));
                string EncyrptedPass = "";
                DataTable dt = Connect_DB.getQuery(query, paramList);
                try
                {
                     EncyrptedPass = dt.Rows[0]["UserPassword"].ToString();
                    MainForm_Fatura_Kayıt.unvan = dt.Rows[0]["UserInfo"].ToString();
                    MainForm_Fatura_Kayıt.permList = dt.Rows[0]["UserPermList"].ToString();
                    permMain = dt.Rows[0]["UserPerm"].ToString();
                }
                catch
                {
                    MessageBox.Show("Kullanıcı Bulunamadı. Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (EncyrptedPass == Encrypt(Tbox_Pass.Text) || debugLogin)
                {
                    if (mode == "FKS")
                    {
                        MainForm_Fatura_Kayıt form1 = new MainForm_Fatura_Kayıt();
                        MainForm_Fatura_Kayıt.k_adi = Tbox_Username.Text;
                        MainForm_Fatura_Kayıt.userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                        MainForm_Fatura_Kayıt.SchoolId = Convert.ToInt32(dt.Rows[0]["UserSchoolId"]);
                        MainForm_Fatura_Kayıt.perm = permMain;
                        this.Close();
                        form1.Show();
                    }
                    else if (mode == "Settings" && permMain == "Admin")
                    {
                        ProgramAyarları form = new ProgramAyarları();
                        this.Close();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yetkisiz İşlem.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                };
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modülSayfasınaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Modul.ModulObject.Show();
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
