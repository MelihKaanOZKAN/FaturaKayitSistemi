using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Harcama_Talimati_Olusturucu : Form
    {
        public int PaymentId = 0;
        public int CompanyId = 0;
        private string CompanyName;
        private string[] bütceCode = new string[2];
        public Harcama_Talimati_Olusturucu()
        {
            InitializeComponent();
        }

        private void fillCompayInfo(int CompanyId)
        {
            try
            {

               string  query = "SELECT " +
                        "[CompanyName]," +
                        "[CompanyBank], " +
                        "[CompanyIBAN]" +
                        "FROM [dbo].[CompanyList]  WHERE CompanyId=@paramCompanyId";


                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramCompanyId", CompanyId));
                DataTable dt = Connect_DB.getQuery(query, paramList);

                Tbox_Kurum_Adı.Text = dt.Rows[0][0].ToString();
                Tbox_Kurum_Banka.Text = dt.Rows[0][1].ToString();
                Tbox_İban.Text = dt.Rows[0][2].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fillPaymentInfo(int PaymentId)
        {
            try
            {
                string query = "SELECT " +
                    "CompanyId," +
                  "SubTypeId," +
                  "SBT.SubType, " +
                  "PaymentAmount," +
                  "py.[SchoolTypeId]," +
                  "SCT.SchoolType  " +
                  "FROM dbo.Payments py " +
                  "left join  [dbo].[UserList] UL on UL.[UserId] = py.[PaymentConfirmPerson] " +
                  "left join [dbo].[SubTypebyId] SBT on SBT.[SubId] = py.[SubTypeId] " +
                  "left join [dbo].[SchoolTypebyId] SCT on SCT.[SchoolTypeId] = py.[SchoolTypeId] " +
                  "WHERE py.[PaymentId] = @paramPaymentId";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramPaymentId", this.PaymentId));
                DataTable dt = Connect_DB.getQuery(query, paramList);

                int CompanyId = Convert.ToInt32(dt.Rows[0][0].ToString());
                fillCompayInfo(CompanyId);
                Cbox_Fatura_Türü.SelectedItem = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                Tbox_Fatura_Tutar.Text = dt.Rows[0][3].ToString() + " TL";
                Cbox_Okul_Türü.Text = dt.Rows[0][4].ToString() + " " + dt.Rows[0][5].ToString();
                query = "SELECT COUNT(BillId) FROM [dbo].[Bills] WHERE [PaymentId] = @paramPaymentId ";
                dt = Connect_DB.getQuery(query, paramList);
                Tbox_Fatura_Adet.Text = dt.Rows[0][0].ToString();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Filltxt()
        {
            bool result = false;
            try
            {
                Butce_Yazdır();
                string[] tmp = Cbox_Okul_Türü.SelectedItem.ToString().Split(' ');
                string[] tmp2 = Cbox_Fatura_Türü.SelectedItem.ToString().Split(' ');
                rTboxAciklama.Text = CompanyName  + " " + tmp[1] + " " +
                       tmp2[1] + " Faturalarının bedeli olan ücretinin " +
                       Tbox_Kurum_Adı.Text + " adına " + Tbox_Kurum_Banka.Text + " " + Tbox_İban.Text + " nolu hesabına aktarılması";

                rTboxisinTanimi.Text = CompanyName + " " + tmp[1] + " Kurumu/Kurumları  "+
                       tmp2[1] + " Faturalarının Faturaları Giderlerinin Ödenilmesi";
                rTboxisinNiteligi.Text = tmp2[1] + " Gideri Faturaları";
                result = true;
            }
            catch(NullReferenceException err)
            {
                MessageBox.Show("Seçimlerde Eksiklik Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return result;
        }

        private void fillBillTypes()
        {
            try
            {
                string query = "SELECT [SubId], [SubType] FROM [dbo].[SubTypebyId]";
                DataTable dt = Connect_DB.getQuery(query);
                Cbox_Fatura_Türü.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cbox_Fatura_Türü.Items.Add(dt.Rows[i]["SubId"].ToString() + " " + dt.Rows[i]["SubType"].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fillSchoolType()
        {
            try
            {
                string query = "SELECT [SchoolTypeId], [SchoolType] FROM [dbo].[SchoolTypebyId]";
                DataTable dt = Connect_DB.getQuery(query);
                Cbox_Okul_Türü.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cbox_Okul_Türü.Items.Add(dt.Rows[i]["SchoolTypeId"].ToString() + " " + dt.Rows[i]["SchoolType"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Harcama_Talimati_Olusturucu_Load(object sender, EventArgs e)
        {
            try
            {
             string  query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                this.CompanyName = dt.Rows[0][0].ToString();
                this.Text = this.CompanyName + " - Harcama Talimatı Oluştur";
                fillSchoolType();
                fillBillTypes();
                if (this.CompanyId != 0)
                {
                    fillCompayInfo(this.CompanyId);
                }
                if (this.PaymentId != 0)
                {
                    fillPaymentInfo(this.PaymentId);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbox_Fatura_Türü_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT [Code] FROM [dbo].[SubTypebyId] WHERE [SubId] = @paramSubId";
                string[] tmp = Cbox_Fatura_Türü.SelectedItem.ToString().Split(' ');
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubId", Convert.ToInt32(tmp[0])));
                DataTable dt = Connect_DB.getQuery(query, paramList);

                bütceCode[1] = dt.Rows[0][0].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbox_Okul_Türü_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT [Code] FROM [dbo].[SchoolTypebyId] WHERE [SchoolTypeId] = @paramTypeId";
                string[] tmp = Cbox_Okul_Türü.SelectedItem.ToString().Split(' ');
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramTypeId", Convert.ToInt32(tmp[0])));
                DataTable dt = Connect_DB.getQuery(query, paramList);

                bütceCode[0] = dt.Rows[0][0].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Butce_Yazdır()
        {
            try
            {
                Tbox_Butce_Kodu.Text = null;

                Tbox_Butce_Kodu.Text = bütceCode[0].TrimEnd() + "." + bütceCode[1].TrimEnd();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void save()
        {
            try
            {
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Fatura Kayıt Sistemi");
                Directory.CreateDirectory(specificFolder);
                string filepath = specificFolder + @"\Talimat.pdf";

                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }

                pdfOlustur(filepath);

                Process.Start(filepath);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        private void pdfOlustur(string dosyaYolu)
        {

            try
            {
                iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();
                PdfWriter.GetInstance(pdfDosya, new FileStream(dosyaYolu, FileMode.Create));
                iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 9, iTextSharp.text.Font.BOLD);
                pdfDosya.Open();
                pdfDosya.AddCreator("Fatura Kayıt Sistemi");
                pdfDosya.AddCreationDate();
                pdfDosya.AddAuthor("Battalgazi İlçe Milli Eğitim Müdürlüğü");
                pdfDosya.AddHeader("", "Harcama Talimatı");
                Paragraph p = new Paragraph("HARCAMA TALİMATI", fontBold);
                p.Alignment = Element.ALIGN_CENTER;
                pdfDosya.Add(p);
                pdfDosya.Add(new Chunk("\n"));
                PdfPTable table = new PdfPTable(2);
                PdfPCell cell = new PdfPCell(new Paragraph("İDARENİN ADI: ", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                //   PdfPCell cell = new PdfPCell(new Paragraph("İDARENİN ADI: ", fontBold));  cell.BackgroundColor = BaseColor.GRAY;           table.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Battalgazi İlçe Milli Eğitim Müdürlüğü", fontNormal)); cell.BackgroundColor = BaseColor.WHITE; table.AddCell(cell);
                cell = new PdfPCell((new Paragraph("BELGE TARİH VE SAYISI: ", fontBold))); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                cell = new PdfPCell(new Paragraph("")); table.AddCell(cell);
                

                cell = new PdfPCell(new Paragraph("GİDER İLE İLGİLİ BİLGİLER", fontBold)); cell.Colspan = 2; cell.BackgroundColor = BaseColor.GRAY; cell.HorizontalAlignment = Element.ALIGN_CENTER; table.AddCell(cell);
                cell.Colspan = 0;
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                cell = new PdfPCell(new Paragraph("İŞİN TANIMI:", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                table.AddCell(new Paragraph(rTboxisinTanimi.Text, fontNormal));

                cell = new PdfPCell(new Paragraph("İŞİN NİTELİĞİ: ", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                table.AddCell(new Paragraph(rTboxisinNiteligi.Text, fontNormal));

                cell = new PdfPCell(new Paragraph("İŞİN MİKTARI: ", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                table.AddCell(new Paragraph(Tbox_Fatura_Adet.Text + " ADET", fontBold));

                cell = new PdfPCell(new Paragraph("KULLANILABİLİR ÖDENEK TUTARI: ", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                table.AddCell(new Paragraph(Tbox_Fatura_Tutar.Text, fontBold));

                cell = new PdfPCell(new Paragraph("BÜTÇE TERTİBİ: ", fontBold)); cell.BackgroundColor = BaseColor.GRAY; table.AddCell(cell);
                table.AddCell(new Paragraph(Tbox_Butce_Kodu.Text, fontNormal));

                cell = new PdfPCell(new Paragraph("GİDER İLE İLGİLİ DİĞER AÇIKLAMALAR", fontBold));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER; cell.BackgroundColor = BaseColor.GRAY;
                table.AddCell(cell);
                cell = new PdfPCell((new Paragraph(rTboxAciklama.Text, fontNormal))); cell.Colspan = 2; cell.HorizontalAlignment = Element.ALIGN_LEFT; cell.BackgroundColor = BaseColor.WHITE; table.AddCell(cell);
                cell.Colspan = 0;
                cell = new PdfPCell(new Paragraph("\n\n\n  Yukarıda  miktarı ve adeti belirtilen fatura giderinin ödenilmesi hususunu \n onaylarınıza arz ederim. \n  Gerçekleştirme Görevlisi \n " + DateTime.Now + "\n\n\n\n\n" + "Adı Soyadı: " + Tbox_G_GörevliAdi.Text + "  \n Ünvanı: " + Tbox_G_GörevliUnvanı.Text + " \n\n\n\n\n", fontNormal)); cell.Rowspan = 10; cell.HorizontalAlignment = Element.ALIGN_CENTER; table.AddCell(cell);
                cell = new PdfPCell(new Paragraph(" \n\n\n Uygundur \n  Harcama Yetkilisi \n " + DateTime.Now + "\n\n\n\n\n\n\n" + "Adı Soyadı: " + Tbox_H_YetkiliAdi.Text + "  \n Ünvanı: " + Tbox_H_YetkiliUnvanı.Text + " \n\n\n\n\n", fontNormal)); cell.Rowspan = 10; cell.HorizontalAlignment = Element.ALIGN_CENTER; table.AddCell(cell);
                
                pdfDosya.Add(table);
                pdfDosya.Close();
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Harcama_Talimati_Olusturucu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Harcama_Talimati_Olusturucu form = new Fatura_Kayıt_Sistemi.Harcama_Talimati_Olusturucu();
            form.Dispose();
        }

        private void Tbox_İban_TextChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Oluştur_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_Oluştur.Text == "Oluştur")
                {
                    if (Filltxt())
                    {
                        BTN_Oluştur.Text = "Kaydet";
                    }
                }
                else
                {
                    save();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
