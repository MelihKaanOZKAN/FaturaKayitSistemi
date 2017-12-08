using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Fatura_Kayıt_Sistemi
{
    public partial class CreatorDB : Form
    {
        private string LogoPath;
        private bool setup = false;
        public CreatorDB()
        {
            InitializeComponent();
        }
        
        private static void Create_TableNew(List<SqlParameter> paramList, string DBUserName)
        {
            string query = String.Empty;
            query = "CREATE TABLE [dbo].[ProgramSettings]"+
                     "(" +
                      "  [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                      "  [SetName]" +
                      "     NVARCHAR(MAX)," +
                      " [SetValue] NVARCHAR(MAX)," +
                      " [ProgramLogo] VARBINARY(MAX)" +
                     ")";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[SchoolTypebyId]" +
                 "(" +
                 "SchoolType NVARCHAR(MAX)," +
                 "SchoolTypeId INT PRIMARY KEY IDENTITY (1,1)," +
                "[Code] NVARCHAR(20)" + 
                 ");";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[UserList]" +
                    "(" +
                       " [UserId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                        "[UserName] NVARCHAR(MAX) NOT NULL," +
                       " [UserPassword] NVARCHAR(MAX) NOT NULL," +
                       " [UserInfo] NVARCHAR(30)," +
                        "[UserPerm] NVARCHAR(MAX) NOT NULL," +
                        "[UserPermList] NVARCHAR(MAX)" +
                        "[UserSchoolId] INT" +
                    ")";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[CompanyList]"+
                    "("+
                        "[CompanyId]    INT NOT NULL PRIMARY KEY IDENTITY(1000,1), "+
                        "[CompanyName] NVARCHAR(60) NOT NULL,"+
                        "[CompanyType] NVARCHAR(15) NOT NULL,"+
                        "[CompanyInfo] NVARCHAR(MAX) NULL," +
                        "[CompanyBank] NVARCHAR(MAX) NOT NULL, " +
                        "[CompanyIBAN] NVARCHAR(MAX) NOT NULL," +
                        "[UnitPrice] FLOAT" +
                    ")";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[SubTypebyID] (" +
                "[SubType] NVARCHAR(MAX) NOT NULL," +
                "[SubId] INT NOT NULL PRIMARY KEY IDENTITY(1000,1)," +
                "[CompanyId] INT," +
                "[Code] NVARCHAR(20)," +
                "CONSTRAINT FK_SubtoCompany FOREIGN KEY (CompanyId) REFERENCES [dbo].[CompanyList]([CompanyId]) ON UPDATE CASCADE ON DELETE SET NULL" +
                ");";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[SchoolInfo]" +
                   "(" +
                      " [SchoolId] INT NOT NULL PRIMARY KEY IDENTITY(1000,1), " +
                      " [SchoolName] NVARCHAR(MAX) NOT NULL," +
                      " [SchoolType] INT NOT NULL" +
                   ")";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[Subs] (" +
                "[SubNumberId] INT IDENTITY(1,1) PRIMARY KEY, " +
                "[SchoolID] INT NOT NULL," +
                "[SubId] INT," +
                "[SubNumber] BIGINT NOT NULL, " +
                "CONSTRAINT FK_BillID FOREIGN KEY (SubId) REFERENCES [dbo].[SubTypebyID]([SubId]) ON UPDATE CASCADE ON DELETE SET NULL,  " +
                "CONSTRAINT FK_SchoolID_Subs FOREIGN KEY (SchoolID) REFERENCES [dbo].[SchoolInfo]([SchoolId])  ON UPDATE CASCADE ON DELETE CASCADE" +
                ");";
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[Payments] (" +
                "[PaymentId] DECIMAL(38,0) PRIMARY KEY IDENTITY (1000,1)," +
                "[SubTypeId] INT," +
                "[PaymentDate] DATE," +
                "[PaymentConfirmDate] DATE," +
                "[PaymentAmount] DECIMAL(18,2)," +
                "[PaymentTax] DECIMAL (18,2)," +
                "[PaymentConsumption] DECIMAL(18,2)," +
                "[PaymentCreatorPerson] INT," +
                "[PaymentConfirmPerson] INT," +
                "[PaymentNote] NVARCHAR(MAX)," +
                "[PaymentStatus] INT, "+
                "[OrderOfPaymentNumber] DECIMAL(38,0)," +
                "[OrderOfPaymentConfirmDate] DATE," +
                "CONSTRAINT FK_Payment_SubTypeId FOREIGN KEY (SubTypeId) REFERENCES [dbo].[SubTypebyID] ([SubId]) ON UPDATE CASCADE ON DELETE NO ACTION," +
                ");"; ;
            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[Bills] (" +
                "[BillId] INT NOT NULL," +
                "[SchoolId] INT," +
                "[BillTypeId] INT," +
                "[BillDate] DATE NOT NULL," +
                "[BillLastPayDate] DATE NOT NULL," +
                "[BillConsumption] INT," +
                "[BillAmount] DECIMAL(18,2) NOT NULL," +
                "[BillTax] DECIMAL(18,2) NOT NULL," +
                "[BillStatus] BIT," +
                "[addMebbis] BIT," +
                "[BillImage] VARBINARY(MAX)," +
                "[PaymentId] DECIMAL(38,0), "+
                "CONSTRAINT FK_SchoolID_Bill FOREIGN KEY (SchoolID) REFERENCES [dbo].[SchoolInfo]([SchoolId]) ON UPDATE CASCADE ON DELETE SET NULL,  " +
                "CONSTRAINT FK_BillTypeId FOREIGN KEY (BillTypeID) REFERENCES [dbo].[Subs]([SubNumberId])  ON UPDATE CASCADE ON DELETE SET NULL" +
                ");";

            Connect_DB.sendQuery(query);

            query = "CREATE TABLE [dbo].[BillsCorrect] (" +
              "[BillId] INT NOT NULL," +
              "[SchoolId] INT," +
              "[BillTypeId] INT," +
              "[BillDate] DATE NOT NULL," +
              "[BillLastPayDate] DATE NOT NULL," +
              "[BillConsumption] INT," +
              "[BillAmount] DECIMAL(18,2) NOT NULL," +
              "[BillTax] DECIMAL(18,2) NOT NULL," +
              "[BillStatus] BIT," +
              "[addMebbis] BIT," +
              "[BillImage] VARBINARY(MAX)," +
              "[PaymentId] DECIMAL(38,0), " +
              "CONSTRAINT FK_SchoolID_Bill_Co FOREIGN KEY (SchoolID) REFERENCES [dbo].[SchoolInfo]([SchoolId]) ON UPDATE CASCADE ON DELETE SET NULL,  " +
              "CONSTRAINT FK_BillTypeId_Co FOREIGN KEY (BillTypeID) REFERENCES [dbo].[Subs]([SubNumberId])  ON UPDATE CASCADE ON DELETE SET NULL" +
              ");";

            Connect_DB.sendQuery(query);
            query = "GRANT select, update, insert, delete on schema::dbo TO  " + DBUserName + ";";

            query += "INSERT INTO [dbo].[UserList] ([UserName], [UserPassword], [UserPerm]) VALUES (@paramUserName, @paramUserPass, 'Admin'); ";

            query += " INSERT INTO [dbo].[ProgramSettings] ([SetName], [SetValue], [ProgramLogo]) VALUES (@paramSetName, @paramSetValue, @paramLogo); ";
           // query += " INSERT INTO [dbo].[ProgramSettings] ([SetName]) VALUES ('BillNames');";
            Connect_DB.sendQuery(query, paramList);
        }

        private void Admin_Username_Tbox_Validating(object sender, CancelEventArgs e)
        {
            if (Admin_Username_Tbox.Text.Trim() == "")
                errorProvider1.SetError(Admin_Username_Tbox, "Kullanıcı Adını Girmelisiniz");
            else
                errorProvider1.SetError(Admin_Username_Tbox, "");

        }

        private void Kurum_Logo_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sec = new OpenFileDialog();
                sec.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
                if (sec.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = sec.FileName;
                    lbl_filename.Text = sec.SafeFileName;
                    LogoPath = DosyaYolu;
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CreatorDB_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_Veritabani_Kurma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Veritabani_Kurma.Checked == true)
            {
                Kurum_Bilgi_Gbox.Enabled = false;
                Yönetici_Bilgi_Gbox.Enabled = false;
            }
            else
            {
                Kurum_Bilgi_Gbox.Enabled = true;
                Yönetici_Bilgi_Gbox.Enabled = true;
            }
        }

        private void Admin_Pass_Tbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Admin_Pass_Tbox.Text.Trim() == "")
                    errorProvider1.SetError(Admin_Pass_Tbox, "Yönetici Şifresini Girmelisiniz");
                else
                    errorProvider1.SetError(Admin_Pass_Tbox, "");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Pass_Re_Tbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Admin_Pass_Tbox.Text.Trim() == "")
                    errorProvider1.SetError(Admin_Pass_Re_Tbox, "Şifrenizi Tekrar Girmelisiniz");
                else
                    errorProvider1.SetError(Admin_Pass_Re_Tbox, "");
                if (Admin_Pass_Tbox.Text != Admin_Pass_Re_Tbox.Text)
                    errorProvider1.SetError(Admin_Pass_Re_Tbox, "Şifreler Uyuşmuyor");
                else
                    errorProvider1.SetError(Admin_Pass_Re_Tbox, "");
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string Encrypt(string gelen)
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
        private static string EncryptToBase64(string text)
        {
            byte[] EncryptAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            string value = System.Convert.ToBase64String(EncryptAsBytes);
            return value;
        }

        private void Btn_Setup_Click(object sender, EventArgs e)
        {
            try
            { if (checkBox_Veritabani_Kurma.Checked == false)
                {
                    if (Admin_Pass_Tbox.Text != "" && Admin_Pass_Re_Tbox.Text != "" && Admin_Username_Tbox.Text != "" && Tbox_Server_ADress.Text != "" && Tbox_Server_K_Adı.Text != "" && Tbox_Server_Pass.Text != "")
                    {
                        if (Admin_Pass_Tbox.Text == Admin_Pass_Re_Tbox.Text)
                        {
                            Save_INI INI = new Save_INI();
                            string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                            string specificFolder = Path.Combine(filePath, "Kayıt Otomasyonu");
                            Directory.CreateDirectory(specificFolder);
                            specificFolder = specificFolder + @"\ayarlar_beta.ini";
                            INI.Path = specificFolder;
                            INI.Write("program", "durum", "kurulmadı");
                            INI.Write("veritabanı", "adres", Tbox_Server_ADress.Text);
                            INI.Write("veritabanı", "port", Tbox_Server_Port.Text);
                            INI.Write("veritabanı", "kullanıcı_adı", Tbox_Server_K_Adı.Text);
                            INI.Write("veritabanı", "sifre", EncryptToBase64(Tbox_Server_Pass.Text));
                            INI.Write("veritabanı", "isim", Tbox_databaseName.Text);
                            
                            List<SqlParameter> paramList = new List<SqlParameter>();
                            paramList.Add(new SqlParameter("@paramUserName", Admin_Username_Tbox.Text));
                            paramList.Add(new SqlParameter("@paramUserPass", Encrypt(Admin_Pass_Tbox.Text)));
                            paramList.Add(new SqlParameter("@paramSetName", "CompanyName"));
                            paramList.Add(new SqlParameter("@paramSetValue", Kurum_Adi_TBox.Text));

                            byte[] byteResim = null;
                            FileInfo fInfo = new FileInfo(LogoPath);
                            long sayac = fInfo.Length;
                            FileStream fStream = new FileStream(LogoPath, FileMode.Open, FileAccess.Read);
                            BinaryReader bReader = new BinaryReader(fStream);
                            byteResim = bReader.ReadBytes((int)sayac);

                            paramList.Add(new SqlParameter("@paramLogo", byteResim));

                            Create_TableNew(paramList, Tbox_Server_K_Adı.Text);
                            INI.Write("program", "durum", "kuruldu");

                            MessageBox.Show("Kurulum Tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            setup = true;
                            Application.Restart();

                        }
                        else
                        {
                            MessageBox.Show("Şifreler uyuşmuyor veya yönetici bilgileri geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            else
                {
                    Save_INI INI = new Save_INI();
                    string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                    string specificFolder = Path.Combine(filePath, "Fatura Kayıt Sistemi");
                    Directory.CreateDirectory(specificFolder);
                    specificFolder = specificFolder + @"\ayarlar_beta.ini";
                    INI.Path = specificFolder;
                    INI.Write("program", "durum", "kuruldu");
                    INI.Write("veritabanı", "adres", Tbox_Server_ADress.Text);
                    INI.Write("veritabanı", "port", Tbox_Server_Port.Text);
                    INI.Write("veritabanı", "kullanıcı_adı", Tbox_Server_K_Adı.Text);
                    INI.Write("veritabanı", "sifre", EncryptToBase64(Tbox_Server_Pass.Text));
                    INI.Write("veritabanı", "isim", Tbox_databaseName.Text);
                    Application.Restart();
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreatorDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!setup)
            {
                Application.Exit();
            }
        }
    }
}
