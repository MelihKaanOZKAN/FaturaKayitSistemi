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

namespace Fatura_Kayıt_Sistemi.Formlar
{
    public partial class ProgramAyarları : Form
    {
        private static string[] arrYetki = new string[8];
        public bool checkClose = false;
        public ProgramAyarları()
        {
            InitializeComponent();
        }

        #region KullanıcıYonetim

        private void DTV_Show_Kullanıcı(DataTable dt)
        {
            try
            {
                DGVUserList.DataSource = dt;
                DGVUserList.Refresh();
                DGVUserList.Columns[0].Visible = false;
                DGVUserList.Columns[1].HeaderText = "Kullanıcı Adı";
                DGVUserList.Columns[2].Visible = false;
                DGVUserList.Columns[3].HeaderText = "Ünvan";
                DGVUserList.Columns[4].Visible = false;
                DGVUserList.Columns[5].Visible = false;
                DGVUserList.Columns[6].Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void clearPrems()
        {
            try
            {
                FKS_Add_Fatura.Checked = false;
                FKS_Duzenleme.Checked = false;
                FKS_Goruntuleme.Checked = false;
                FKS_Odeme.Checked = false;
                OBS_Duzenleme.Checked = false;
                OBS_Goruntuleme.Checked = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void refreshUser()
        {
           string query = "SELECT UserId, UserName, UserPassword, UserInfo, UserPerm, UserPermList, UserSchoolId FROM [dbo].[UserList]";
            DTV_Show_Kullanıcı(Connect_DB.getQuery(query));
            clearPrems();
        }
        private void YetkiAl()
        {
            for (int i = 0; i < arrYetki.Length - 1; i++)
            {
                if (arrYetki[i] != null)
                {
                    arrYetki[7] += arrYetki[i] + ";";
                }
            }
        }

        private void OBS_Duzenleme_CheckedChanged(object sender, EventArgs e)
        {
            if (OBS_Duzenleme.Checked == true)
            {
                arrYetki[0] = "#001";
            }
            else
            {
                arrYetki[0] = null;
            }
        }

        private void OBS_Goruntuleme_CheckedChanged(object sender, EventArgs e)
        {
            if (OBS_Goruntuleme.Checked == true)
            {
                arrYetki[1] = "#002";
            }
            else
            {
                arrYetki[1] = null;
            }
        }

        private void FKS_Duzenleme_CheckedChanged(object sender, EventArgs e)
        {
            if (FKS_Duzenleme.Checked == true)
            {
                arrYetki[2] = "#021";
            }
            else
            {
                arrYetki[2] = null;
            }
        }

        private void FKS_Goruntuleme_CheckedChanged(object sender, EventArgs e)
        {
            if (FKS_Goruntuleme.Checked == true)
            {
                arrYetki[3] = "#022";
            }
            else
            {
                arrYetki[3] = null;
            }
        }

        private void FKS_Add_Fatura_CheckedChanged(object sender, EventArgs e)
        {
            if (FKS_Add_Fatura.Checked == true)
            {
                arrYetki[4] = "#023";
            }
            else
            {
                arrYetki[4] = null;
            }
        }

        private void FKS_Odeme_CheckedChanged(object sender, EventArgs e)
        {
            if (FKS_Odeme.Checked == true)
            {
                arrYetki[5] = "#024";
            }
            else
            {
                arrYetki[5] = null;
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

        private void Btn_Yeni_ky_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Yeni_ky.Text == "Yeni Kayıt")
                {
                    arrYetki = new string[8];
                    Tbox_Username.Enabled = true;
                    Tbox_Pass.Enabled = true;
                    Cbox_Unvan.Enabled = true;
                    Cbox_Yetki.Enabled = true;
                    Yetkiler.Enabled = true;
                    txtSchoolId.Enabled = true;
                    Btn_Yeni_ky.Text = "Kaydet";
                }
                else if (Btn_Yeni_ky.Text == "Kaydet")
                {
                    string query = "INSERT INTO " +
                        "[dbo].[UserList]" +
                        "(UserName," +
                        " UserPassword," +
                        " UserInfo," +
                        " UserPerm," +
                        " UserPermList," +
                        "UserSchoolId)" +
                        " VALUES" +
                        "(" +
                        "@paramUserName," +
                        " @paramUserPassword," +
                        " @paramUserInfo," +
                        " @paramUserPerm," +
                        " @paramUserPermList," +
                        "@paramUserSchoolId" +
                        ");";

                    List<SqlParameter> paramList = new List<SqlParameter>();
                    YetkiAl();
                    if (arrYetki[7] == null)
                    {
                        MessageBox.Show("Yetki Belirleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    paramList.Add(new SqlParameter("@paramUserName", Tbox_Username.Text));
                    paramList.Add(new SqlParameter("@paramUserInfo", Cbox_Unvan.Text));
                    paramList.Add(new SqlParameter("@paramUserPerm", Cbox_Yetki.Text));
                    paramList.Add(new SqlParameter("@paramUserPermList", arrYetki[7]));
                    paramList.Add(new SqlParameter("@paramUserPassword", Encrypt(Tbox_Pass.Text)));
                    paramList.Add(new SqlParameter("@paramUserSchoolId", txtSchoolId.Text));
                    Connect_DB.sendQuery(query, paramList);
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
                    Cbox_Unvan.SelectedIndex = 0;
                    Cbox_Yetki.SelectedIndex = 0;
                    OBS_Duzenleme.Checked = false;
                    OBS_Goruntuleme.Checked = false;
                    FKS_Add_Fatura.Checked = false;
                    FKS_Duzenleme.Checked = false;
                    FKS_Goruntuleme.Checked = false;
                    FKS_Odeme.Checked = false;
                    Tbox_Username.Enabled = false;
                    Tbox_Pass.Enabled = false;
                    Cbox_Unvan.Enabled = false;
                    Cbox_Yetki.Enabled = false;
                    Yetkiler.Enabled = false;
                    txtSchoolId.Enabled = false;
                    lblMessage.Font = new Font("Arial", 12);
                    lblMessage.BackColor = Color.Green;
                    lblMessage.Text = "Kayıt Başarılı!";
                    Btn_Yeni_ky.Text = "Yeni Kayıt";
                    //lbl_Message.Visible = true;
                    arrYetki = new string[arrYetki.Length];
                    refreshUser();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_Username.Text == "")
                {
                    lblMessage.Font = new Font("Arial", 15);
                    lblMessage.BackColor = Color.YellowGreen;
                    lblMessage.Text = "Seçim Yapın";
                    lblMessage.Visible = true;
                    goto gend;
                }
                DialogResult dr = MessageBox.Show("Kayıt Silinecek! Kullanıkcı Adı: " + Tbox_Username.Text, "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM [dbo].[UserList] WHERE UserName=@paramUserName";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramUserName", Tbox_Username.Text));
                    Connect_DB.sendQuery(query, paramList);
                    lblMessage.Font = new Font("Arial", 15);
                    lblMessage.BackColor = Color.Red;
                    lblMessage.Text = "Silme Başarılı!";
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
                    Cbox_Unvan.SelectedIndex = 0;
                    Cbox_Yetki.SelectedIndex = 0;
                    OBS_Duzenleme.Checked = false;
                    OBS_Goruntuleme.Checked = false;
                    FKS_Add_Fatura.Checked = false;
                    FKS_Duzenleme.Checked = false;
                    FKS_Goruntuleme.Checked = false;
                    FKS_Odeme.Checked = false;
                    Tbox_Username.Enabled = true;
                    Cbox_Yetki.Enabled = false;
                    Tbox_Pass.Enabled = true;
                    Cbox_Unvan.Enabled = false;
                    refreshUser();

                }
                else if (dr == DialogResult.No)
                {

                }
                gend:;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yetkiIsle(string Yetki)
        {
            string[] dizi = Yetki.Split(';');
            for (int i = 0; i < dizi.Length; i++)
            {
                switch (dizi[i])
                {
                    case "#001": OBS_Duzenleme.Checked = true; break;
                    case "#002": OBS_Goruntuleme.Checked = true; break;
                    case "#021": FKS_Duzenleme.Checked = true; break;
                    case "#022": FKS_Goruntuleme.Checked = true; break;
                    case "#023": FKS_Add_Fatura.Checked = true; break;
                    case "#024": FKS_Odeme.Checked = true; break;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_Username.Text == "")
                {
                    lblMessage.Text = "Seçim Yapın.";
                    goto end;
                }
                if (btn_update.Text == "Güncelleme")
                {
                    Tbox_Username.Enabled = true;
                    Tbox_Pass.Enabled = true;
                    Cbox_Unvan.Enabled = true;
                    Cbox_Yetki.Enabled = true;
                    Yetkiler.Enabled = true;
                    txtSchoolId.Enabled = true;
                    btn_update.Text = "Kaydet";
                }
                else if (btn_update.Text == "Kaydet")
                {
                    string query;
                    if (Tbox_Pass.Text == string.Empty)
                    {
                        query = "UPDATE [dbo].[UserList] " +
                       "SET UserPerm=@paramUserPerm, UserInfo=@paramUserInfo, UserPermList=@paramUserPermList, UserSchoolId=@paramUserSchoolId WHERE UserName=@paramUserName";
                        YetkiAl(); if (arrYetki[7] == null)
                        {
                            MessageBox.Show("Yetki Belirleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        List<SqlParameter> paramList = new List<SqlParameter>();
                        paramList.Add(new SqlParameter("@paramUserName", Tbox_Username.Text));
                        paramList.Add(new SqlParameter("@paramUserInfo", Cbox_Unvan.Text));
                        paramList.Add(new SqlParameter("@paramUserPerm", Cbox_Yetki.Text));
                        paramList.Add(new SqlParameter("@paramUserPermList", arrYetki[7]));
                        paramList.Add(new SqlParameter("@paramUserSchoolId", txtSchoolId.Text));
                        YetkiAl();
                        Connect_DB.sendQuery(query, paramList);
                    }
                    else
                    {
                        query = "UPDATE [dbo].[UserList] " +
                       "SET UserPassword=@paramUserPassword UserPerm=@paramUserPerm, UserInfo=@paramUserInfo, UserPermList=@paramUserPermList, UserSchoolId = @paramUserSchoolId WHERE UserName=@paramUserName";
                        YetkiAl();
                        List<SqlParameter> paramList = new List<SqlParameter>();
                        YetkiAl();
                        if (arrYetki[7] == null)
                        {
                            MessageBox.Show("Yetki Belirleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        paramList.Add(new SqlParameter("@paramUserName", Tbox_Username.Text));
                        paramList.Add(new SqlParameter("@paramInfo", Cbox_Unvan.Text));
                        paramList.Add(new SqlParameter("@paramUserPerm", Cbox_Yetki.Text));
                        paramList.Add(new SqlParameter("@paramUserPermList", arrYetki[7]));
                        paramList.Add(new SqlParameter("@paramPassword", Encrypt(Tbox_Pass.Text)));
                        paramList.Add(new SqlParameter("@paramUserSchoolId", txtSchoolId.Text));
                        Connect_DB.sendQuery(query, paramList);
                    }
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
                    Cbox_Unvan.SelectedIndex = 0;
                    Cbox_Yetki.SelectedIndex = 0;
                    OBS_Duzenleme.Checked = false;
                    OBS_Goruntuleme.Checked = false;
                    FKS_Add_Fatura.Checked = false;
                    FKS_Duzenleme.Checked = false;
                    FKS_Goruntuleme.Checked = false;
                    FKS_Odeme.Checked = false;
                    Tbox_Username.Enabled = false;
                    Tbox_Pass.Enabled = false;
                    Cbox_Unvan.Enabled = false;
                    Cbox_Yetki.Enabled = false;
                    Yetkiler.Enabled = false;
                    txtSchoolId.Enabled = false;
                    lblMessage.Font = new Font("Arial", 15);
                    lblMessage.BackColor = Color.Yellow;
                    lblMessage.Text = "Güncelleme Başarılı!";
                    btn_update.Text = "Güncelleme";
                    arrYetki = new string[arrYetki.Length];
                    refreshUser();
                }
                end:;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGVUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearPrems();
                Tbox_Username.Text = DGVUserList.Rows[e.RowIndex].Cells[1].Value.ToString();
                Cbox_Unvan.SelectedItem = DGVUserList.Rows[e.RowIndex].Cells[3].Value.ToString();
                yetkiIsle(DGVUserList.Rows[e.RowIndex].Cells[5].Value.ToString());
                Cbox_Yetki.SelectedItem = DGVUserList.Rows[e.RowIndex].Cells[4].Value.ToString();
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region FaturaveÖdeme

        private void DTV_Show_Fatura(DataTable dt)
        {
            try
            {
                DGV_Bills.DataSource = dt;
                DGV_Bills.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DTVShowPay (DataTable dt)
        {
            try
            {
                DGVPay.DataSource = dt;
                DGVPay.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_fatura_yk_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_fatura_yk.Text == "Yeni Kayıt")
                {
                    Cbox_Company_Bill.Enabled = true;
                    Tbox_Ekle_Fatura_Tur.Enabled = true;
                    txtBillCode.Enabled = true;
                    btn_fatura_yk.Text = "Kaydet";
                }
                else if (btn_fatura_yk.Text == "Kaydet")
                {
                    faturaEkle();
                    Cbox_Company_Bill.Enabled = false; Cbox_Company_Bill.Text = "";
                    Tbox_Ekle_Fatura_Tur.Enabled = false; Tbox_Ekle_Fatura_Tur.Text = "";
                    txtBillCode.Text = ""; txtBillCode.Enabled = false;
                    btn_fatura_yk.Text = "Yeni Kayıt";
                    refreshBillData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btn_fatura_update_Click(object sender, EventArgs e)
        {

            try
            {
                if (btn_fatura_update.Text == "Güncelleme")
                {
                    Cbox_Company_Bill.Enabled = true;
                    Tbox_Ekle_Fatura_Tur.Enabled = true;
                    txtBillCode.Enabled = true;
                    btn_fatura_update.Text = "Kaydet";
                }
                else if (btn_fatura_update.Text == "Kaydet" && (Tbox_Ekle_Fatura_Tur.Text != "" || Tbox_Ekle_Fatura_Tur.Text != string.Empty))
                {
                    faturaGuncelle();
                    Cbox_Company_Bill.Enabled = false; Cbox_Company_Bill.Text = "";
                    Tbox_Ekle_Fatura_Tur.Enabled = false; Tbox_Ekle_Fatura_Tur.Text = "";

                    txtBillCode.Text = ""; txtBillCode.Enabled = false;
                    lblFaturaID.Text = "";
                    btn_fatura_update.Text = "Güncelleme";
                    refreshBillData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_fatura_del_Click(object sender, EventArgs e)
        {

            try
            {
                if (Tbox_Ekle_Fatura_Tur.Text != "" || Tbox_Ekle_Fatura_Tur.Text != string.Empty)
                {
                    faturaSil();
                    Cbox_Company_Bill.Enabled = false; Cbox_Company_Bill.Text = "";
                    Tbox_Ekle_Fatura_Tur.Enabled = false; Tbox_Ekle_Fatura_Tur.Text = "";
                    txtBillCode.Text = ""; txtBillCode.Enabled = false;
                    lblFaturaID.Text = "";
                    refreshBillData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_kurum_yk_Click(object sender, EventArgs e)
        {

            try
            {
                btn_kurum_yk.Enabled = false;
                if (btn_kurum_yk.Text == "Yeni Kayıt")
                {
                    Tbox_Kurum_Adı.Text = string.Empty; Tbox_Kurum_Adı.Enabled = true;
                    Tbox_Kurum_No.Text = string.Empty;
                    Tbox_kurum_tipi.Text = string.Empty; Tbox_kurum_tipi.Enabled = true;
                    Tbox_Iban.Text = string.Empty; Tbox_Iban.Enabled = true;
                    Tbox_Banka.Text = string.Empty; Tbox_Banka.Enabled = true;
                    TboxUnitPrice.Text = string.Empty; TboxUnitPrice.Enabled = true;
                    TboxAciklama.Text = string.Empty; TboxAciklama.Enabled = true;
                    btn_kurum_yk.Text = "Kaydet";
                }
                else if (btn_kurum_yk.Text == "Kaydet")
                {
                    addCompany();
                    Tbox_Kurum_Adı.Text = string.Empty; Tbox_Kurum_Adı.Enabled = false;
                    Tbox_Kurum_No.Text = string.Empty; Tbox_Kurum_No.Enabled = false;
                    Tbox_kurum_tipi.Text = string.Empty; Tbox_kurum_tipi.Enabled = false;
                    Tbox_Iban.Text = string.Empty; Tbox_Iban.Enabled = false;
                    Tbox_Banka.Text = string.Empty; Tbox_Banka.Enabled = false;
                    TboxUnitPrice.Text = string.Empty; TboxUnitPrice.Enabled = false;
                    TboxAciklama.Text = string.Empty; TboxAciklama.Enabled = false;
                    btn_kurum_yk.Text = "Yeni Kayıt";
                    refreshPay();
                }
                btn_kurum_yk.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_kurum_update_Click(object sender, EventArgs e)
        {

            try
            {
                btn_kurum_update.Enabled = false;
                if (btn_kurum_update.Text == "Güncelleme")
                {
                    Tbox_Kurum_Adı.Enabled = true;
                    Tbox_kurum_tipi.Enabled = true;
                    Tbox_Iban.Enabled = true;
                    Tbox_Banka.Enabled = true;
                    TboxUnitPrice.Enabled = true;
                    TboxAciklama.Enabled = true;
                    btn_kurum_update.Text = "Kaydet";
                }
                else if (btn_kurum_update.Text == "Kaydet")
                {
                    updateCompany();
                    Tbox_Kurum_Adı.Text = string.Empty; Tbox_Kurum_Adı.Enabled = false;
                    Tbox_Kurum_No.Text = string.Empty; Tbox_Kurum_No.Enabled = false;
                    Tbox_kurum_tipi.Text = string.Empty; Tbox_kurum_tipi.Enabled = false;
                    Tbox_Iban.Text = string.Empty; Tbox_Iban.Enabled = false;
                    Tbox_Banka.Text = string.Empty; Tbox_Banka.Enabled = false;
                    TboxUnitPrice.Text = string.Empty; TboxUnitPrice.Enabled = false;
                    TboxAciklama.Text = string.Empty; TboxAciklama.Enabled = false;
                    btn_kurum_update.Text = "Güncelleme";
                    refreshPay();
                }
                btn_kurum_update.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_kurum_del_Click(object sender, EventArgs e)
        {

            try
            {
                btn_kurum_del.Enabled = false;
                deleteCompany();
                Tbox_Kurum_Adı.Text = string.Empty; Tbox_Kurum_Adı.Enabled = false;
                Tbox_Kurum_No.Text = string.Empty; 
                Tbox_kurum_tipi.Text = string.Empty; Tbox_kurum_tipi.Enabled = false;
                Tbox_Iban.Text = string.Empty; Tbox_Iban.Enabled = false;
                Tbox_Banka.Text = string.Empty; Tbox_Banka.Enabled = false;
                TboxUnitPrice.Text = string.Empty; TboxUnitPrice.Enabled = false;
                TboxAciklama.Text = string.Empty; TboxAciklama.Enabled = false;
                btn_kurum_update.Text = "Yeni Kayıt";
                refreshPay();
                btn_kurum_del.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void refreshBillData()
        {
            try
            {
               string query = "SELECT [SubId] as 'Fatura Nu'," +
                    " [SubType] as 'Fatura Tipi'," +
                    " [CompanyId] as 'Fatura Şirketi'," +
                    "[Code] as 'Ekonomik Kod' " +
                    "FROM [dbo].[SubTypebyId]";
               DTV_Show_Fatura(Connect_DB.getQuery(query));
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshPay()
        {
            try
            {
                string query = "SELECT " +
                    "[CompanyId] as 'Şirket Nu:',  " +
                    "[CompanyName]  as 'Şirket Adı'," +
                    "[CompanyType]  as 'Şirket Tipi'," +
                    "[CompanyInfo]  as 'Şirket Bilgisi'," +
                    "[CompanyBank]  as 'Şirket Bankası'," +
                    "[CompanyIBAN]  as 'Şirket İBAN No'," +
                    "[UnitPrice]   as 'Birim Fiyat'" +
                     "FROM [dbo].[CompanyList];";
                DTVShowPay(Connect_DB.getQuery(query));
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool faturaEkle()
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO [dbo].[SubTypebyId] ([SubType], [Code])" +
                     "VALUES (@paramSubType, @paramCode); ";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubType", Tbox_Ekle_Fatura_Tur.Text));
                paramList.Add(new SqlParameter("@paramCode", txtBillCode.Text));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch  (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool faturaGuncelle()
        {

            bool result = false;
            try
            {
                string query = "UPDATE [dbo].[SubTypebyId] SET" +
                    "  [SubType]=@paramSubType," +
                    " [CompanyId] = @paramCompanyId," +
                    "[Code] = @paramCode  " +
                     "WHERE [SubId] =@paramSubId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubType", Tbox_Ekle_Fatura_Tur.Text));
                paramList.Add(new SqlParameter("@paramCompanyId", DGVPay.Rows[Cbox_Company_Bill.SelectedIndex].Cells[0].Value.ToString()));
                paramList.Add(new SqlParameter("@paramSubId", Convert.ToInt32(lblFaturaID.Text)));
                paramList.Add(new SqlParameter("@paramCode", txtBillCode.Text));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool faturaSil()
        {
            bool result = false;
            try
            {
                DialogResult dr = MessageBox.Show("Fatura Türü Silinecektir: " + Tbox_Ekle_Fatura_Tur.Text + " Onaylıyor Musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM [dbo].[SubTypebyId]" +
                         "WHERE [SubId] =@paramSubId";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramSubId", Convert.ToInt32(lblFaturaID.Text)));
                    result = Connect_DB.sendQuery(query, paramList);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
      
        private bool addCompany()
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO [dbo].[CompanyList] (" +
                    "[CompanyName]," +
                    "[CompanyType]," +
                    "[CompanyInfo]," +
                    "[CompanyBank]," +
                    "[CompanyIBAN]," +
                    "[UnitPrice] )" +
                     "VALUES (" +
                    "@paramCompanyName    ," +
                    "@paramCompanyType    ," +
                    "@paramCompanyInfo    ," +
                    "@paramCompanyBank   ," +
                    "@paramCompanyIBAN    ," +
                    "@paramUnitPrice     )";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramCompanyName ", Tbox_Kurum_Adı.Text));
                paramList.Add(new SqlParameter("@paramCompanyType ", Tbox_kurum_tipi.Text));
                paramList.Add(new SqlParameter("@paramCompanyInfo ", TboxAciklama.Text));
                paramList.Add(new SqlParameter("@paramCompanyBank", Tbox_Banka.Text));
                paramList.Add(new SqlParameter("@paramCompanyIBAN", Tbox_Iban.Text));
                paramList.Add(new SqlParameter("@paramUnitPrice", TboxUnitPrice.Text));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool updateCompany()
        {
            bool result = false;
            try
            {
                string query = "UPDATE [dbo].[CompanyList] SET " +
                    "[CompanyName] = @paramCompanyName," +
                    "[CompanyType] = @paramCompanyType," +
                    "[CompanyInfo] = @paramCompanyInfo ," +
                    "[CompanyBank] = @paramCompanyBank," +
                    "[CompanyIBAN] = @paramCompanyIBAN ," +
                    "[UnitPrice] = @paramUnitPrice " +
                    "WHERE [CompanyId] = @paramCompanyId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramCompanyName ", Tbox_Kurum_Adı.Text));
                paramList.Add(new SqlParameter("@paramCompanyType ", Tbox_kurum_tipi.Text));
                paramList.Add(new SqlParameter("@paramCompanyInfo ", TboxAciklama.Text));
                paramList.Add(new SqlParameter("@paramCompanyBank", Tbox_Banka.Text));
                paramList.Add(new SqlParameter("@paramCompanyIBAN", Tbox_Iban.Text));
                paramList.Add(new SqlParameter("@paramUnitPrice", TboxUnitPrice.Text));
                paramList.Add(new SqlParameter("@paramCompanyId", Convert.ToInt32(Tbox_Kurum_No.Text)));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool deleteCompany()
        {
            bool result = false;
            try
            {
                DialogResult dr = MessageBox.Show("Şirket Silinecektir: " + Tbox_Kurum_Adı.Text + " Onaylıyor Musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM [dbo].[CompanyList]" +
                         "WHERE [CompanyId] =@paramCompanyId";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramCompanyId", Convert.ToInt32(Tbox_Kurum_No.Text)));
                    result = Connect_DB.sendQuery(query, paramList);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void DGV_Bills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblFaturaID.Text = DGV_Bills.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbox_Ekle_Fatura_Tur.Text = DGV_Bills.Rows[e.RowIndex].Cells[1].Value.ToString();
                Cbox_Company_Bill.Items.Clear();
                for (int i = 0; i < DGVPay.RowCount; i++)
                {
                    Cbox_Company_Bill.Items.Add(DGVPay.Rows[i].Cells[0].Value.ToString());
                }

                Cbox_Company_Bill.SelectedItem = DGV_Bills.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBillCode.Text = DGV_Bills.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void DGVPay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Tbox_Kurum_No.Text = DGVPay.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbox_Kurum_Adı.Text = DGVPay.Rows[e.RowIndex].Cells[1].Value.ToString();
                Tbox_kurum_tipi.Text = DGVPay.Rows[e.RowIndex].Cells[2].Value.ToString();
                TboxAciklama.Text = DGVPay.Rows[e.RowIndex].Cells[3].Value.ToString();
                Tbox_Banka.Text = DGVPay.Rows[e.RowIndex].Cells[4].Value.ToString();
                Tbox_Iban.Text = DGVPay.Rows[e.RowIndex].Cells[5].Value.ToString();
                TboxUnitPrice.Text = DGVPay.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbox_Company_Bill_DropDown(object sender, EventArgs e)
        {
            try
            {
                Cbox_Company_Bill.Items.Clear();
                for ( int i = 0; i < DGVPay.RowCount; i++)
                {
                    Cbox_Company_Bill.Items.Add(DGVPay.Rows[i].Cells[0].Value.ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region OkulTürü
        private void DTVShowSchoolType(DataTable dt)
        {
            try
            {
                DGVSchoolType.DataSource = dt;
                DGVSchoolType.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void refreshSchoolType()
        {
            try
            {
                string query = "SELECT" +
                     " [SchoolType] as 'Okul Tipi'," +
                     " [SchoolTypeId] as 'Okul Tipi Nu'," +
                     "[Code] as 'Bütçe Kodu' " +
                     "FROM [dbo].[SchoolTypebyId]";
                DTVShowSchoolType(Connect_DB.getQuery(query));
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool TypeEkle()
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO [dbo].[SchoolTypebyId] ([SchoolType], [Code])" +
                     "VALUES (@paramSchoolType, @paramCode); ";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolType", txtSchoolType.Text));
                paramList.Add(new SqlParameter("@paramCode", txtSchoolCode.Text));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool TypeGuncelle()
        {

            bool result = false;
            try
            {
                string query = "UPDATE [dbo].[SchoolTypebyId] SET" +
                    "  [SchoolType]=@paramSchoolType, " +
                    "[Code] = @paramCode " +
                     "WHERE [SchoolTypeId] =@paramSchoolTypeId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolType", txtSchoolType.Text));
                paramList.Add(new SqlParameter("@paramSchoolTypeId", lblSchoolTypeNu.Text));
                paramList.Add(new SqlParameter("@paramCode", txtSchoolCode.Text));
                result = Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool TypeSil()
        {
            bool result = false;
            try
            {
                DialogResult dr = MessageBox.Show("Fatura Türü Silinecektir: " + Tbox_Ekle_Fatura_Tur.Text + " Onaylıyor Musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM [dbo].[SubTypebyId]" +
                         "WHERE [SchoolTypeId] =@paramSchoolTypeId";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramSchoolTypeId", lblSchoolTypeNu.Text));
                    result = Connect_DB.sendQuery(query, paramList);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void btnSchoolTypeNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSchoolTypeNew.Text == "Yeni Kayıt")
                {
                    txtSchoolType.Enabled = true;
                    txtSchoolType.Text = "";
                    lblSchoolTypeNu.Text = "";
                    txtSchoolCode.Text = "";
                    txtBillCode.Enabled = true;
                    btnSchoolTypeNew.Text = "Kaydet";
                }
                else if (btnSchoolTypeNew.Text == "Kaydet")
                {
                    TypeEkle();
                    txtSchoolType.Enabled = false;

                    txtBillCode.Text = ""; txtBillCode.Enabled = false;
                    txtSchoolType.Text = "";
                    lblSchoolTypeNu.Text = "";
                    txtSchoolCode.Text = "";
                    btnSchoolTypeNew.Text = "Yeni Kayıt";
                    refreshSchoolType();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnSchoolTypeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSchoolTypeUpdate.Text == "Güncelleme")
                {
                    txtSchoolType.Enabled = true;
                    txtSchoolCode.Enabled = true;
                    btnSchoolTypeUpdate.Text = "Kaydet";
                }
                else if (btnSchoolTypeUpdate.Text == "Kaydet" && (txtSchoolType.Text != "" || txtSchoolType.Text != string.Empty))
                {
                    TypeGuncelle();
                    txtSchoolType.Enabled = false;
                    txtSchoolCode.Text = ""; txtSchoolCode.Enabled = false;
                    txtSchoolType.Text = "";
                    lblSchoolTypeNu.Text = "";
                    txtSchoolCode.Text = "";
                    btnSchoolTypeUpdate.Text = "Güncelleme";
                    refreshSchoolType();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnSchoolTypeDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSchoolType.Text != "" || Tbox_Ekle_Fatura_Tur.Text != string.Empty)
                {
                    TypeSil();
                    txtSchoolType.Enabled = false;
                    txtSchoolType.Text = "";
                    txtSchoolCode.Text = "";
                    txtBillCode.Text = ""; txtBillCode.Enabled = false;
                    lblSchoolTypeNu.Text = "";
                    refreshSchoolType();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region Form

        private void ProgramAyarları_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Modul.CompanyName + " - Program Ayarları";
                refreshUser();
                refreshBillData();
                refreshPay();
                refreshSchoolType();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProgramAyarları_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkClose)
            {
                Modul.ModulObject.Show();
            }
        }


        #endregion

        private void DGVSchoolType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSchoolType.Text = DGVSchoolType.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblSchoolTypeNu.Text = DGVSchoolType.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSchoolCode.Text = DGVSchoolType.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}
