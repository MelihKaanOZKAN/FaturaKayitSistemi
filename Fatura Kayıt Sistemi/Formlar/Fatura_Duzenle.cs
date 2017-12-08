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
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Fatura_Duzenle : Form
    {
        public string BillId = String.Empty;
        public DateTime BillDate;
        public int SchoolId = 0;
        private int OldSchoolId = 0;
        private string ImagePath = string.Empty;
        public bool permEdit = false;
        public bool isCorrect = false;
        
        public Fatura_Duzenle()
        {
            InitializeComponent();
        }
        

        private void Fatura_Duzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        private int getId(int SubId, int SchoolTypeId)
        {
            try
            {
                string IdType = SubId + "_" + SchoolTypeId + "_" + DTpic.Value.Month + "_" + DTpic.Value.Year + "_Correct";
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

        private void getBill()
        {
            string query = "";
            if (isCorrect)
            {
                query = "Select  [BillId] as 'Fatura Nu'," +
              "Sb.[SubNumber]," +
             "SubType as 'Fatura Türü', " +
         "Bls.[SchoolId]," +
         "[SchoolName]," +
         "[BillDate]," +
         " [BillConsumption]," +
         " [BillAmount]," +
         " [BillTax]," +
         " [BillStatus]," +
         "SB.[SubNumberId]," +
         "[PaymentId]," +
         "[BillLastPayDate]," +
         "ScT.[SchoolTypeId]," +
         "SB.[subId]"+
         "  FROM [dbo].[BillsCorrect] Bls " +
         "inner join [dbo].[Subs] SB on Bls.[BillTypeId]=SB.[SubNumberId] " +
         "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
         "inner join [dbo].[SubTypebyID] STI on SB.[SubId] = STI.[SubId]" +
         "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType]  " +
         "WHERE Bls.[BillId] = @paramBillId AND Bls.[BillDate] = @paramBillDate AND Bls.SchoolId = @paramSchoolId";
            }
            else
            {
                query  = "Select  [BillId] as 'Fatura Nu'," +
              "Sb.[SubNumber]," +
             "SubType as 'Fatura Türü', " +
         "Bls.[SchoolId]," +
         "[SchoolName]," +
         "[BillDate]," +
         " [BillConsumption]," +
         " [BillAmount]," +
         " [BillTax]," +
         " [BillStatus]," +
         "SB.[SubNumberId]," +
         "[PaymentId]," +
         "[BillLastPayDate]," +
         "ScT.[SchoolTypeId]," +
         "SB.[subId]" +
         "  FROM [dbo].[Bills] Bls " +
         "inner join [dbo].[Subs] SB on Bls.[BillTypeId]=SB.[SubNumberId] " +
         "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
         "inner join [dbo].[SubTypebyID] STI on SB.[SubId] = STI.[SubId]" +
         "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType]  " +
         "WHERE Bls.[BillId] = @paramBillId AND Bls.[BillDate] = @paramBillDate AND Bls.SchoolId = @paramSchoolId";
            }
          
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@paramBillId", BillId));
            paramList.Add(new SqlParameter("@paramBillDate", BillDate.ToString("yyyy-MM-dd")));
            paramList.Add(new SqlParameter("@paramSchoolId", SchoolId));
           DataTable dt = Connect_DB.getQuery(query, paramList);
            {
                txtBillId.Text = dt.Rows[0][0].ToString();
                Tbox_Abone_No.Text = dt.Rows[0][1].ToString();
                OldSchoolId = Convert.ToInt32(dt.Rows[0][3]);
                Tbox_Okul_Adı.Text = dt.Rows[0][3].ToString() + " " + dt.Rows[0][13].ToString() + " " + dt.Rows[0][4].ToString();
                txtSubType.Text = dt.Rows[0][10].ToString()+ " "+ dt.Rows[0][14].ToString() + " " + dt.Rows[0][2].ToString();
                DTpic.Value = (DateTime)dt.Rows[0][5];
                Tbox_Tutar.Text = dt.Rows[0][7].ToString();
                Tbox_KDV.Text = dt.Rows[0][8].ToString();
                TBox_Harcama.Text = dt.Rows[0][6].ToString();
                Cbox_Fatura_Durum.SelectedIndex = Convert.ToInt32(dt.Rows[0][9]);
                txtPayNo.Text = dt.Rows[0][11].ToString();
                dtPicLastPay.Value = (DateTime)dt.Rows[0][12];
                query = "Select " +
           "[BillImage]" +
           "  FROM [dbo].[Bills] Bls " +
           "WHERE Bls.[BillId] = @paramBillId AND Bls.[BillDate] = @paramBillDate AND Bls.SchoolId = @paramSchoolId ";
                Image BillImage = Connect_DB.getImage(query, paramList);
                pictureBoxBillImage.Image = BillImage;
                if (pictureBoxBillImage.Image == null)
                {
                    btnBillImage.Enabled = false;
                }
            }
           if(!permEdit)
            {
                TBox_Harcama.Enabled = false;
                Tbox_Tutar.Enabled = false;
                Tbox_KDV.Enabled = false;
                DTpic.Enabled = false;
                btnBillImageChange.Enabled = false;
                Cbox_Fatura_Durum.Enabled = false;
                groupBoxSchool.Enabled = false;
                Tbox_Abone_No.Enabled = false;
                Btn_Fatura_Guncelle.Enabled = false;
                btn_Fatura_Sil.Enabled = false;
                checkboxImageDelete.Enabled = false;
                dtPicLastPay.Enabled = false;
            }
        }
        private int UpdateBill()
        {
            try
            {
                string query = "";
                String[] temp;
                temp = txtSubType.Text.Split(' ');
                String[] tmp = Tbox_Okul_Adı.Text.Split(' ');
                int billId = Convert.ToInt32(txtBillId.Text);
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramBillNumberId", temp[0]));
                paramList.Add(new SqlParameter("@paramSchoolId", tmp[0]));
                paramList.Add(new SqlParameter("@paramBillDate", DTpic.Value));
                paramList.Add(new SqlParameter("@paramBillLastPayDate", dtPicLastPay.Value));
                paramList.Add(new SqlParameter("@paramBillConsumption", Convert.ToDouble(TBox_Harcama.Text)));
                paramList.Add(new SqlParameter("@paramBillAmount", Convert.ToDouble(Tbox_Tutar.Text)));
                paramList.Add(new SqlParameter("@paramBillTax", Convert.ToDouble(Tbox_KDV.Text)));
                paramList.Add(new SqlParameter("@paramBillStatus", Cbox_Fatura_Durum.SelectedIndex));
                paramList.Add(new SqlParameter("@paramBillOldDate", BillDate));
                paramList.Add(new SqlParameter("@paramOldSchoolId", OldSchoolId));

                if (ImagePath == string.Empty)
                {
                    if (isCorrect)
                    {

                       billId = Convert.ToInt32(txtBillId.Text);
                        query = "Update  [dbo].[BillsCorrect] SET" +
                             "[SchoolId] = @paramSchoolId," +
                             "[BillDate]= @paramBillDate," +
                             "[BillLastPayDate]= @paramBillLastPayDate," +
                             "[BillConsumption] = @paramBillConsumption," +
                             "[BillAmount] = @paramBillAmount," +
                             "[BillTax] = @paramBillTax," +
                             "[BillStatus] = @paramBillStatus " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";

                        if (checkboxImageDelete.Checked)
                        {
                            query = "Update  [dbo].[BillsCorrect] SET" +
                       "[SchoolId] = @paramSchoolId," +
                       "[BillDate]= @paramBillDate," +
                       "[BillLastPayDate]= @paramBillLastPayDate," +
                       "[BillConsumption] = @paramBillConsumption," +
                       "[BillAmount] = @paramBillAmount," +
                       "[BillTax] = @paramBillTax," +
                       "[BillStatus] = @paramBillStatus," +
                       "[BillImage] = @paramBillImage " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";

                            paramList.Add(new SqlParameter("@paramBillImage", SqlDbType.VarBinary));
                            paramList[10].Value = System.Data.SqlTypes.SqlBinary.Null;
                            paramList[10].IsNullable = true;
                            btnBillImage.Enabled = false;

                        }

                    }
                    else
                    {
                        billId = getId(Convert.ToInt32(temp[1]), Convert.ToInt32(tmp[1]));
                        query = "Update  [dbo].[Bills] SET" +
                    "[SchoolId] = @paramSchoolId," +
                    "[BillDate]= @paramBillDate," +
                    "[BillLastPayDate]= @paramBillLastPayDate," +
                    "[BillConsumption] = @paramBillConsumption," +
                    "[BillAmount] = @paramBillAmount," +
                    "[BillTax] = @paramBillTax," +
                    "[BillStatus] = @paramBillStatus " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";



                    }
                }

                else
                {
                    if (isCorrect)
                    {
                        billId = Convert.ToInt32(txtBillId.Text);
                        query = "Update  [dbo].[BillsCorrect] SET" +
                       "[SchoolId] = @paramSchoolId," +
                       "[BillDate]= @paramBillDate," +
                       "[BillLastPayDate]= @paramBillLastPayDate," +
                       "[BillConsumption] = @paramBillConsumption," +
                       "[BillAmount] = @paramBillAmount," +
                       "[BillTax] = @paramBillTax," +
                       "[BillStatus] = @paramBillStatus," +
                       "[BillImage] = @paramBillImage " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";


                        string Path = ImagePath;
                        byte[] byteResim = null;
                        FileInfo fInfo = new FileInfo(Path);
                        long sayac = fInfo.Length;
                        FileStream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                        BinaryReader bReader = new BinaryReader(fStream);
                        byteResim = bReader.ReadBytes((int)sayac);
                        if (checkboxImageDelete.Checked)
                        {

                            paramList.Add(new SqlParameter("@paramBillImage", SqlDbType.VarBinary));
                            paramList[10].Value = System.Data.SqlTypes.SqlBinary.Null;
                            paramList[10].IsNullable = true;
                            btnBillImage.Enabled = false;

                        }
                        else
                        {
                            paramList.Add(new SqlParameter("@paramBillImage", byteResim));
                        }

                    }
                    else
                    {
                        query = "Update  [dbo].[Bills] SET" +
                             "[SchoolId] = @paramSchoolId," +
                             "[BillDate]= @paramBillDate," +
                             "[BillLastPayDate]= @paramBillLastPayDate," +
                             "[BillConsumption] = @paramBillConsumption," +
                             "[BillAmount] = @paramBillAmount," +
                             "[BillTax] = @paramBillTax," +
                             "[BillStatus] = @paramBillStatus " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";

                        if (checkboxImageDelete.Checked)
                        {
                            query = "Update  [dbo].[Bills] SET" +
                       "[SchoolId] = @paramSchoolId," +
                       "[BillDate]= @paramBillDate," +
                       "[BillLastPayDate]= @paramBillLastPayDate," +
                       "[BillConsumption] = @paramBillConsumption," +
                       "[BillAmount] = @paramBillAmount," +
                       "[BillTax] = @paramBillTax," +
                       "[BillStatus] = @paramBillStatus," +
                       "[BillImage] = @paramBillImage " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId AND [BillTypeId] = @paramBillNumberId ";

                            paramList.Add(new SqlParameter("@paramBillImage", SqlDbType.VarBinary));
                            paramList[10].Value = System.Data.SqlTypes.SqlBinary.Null;
                            paramList[10].IsNullable = true;
                            btnBillImage.Enabled = false;

                        }
                    }

                }

                paramList.Add(new SqlParameter("@paramBillId", billId));
                bool result = Connect_DB.sendQuery(query, paramList);
                if (isCorrect)
                {

                    return Convert.ToInt32(result);
                }
                else
                {

                    return billId;
                }
            }


            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
               throw;
            }
        }

        private bool deleteBill()
        {
            bool result = false;
            try
            {
                if (isCorrect)
                {

                    string query = "DELETE FROM [dbo].[BillsCorrect] " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId";

                    int billId = Convert.ToInt32(txtBillId.Text);
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramBillId", billId));
                    paramList.Add(new SqlParameter("@paramBillOldDate", BillDate));
                    paramList.Add(new SqlParameter("@paramOldSchoolId", OldSchoolId));
                    result = Connect_DB.sendQuery(query, paramList);
                }
                else
                {

                    string query = "DELETE FROM [dbo].[Bills] " +
                       " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId";

                    int billId = Convert.ToInt32(txtBillId.Text);
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramBillId", billId));
                    paramList.Add(new SqlParameter("@paramBillOldDate", BillDate));
                    paramList.Add(new SqlParameter("@paramOldSchoolId", OldSchoolId));
                    result = Connect_DB.sendQuery(query, paramList);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        private void Fatura_Duzenle_Load(object sender, EventArgs e)
        {

            try
            {
                string CompanyName = "";
                string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt =  Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0][0].ToString();
                this.Text = CompanyName + " - Fatura Düzenle";
                getBill();
                if (Cbox_Fatura_Durum.SelectedIndex == 1)
                {
                    TBox_Harcama.Enabled = false;
                    Tbox_Tutar.Enabled = false;
                    Tbox_KDV.Enabled = false;
                    DTpic.Enabled = false;
                    btnBillImageChange.Enabled = false;
                    Cbox_Fatura_Durum.Enabled = false;
                    groupBoxSchool.Enabled = false;
                    Tbox_Abone_No.Enabled = false;
                    Btn_Fatura_Guncelle.Enabled = false;
                    btn_Fatura_Sil.Enabled = false;
                    gBoxPay.Visible = true;
                    checkboxImageDelete.Enabled = false;
                    dtPicLastPay.Enabled = false;
                }
                if (!isCorrect)
                {
                    Btn_Fatura_Guncelle.Text = "Güncelle ve Kesinleştir";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBillImage_Click(object sender, EventArgs e)
        {
            try
            {
                string BillName = txtBillId.Text + "_" + DTpic.Value.ToShortDateString();
                string filePath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(filePath, "Kayıt Otomasyonu");
                pictureBoxBillImage.Image.Save(specificFolder + @"\" + BillName + ".jpeg", ImageFormat.Jpeg);
                Process.Start(specificFolder + @"\" + BillName + ".jpeg");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBillImageChange_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog sec = new System.Windows.Forms.OpenFileDialog();
                sec.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";
                if (sec.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = sec.FileName;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CopyData(int billIdNew)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO  [dbo].[BillsCorrect] " +
                   " SELECT DISTINCT * FROM [dbo].[Bills] WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId;  ";
                query  += "UPDATE [dbo].[BillsCorrect] SET [BillId] = @paramBillIdNew WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId";
                int billId = Convert.ToInt32(txtBillId.Text);
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramBillId", billId));
                paramList.Add(new SqlParameter("@paramBillOldDate", BillDate));
                paramList.Add(new SqlParameter("@paramOldSchoolId", OldSchoolId));
                paramList.Add(new SqlParameter("@paramBillIdNew", billIdNew));
                result = Connect_DB.sendQuery(query, paramList);

                deleteBill();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        private void Btn_Fatura_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isCorrect)
                {
                   int Id = UpdateBill();
                    CopyData(Id);
                    MessageBox.Show("Güncelleme Başarılı! \n Yeni Sıra Nu: " + Id, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                    {

                    if (Convert.ToBoolean(UpdateBill()))
                    {

                        MessageBox.Show("Güncelleme Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fatura_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Fatura Silinecek?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( DR == DialogResult.Yes)
                {
                    if (deleteBill())
                    {
                        MessageBox.Show("Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Silme Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
