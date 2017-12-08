using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Fatura_Ekle  : Form
    {
        public Fatura_Ekle()
        {
            InitializeComponent();
        }


        private string ImagePath = String.Empty;
        public int SchoolId = 0;
        private void Tbox_Okul_Adı_TextChanged(object sender, EventArgs e)
        { try {
                if (Tbox_Okul_Adı.Text != "")
                {
                    Gbox_Fatura.Enabled = true;
                    Cbox_Fatura_Durum.SelectedItem = "Ödenmedi";
                    Btn_Fatura_Ekle.Enabled = true;
                }
                else
                {
                    Gbox_Fatura.Enabled = false;
                    Cbox_Fatura_Durum.Text = "";
                    Btn_Fatura_Ekle.Enabled = false;
                }
            }
             catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void TBox_Harcama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Fatura_Ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Dispose();
                GC.Collect();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getId (int SubId, int SchoolTypeId)
        {
            try
            {
                string IdType = SubId + "_" + SchoolTypeId + "_" + DTpic.Value.Month + "_" + DTpic.Value.Year ;
               string query = "IF EXISTS(SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = @paramIdType) " +
                               " BEGIN " +

                              " UPDATE[dbo].[ProgramSettings] SET[SetValue] = [SetValue] + 1 WHERE[SetName] = @paramIdType;" +
                               "SELECT[SetValue] FROM[dbo].[ProgramSettings] WHERE[SetName] = @paramIdType;" +

                               " END  ELSE  BEGIN" +

                               " INSERT INTO[dbo].[ProgramSettings]" +
                                "([SetName], [SetValue]) VALUES(@paramIdType, '0');" +

                              " UPDATE [dbo].[ProgramSettings] SET[SetValue] = [SetValue] + 1 WHERE[SetName] = @paramIdType;" +
                               "SELECT [SetValue] FROM[dbo].[ProgramSettings] WHERE[SetName] = @paramIdType;" +
                               " END  ;";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramIdType", IdType));
                DataTable result = Connect_DB.getQuery(query, paramList);
                String result_ = result.Rows[0]["SetValue"].ToString();
                return Convert.ToInt32(result_);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OCR()
        {
            try
            {/*
                MODI.Document doc = new MODI.Document();


                string file = @"C:\TEST.jpg";// ☜ jpg, gif, tif, pdf, etc.
                doc.Create(file);

                doc.OCR(MODI.MiLANGUAGES.miLANG_TURKISH, true ,true);
                foreach(MODI.Image img in doc.Images)
                {
                    MODI.Layout plan = img.Layout; richTextBox1.Text = plan.Text;
                }
                doc.Close();*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        private int addBill()
        {
            try
            {
                string query;
                String[] temp;
                temp = txtSubType.Text.Split(' ');
                String[] tmp = Tbox_Okul_Adı.Text.Split(' ');

                int billId = getId(Convert.ToInt32(temp[1]), Convert.ToInt32(tmp[1]));

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramBillId", billId));
                paramList.Add(new SqlParameter("@paramBillTypeId", temp[0]));
                temp = Tbox_Okul_Adı.Text.Split(' ');
                paramList.Add(new SqlParameter("@paramSchoolId",temp[0]));
                paramList.Add(new SqlParameter("@paramBillDate", DTpic.Value));
                paramList.Add(new SqlParameter("@paramBillLastPayDate", dtPicLastPay.Value));
                paramList.Add(new SqlParameter("@paramBillConsumption", TBox_Harcama.Text.Trim()));
                paramList.Add(new SqlParameter("@paramBillAmount", Tbox_Tutar.Text.Trim()));
                paramList.Add(new SqlParameter("@paramBillTax", Tbox_KDV.Text.Trim()));
                paramList.Add(new SqlParameter("@paramBillStatus",Cbox_Fatura_Durum.SelectedIndex));
                if (ImagePath == string.Empty)
                {

                     query = "INSERT INTO [dbo].[Bills] ([BillId]," +
                    "[SchoolId]," +
                    "[BillTypeId]," +
                    "[BillDate]," +
                    "[BillLastPayDate]," +
                    "[BillConsumption]," +
                    "[BillAmount]," +
                    "[BillTax]," +
                    "[BillStatus],"+
                    "[addMebbis]" +
                    ") VALUES" +
                    "( " +
                    "@paramBillId," +
                    "@paramSchoolId," +
                    "@paramBillTypeId," +
                    "@paramBillDate," +
                    "@paramBillLastPayDate," +
                    "@paramBillConsumption," +
                    "@paramBillAmount," +
                    "@paramBillTax," +
                    "@paramBillStatus," +
                    "0" +
                    ");";

                }
                else
                {
                    query = "INSERT INTO [dbo].[Bills] ([BillId]," +
                    "[SchoolId]," +
                    "[BillTypeId]," +
                    "[BillDate]," +
                    "[BillLastPayDate]," +
                    "[BillConsumption]," +
                    "[BillAmount]," +
                    "[BillTax]," +
                    "[BillStatus]," +
                    "[BillImage]," +
                    "[addMebbis]" +
                    ") VALUES" +
                    "( " +
                    "@paramBillId," +
                    "@paramSchoolId," +
                    "@paramBillTypeId," +
                    "@paramBillDate," +
                    "@paramBillLastPayDate," +
                    "@paramBillConsumption," +
                    "@paramBillAmount," +
                    "@paramBillTax," +
                    "@paramBillStatus," +
                    "@paramBillImage," +
                    "0);";

                    string Path = ImagePath;
                    byte[] byteResim = null;
                    FileInfo fInfo = new FileInfo(Path);
                    long sayac = fInfo.Length;
                    FileStream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    BinaryReader bReader = new BinaryReader(fStream);
                    byteResim = bReader.ReadBytes((int)sayac);
                    paramList.Add(new SqlParameter("@paramBillImage", byteResim));
                }
                Connect_DB.sendQuery(query, paramList);
                return billId;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool checkNeedImage()
        {
            try
            {
                bool result = true;
                if (SchoolId != 0 && ImagePath == string.Empty)
                {
                    MessageBox.Show("Fatura Görüntüsü Ekleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    result = false;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_Fatura_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNeedImage())
                {
                    try
                    {
                        Convert.ToDouble(Tbox_KDV.Text);
                        Convert.ToDouble(Tbox_Tutar.Text);
                        Convert.ToDouble(TBox_Harcama.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Tutar, KDV veya Tüketim Boş Olamaz.", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    lblMessage.Text = "Fatura Eklendi. Sıra no: " + addBill();
                    Gbox_Fatura.Enabled = false;
                    Tbox_Okul_Adı.Text = "";
                    Tbox_Abone_No.Text = "";
                    TBox_Harcama.Text = "";
                    Btn_Fatura_Ekle.Enabled = false;
                    Tbox_Tutar.Text = "";
                    Tbox_KDV.Text = "";
                    txtSubType.Text = "";
                    ImagePath = String.Empty;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tbox_Tutar_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Tbox_Tutar.Text = Tbox_Tutar.Text.Replace(',', '.');
                Tbox_Tutar.SelectionStart = Tbox_Tutar.Text.Length;
                Convert.ToDouble(Tbox_Tutar.Text);


                /*if (mode == "Doğalgaz")
                {
                    string tutar_ = Tbox_Tutar.Text.Replace('.', ',');
                    float Tutar = (float) Convert.ToDouble(tutar_);
                    float kdv = (Tutar * 18) / 118;
                    kdv = (float) Math.Round(kdv, 2);
                    Tbox_KDV.Text = kdv.ToString();
                }*/
            }
            catch(FormatException)
            {
                if (Tbox_Tutar.Text != string.Empty)
                {
                    MessageBox.Show("Hatalı Sayı Yazıldı. Sayı ve Nokta Dışında Karakter Yazılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Tbox_Tutar.Text = string.Empty;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tbox_KDV_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Tbox_KDV.Text = Tbox_KDV.Text.Replace(',', '.');
                Tbox_KDV.SelectionStart = Tbox_KDV.Text.Length;
                Convert.ToDouble(Tbox_KDV.Text);
            }
            catch (FormatException)
            {   if(Tbox_KDV.Text != string.Empty)
                {
                    MessageBox.Show("Hatalı Sayı Yazıldı. Sayı ve Nokta Dışında Karakter Yazılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Tbox_KDV.Text = string.Empty;
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findSub(string SubNumber)
        {
            try
            {
                string query;
                List<SqlParameter> paramList = new List<SqlParameter>(); DataTable result; int SubNumberId; int SchoolId; int SubId;
                if (this.SchoolId == 0)
                {
                    query = "SELECT SB.[SchoolId], SB.[SubId], [SubNumberId], [SchoolName], [SchoolType], [SubType] FROM [dbo].[Subs] SB " +
                   "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = SB.[SchoolId] " +
                   " inner join [dbo].[SubTypebyId] ST on ST.[SubId] = SB.[SubId] " +
                   " WHERE [SubNumber] = @paramSubNumber ";
                }else
                {

                    query = "SELECT SB.[SchoolId], SB.[SubId], [SubNumberId], [SchoolName], [SchoolType], [SubType] FROM [dbo].[Subs] SB " +
                   "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = SB.[SchoolId] " +
                   " inner join [dbo].[SubTypebyId] ST on ST.[SubId] = SB.[SubId] " +
                   " WHERE [SubNumber] = @paramSubNumber AND SB.[SchoolId] = @paramSchoolId ";

                    paramList.Add(new SqlParameter("@paramSchoolId", this.SchoolId));

                }

                paramList.Add(new SqlParameter("@paramSubNumber", Tbox_Abone_No.Text));

                    result = Connect_DB.getQuery(query, paramList);

                    SchoolId = Convert.ToInt32(result.Rows[0][0]);

                     SubNumberId = Convert.ToInt32(result.Rows[0][2]);

                    SubId = Convert.ToInt32(result.Rows[0][1]);

                Tbox_Okul_Adı.Text = SchoolId + " " + result.Rows[0][4].ToString() + " " + result.Rows[0][3].ToString();

                txtSubType.Text = SubNumberId + " " + SubId + " " + result.Rows[0][5].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Abone No Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Tbox_Abone_No_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    findSub(Tbox_Abone_No.Text);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fatura_Ekle_Load(object sender, EventArgs e)
        {
            try
            {
                string CompanyName = "";
                string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0]["SetValue"].ToString();
                this.Text = CompanyName + " - Fatura Ekle";
              //  OCR();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBillImage_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog sec = new System.Windows.Forms.OpenFileDialog();
                sec.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";
                if (sec.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(sec.FileName);
                    long data = fi.Length;
                    long kbData = data / 1024;
                    if (kbData > 200 || kbData < 50)
                    {
                        MessageBox.Show("Dosya boyutu 50 KB ile 200 KB arasında olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ImagePath = string.Empty;
                    }
                    else
                    {
                        ImagePath = sec.FileName;
                    }
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBox_Harcama_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TBox_Harcama.Text.Contains(".") || TBox_Harcama.Text.Contains(",") || TBox_Harcama.Text.Contains(" "))
                {
                    TBox_Harcama.Text = string.Empty;
                }


                Convert.ToDouble(Tbox_KDV.Text);
            }
            catch (FormatException)
            {
                if (TBox_Harcama.Text != string.Empty)
                {
                    MessageBox.Show("Hatalı Sayı Yazıldı. Sayı Dışında Karakter Yazılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    TBox_Harcama.Text = string.Empty;
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
