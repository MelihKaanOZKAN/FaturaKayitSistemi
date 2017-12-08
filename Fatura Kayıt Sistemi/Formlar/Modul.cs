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
using System.Runtime.Serialization;
using Fatura_Kayıt_Sistemi.Formlar;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Modul : Form
    {
        public static Modul ModulObject;
        public static bool durum = false;
        public static string CompanyName = "";
        public Modul()
        {
            InitializeComponent();
        }
        
        private void Modul_Load(object sender, EventArgs e)
        {
            try
            {
                ModulObject = this;
                Connect_DB db = new Connect_DB();
                string query;
                Modul.durum = true;
                Save_INI INI = new Save_INI();
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Kayıt Otomasyonu");
                Directory.CreateDirectory(specificFolder);
                specificFolder = specificFolder + @"\ayarlar_beta.ini";
                INI.Path = specificFolder;
                string durum = INI.Read("program", "durum");
                if (durum == "kuruldu")
                {
                    query = "SELECT SetValue FROM [dbo].[ProgramSettings] WHERE SetName = 'CompanyName'";

                    DataTable dt = Connect_DB.getQuery(query);
                    CompanyName = dt.Rows[0]["SetValue"].ToString();

                    query = "SELECT ProgramLogo FROM [dbo].[ProgramSettings] WHERE SetName = 'CompanyName'";

                    /*MemoryStream stream = new MemoryStream();
                 System.Xml.Serialization.XmlSerializer formatter = new System.Xml.Serialization.XmlSerializer(typeof(object[]));
                  dt.RemotingFormat = SerializationFormat.Binary;
                  formatter.Serialize(stream, DR.ItemArray);*/
                    PB_Logo.Image = Connect_DB.getImage(query);
                    PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                   // PB_Logo.Refresh();
                    this.Text = CompanyName + " Modüller";
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Program bilgileri eksik veya yanlış. Yeniden Oluşturulacak.", "Kritik Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        INI.Path = Application.StartupPath + "ayarlar.ini";
                        INI.Write("program", "durum", "kurulmadı");
                        CreatorDB form = new CreatorDB();
                        form.ShowDialog();
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login_Fatura_Kayit_Sistemi form = new Login_Fatura_Kayit_Sistemi();
                Login_Fatura_Kayit_Sistemi.mode = "FKS";
                form.Show();
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void Modul_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_check_update_Click(object sender, EventArgs e)
        {
            try
            {
                Update_Program.UpdateKontrol();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKayıtAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Login_Fatura_Kayit_Sistemi form = new Login_Fatura_Kayit_Sistemi();
                Login_Fatura_Kayit_Sistemi.mode = "Settings";
                form.Show();
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConnectMebbis form = new ConnectMebbis();
            form.Show();
        }
    }
}
