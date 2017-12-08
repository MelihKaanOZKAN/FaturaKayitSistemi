using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;/*
using System.Data.Sql;
using System.Data.SqlClient;*/

namespace Fatura_Kayıt_Sistemi
{
    public partial class lisans_giris : Form
    {/*
        public static SqlConnection con;
        public static SqlCommand command = new SqlCommand();
        public static string query = "";*/
        public lisans_giris()
        {
            InitializeComponent();
            /*
            con = new SqlConnection(@"Data Source=software-lisansla.database.windows.net; User ID=System_Root; Password=MKOzkan1490; Initial Catalog=program_lisans");
            command.Connection = con;
            con.Open();
            query = "CREATE TABLE lisans_bilgi( kullanici_adi NVARCHAR(100), program_key NVARCHAR(25), activator NVARCHAR(150), status NVARCHAR(10))";
            command.CommandText = query;
            command.ExecuteNonQuery();
            con.Close();*/
        }

        private void BTN_Dogrula_Click(object sender, EventArgs e)
        {
            string lisans = Tbox_lisans_1.Text + "-" + Tbox_lisans_2.Text + "-" + Tbox_lisans_3.Text + "-" + Tbox_lisans_4.Text + "-" + Tbox_lisans_5.Text;
            Save_INI INI = new Save_INI();
            string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(filePath, "Fatura Kayıt Sistemi");
            Directory.CreateDirectory(specificFolder);
            specificFolder = specificFolder + @"\ayarlar_beta.ini";
            INI.Path = specificFolder;
            INI.Write("Lisans", "Email", Tbox_Email.Text);
            INI.Write("Lisans", "Lisans",lisans);
            INI.Write("Lisans", "Activator", create_activator());
            if (Lisans.LocalLisans())
            {
                Modul form = new Modul();
                form.Show();
                this.Close();
            }
        }
         protected string create_activator()
        {
            string anahtar = "";
            try
            {
                var cpuid = string.Empty;
                ManagementClass managClass = new ManagementClass("win32_processor");
               System.Management.ManagementObjectCollection managCollec = managClass.GetInstances();
                foreach (ManagementObject managObj in managCollec)
                {
                    cpuid = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
                anahtar = cpuid.Trim();
                anahtar = sifreleMD5(anahtar);
            }
            catch 
            {
                MessageBox.Show("Lisans Anahtarı Oluşturulamıyor.", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Clipboard.SetText(anahtar);
            return anahtar;
        }
        public static string sifreleMD5(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(input);
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        private void Tbox_Lisans_1_TextChanged(object sender, EventArgs e)
        {
            if (Tbox_lisans_1.TextLength == 5)
            {
                Tbox_lisans_2.Focus();
            }
        }

        private void Tbox_lisans_2_TextChanged(object sender, EventArgs e)
        {
            if (Tbox_lisans_2.TextLength == 5)
            {
                Tbox_lisans_3.Focus();
            }
            if (Tbox_lisans_2.TextLength == 0)
            {
                Tbox_lisans_1.Focus();
            }
        }

        private void Tbox_lisans_3_TextChanged(object sender, EventArgs e)
        {
            if (Tbox_lisans_3.TextLength == 5)
            {
                Tbox_lisans_4.Focus();
            }
            if (Tbox_lisans_3.TextLength == 0)
            {
                Tbox_lisans_2.Focus();
            }
        }

        private void Tbox_lisans_4_TextChanged(object sender, EventArgs e)
        {
            if (Tbox_lisans_4.TextLength == 5)
            {
                Tbox_lisans_5.Focus();
            }
            if (Tbox_lisans_4.TextLength == 0)
            {
                Tbox_lisans_3.Focus();
            }
        }

        private void Tbox_lisans_5_TextChanged(object sender, EventArgs e)
        {
            
            if (Tbox_lisans_5.TextLength == 0)
            {
                Tbox_lisans_4.Focus();
            }
        }

        private void lisans_giris_Load(object sender, EventArgs e)
        {
        }
    }
}
