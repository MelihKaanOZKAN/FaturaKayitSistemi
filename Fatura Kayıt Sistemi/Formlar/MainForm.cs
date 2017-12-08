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
using Fatura_Kayıt_Sistemi.Formlar;

namespace Fatura_Kayıt_Sistemi
{
    public partial class MainForm_Fatura_Kayıt : Form
    {
        public static string k_adi, unvan, permList, perm;
        public static int userId;
        public static int SchoolId = 0;
        public MainForm_Fatura_Kayıt()
        {
            InitializeComponent();
        }
        private void yetkiIsle(string Yetki)
        {
            string[] dizi = Yetki.Split(';');
            for (int i = 0; i < dizi.Length; i++)
            {
                switch (dizi[i])
                {
                    case "#001":
                        {
                            Btn_Yeni_ky.Enabled = true;
                            btn_update.Enabled = true;
                            btn_delete.Enabled = true;
                            DGV_main.Enabled = true;
                            break;
                        }
                    case "#002":
                        {
                            DGV_main.Enabled = true;
                            break;
                        }
                    case "#022":
                        {
                            faturaSorgulamaToolStripMenuItem.Enabled = true;
                            break;
                        }
                    case "#023":
                        {
                            faturaEkleToolStripMenuItem.Enabled = true;
                            break;
                        }
                    case "#024":
                        {
                            harcamaTalimatıToolStripMenuItem.Visible = true;
                            ödemelerToolStripMenuItem.Visible = true;
                            break;
                        }
                }
            }
            if (perm == "Admin")
            {
                yönetimPaneliToolStripMenuItem.Visible = true;
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_welcome.Text = k_adi + "  kullanıcı adıyla giriş yaptınız.";
                lblLoginTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                string CompanyName = "";
                string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0]["SetValue"].ToString();
                this.Text = CompanyName + " - Ana Ekran";
                yetkiIsle(permList);
                GetMainQuery();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DTV_Show(DataTable dt)
        {
            try
            {
                DGV_main.DataSource = dt;
                DGV_main.Refresh();
                DGV_main.Columns[3].Visible = false;
                fillSchoolType();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void School()
        {
            try
            {
                int ogrenci_sayi = 0;
               
                lbl_Message.Text = "Kayıtlı Okul Sayısı: " + ogrenci_sayi.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Tbox_Ara_O_Adı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Tbox_Ara_O_Adı.Text = Tbox_Ara_O_Adı.Text.Trim();
                if (Tbox_Ara_O_Adı.Text != "")
                {
                    string query = "SELECT [SchoolId] as 'Okul Nu', [SchoolName] as 'Okul Adı', ST.[SchoolType] as 'Okul Türü',  SI.[SchoolType] FROM [dbo].[SchoolInfo] SI " +
                     "inner join [dbo].[SchoolTypebyId] ST on SI.[SchoolType] = ST.[SchoolTypeID] WHERE SI.[SchoolName] LIKE @Q + '%' " +
                     " ORDER BY [SchoolId] ASC";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@Q", Tbox_Ara_O_Adı.Text));
                    DTV_Show(Connect_DB.getQuery(query, paramList));
                }
                else
                {
                    GetMainQuery();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewSchool()
        {
            try
            {
                string query = "INSERT INTO [dbo].[SchoolInfo] (" +
                    "[SchoolName], [SchoolType] )" +
                    "VALUES ( @paramSchoolName, @paramSchoolType) ;";
                string[] tmp = Cbox_Okul_Türü.SelectedItem.ToString().Split(' ');
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolName", Tbox_Okul_Adı.Text));
                paramList.Add(new SqlParameter("@paramSchoolType", tmp[0]));
                Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_Yeni_ky_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Yeni_ky.Text == "Yeni Kayıt")
                {
                    Tbox_Okul_Adı.Enabled = true;
                    doEmpty();
                    Cbox_Okul_Türü.Enabled = true;
                    

                    Btn_Yeni_ky.Text = "Kaydet";
                }
                else if (Btn_Yeni_ky.Text == "Kaydet")
                {
                    if (Tbox_Okul_Adı.Text == string.Empty)
                    {
                        lbl_Message.Text = "Bilgi Girin: Okul Adı ";
                        lbl_Message.Visible = true;
                    }
                    else
                    {
                        addNewSchool();
                        doEmpty();
                        Tbox_Okul_Adı.Enabled = false;
                        Cbox_Okul_Türü.Enabled = false;
                        lbl_Message.Text = "Kayıt Başarılı!";
                        Btn_Yeni_ky.Text = "Yeni Kayıt";
                        lbl_Message.Visible = true;
                        GetMainQuery();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSchool()
        {
            try
            {
                string query = "DELETE FROM [dbo].[SchoolInfo] WHERE [SchoolId] = @paramSchoolId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolId", Tbox_Okul_No.Text));
                Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_Okul_No.Text == "")
                {
                    lbl_Message.Text = "Seçim Yapın";
                    lbl_Message.Visible = true;
                    goto gend;
                }
                string ogr_no = Tbox_Okul_No.Text;
                DialogResult dr = MessageBox.Show("Kayıt Silinecek! okul no: " + ogr_no, "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    deleteSchool();
                    doEmpty();
                    Tbox_Okul_Adı.Enabled = false;
                    Cbox_Okul_Türü.Enabled = false;
                    lbl_Message.Visible = true;
                    GetMainQuery();
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

        private void GetMainQuery()
        {
            try
            {if (SchoolId == 0)
                {
                    string query = "SELECT [SchoolId] as 'Okul Nu', [SchoolName] as 'Okul Adı', ST.[SchoolType] as 'Okul Türü',  SI.[SchoolType] FROM [dbo].[SchoolInfo] SI " +
                      "inner join [dbo].[SchoolTypebyId] ST on SI.[SchoolType] = ST.[SchoolTypeID]  ORDER BY [SchoolId] ASC";
                    DTV_Show(Connect_DB.getQuery(query));
                }
            else
                {
                    string query = "SELECT [SchoolId] as 'Okul Nu', [SchoolName] as 'Okul Adı', ST.[SchoolType] as 'Okul Türü',  SI.[SchoolType] FROM [dbo].[SchoolInfo] SI " +
                        "inner join [dbo].[SchoolTypebyId] ST on SI.[SchoolType] = ST.[SchoolTypeID] WHERE [SchoolId] = @paramSchoolId ORDER BY [SchoolId] ASC";
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("@paramSchoolId", SchoolId));
                    DTV_Show(Connect_DB.getQuery(query, paramList));
                    lbl_ara_isim.Visible = false;
                    Tbox_Ara_O_Adı.Visible = false;
                    Point loc = new Point(10, 27);
                    DGV_main.Location = loc;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateSchoolAndSubs()
        {
            try
            {
                string query = " UPDATE [dbo].[SchoolInfo] SET " +
                    "[SchoolName] = @paramSchoolName, [SchoolType] = @paramSchoolType WHERE [SchoolId]=@paramSchoolId";
                string[] tmp = Cbox_Okul_Türü.SelectedItem.ToString().Split(' ');
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolName", Tbox_Okul_Adı.Text));
                paramList.Add(new SqlParameter("@paramSchoolType", tmp[0]));
                paramList.Add(new SqlParameter("@paramSchoolId", Tbox_Okul_No.Text));
                Connect_DB.sendQuery(query, paramList);
                /*
                for (int i = 0; i < DGVSubs.RowCount; i++)
                {
                    if (DGVSubs.Rows[i].Cells["Abone Numarası"].Value.ToString() != "")
                    {
                        query = "IF EXISTS(SELECT [SubNumber] FROM [dbo].[Subs] WHERE [SubNumberId] = @paramSubNumberId) " +
                                "BEGIN " +

                                "UPDATE [dbo].[Subs] SET " +
                                "[SubNumber]=@paramSubNumber  WHERE [SubNumberId] = @paramSubNumberId " +

                                "END " +
                                "ELSE " +
                                "BEGIN " +

                                "INSERT INTO [dbo].[Subs] ([SubNumber], [SchoolId], [SubId]) VALUES(@paramSubNumber, @paramSchoolId, @paramSubId) " +

                                "END ";
                        paramList.Clear();
                        paramList.Add(new SqlParameter("@paramSubNumberId", DGVSubs.Rows[i].Cells["SubNumberId"].Value));
                        paramList.Add(new SqlParameter("@paramSubNumber", DGVSubs.Rows[i].Cells["Abone Numarası"].Value));
                        Connect_DB.sendQuery(query, paramList);
                    }
                }*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            { if (Tbox_Okul_No.Text=="")
                {
                    lbl_Message.Text = "Seçim Yapın.";
                    goto end;
                }
                if (btn_update.Text == "Güncelleme")
                {
                    DGVSubs.ReadOnly = true;
                    yeniKayıtEkleToolStripMenuItem.Enabled = true;
                    Tbox_Okul_Adı.Enabled = true;
                    Cbox_Okul_Türü.Enabled = true;
                    Tbox_Okul_No.BackColor = Color.White;
                    Cbox_Okul_Türü.BackColor = Color.White;
                    Tbox_Okul_No.BackColor = Color.White;
                    Tbox_Okul_Adı.BackColor = Color.White;
                    btn_update.Text = "Kaydet";
                }
                else if (btn_update.Text == "Kaydet")
                {
                    updateSchoolAndSubs();
                    doEmpty();
                    yeniKayıtEkleToolStripMenuItem.Enabled = false;
                    Tbox_Okul_Adı.Enabled = false;
                    Cbox_Okul_Türü.Enabled = false;
                    lbl_Message.Text = "Güncelleme Başarılı!";
                    btn_update.Text = "Güncelleme";
                    GetMainQuery();
                }
            end:;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void doEmpty()
        {
            try
            {
                Tbox_Okul_Adı.Text = "";
                Tbox_Okul_No.Text = "";
                Cbox_Okul_Türü.SelectedItem = "Seçiniz!";
                Tbox_Okul_No.BackColor = Color.White;
                Cbox_Okul_Türü.BackColor = Color.White;
                Tbox_Okul_No.BackColor = Color.White;
                Tbox_Okul_Adı.BackColor = Color.White;
                DGVSubs.ReadOnly = true;
                DGVSubs.DataSource = null;
                DGVSubs.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
     
        private void getSubs()
        {
            try
            {
                string query = "SELECT [SubNumberId], st.[SubId], [SubType] as 'Abonelik Türü', [SubNumber] as 'Abone Numarası' FROM [dbo].[SubTypebyID] st inner join [dbo].[Subs] sb on  st.SubId = sb.SubId and sb.SchoolId = @paramSchoolId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSchoolId", Tbox_Okul_No.Text));
                DGVSubs.DataSource = Connect_DB.getQuery(query, paramList);
                DGVSubs.Columns[0].Visible = false;
                DGVSubs.Columns[1].Visible = false;
                DGVSubs.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void DGV_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   Tbox_Okul_No.Text = DGV_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbox_Okul_Adı.Text = DGV_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                Cbox_Okul_Türü.SelectedItem = DGV_main.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + DGV_main.Rows[e.RowIndex].Cells[2].Value.ToString();
                getSubs();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void oluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Harcama_Talimati_Olusturucu form = new Fatura_Kayıt_Sistemi.Harcama_Talimati_Olusturucu();
            form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void harcamaKurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Harcama_Kurumu form = new Fatura_Kayıt_Sistemi.Harcama_Kurumu();
                form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modul form = new Fatura_Kayıt_Sistemi.Modul();
            form.Show();
        }

        private void işlemiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                doEmpty();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetMainQuery();
                doEmpty();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ödemeSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Formlar.frmPaymentsList form = new Formlar.frmPaymentsList();
                form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onaydaBekleyenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Formlar.frmPaymentsList form = new Formlar.frmPaymentsList();
                form.onlyPending = true;
                form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVSubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (btn_update.Text != "Güncelleme")
                    {

                    int SubId = 0;
                    try
                    {
                        SubId = Convert.ToInt32(DGVSubs.Rows[e.RowIndex].Cells[0].Value);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Geçersiz Seçim");
                    }

                    if (SubId != 0)
                    {
                        subAddorUpdate form = new subAddorUpdate();
                        form.Mode = true;
                        form.SubId = SubId;
                        form.ShowDialog();
                        getSubs();
                    }
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yeniKayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                try
                {
                    subAddorUpdate form = new subAddorUpdate();
                    form.Mode = false;
                form.SchoolId = Convert.ToInt32(Tbox_Okul_No.Text);
                    form.ShowDialog();
                    getSubs();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramAyarları form = new ProgramAyarları();
                form.checkClose = true;
                form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void faturaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Fatura_Ekle form = new Fatura_Kayıt_Sistemi.Fatura_Ekle();
                form.SchoolId = SchoolId;
                form.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void faturaDökümüAlToolStripMenuItem_Click(object sender, EventArgs e)
        { try
            {
                Fatura_Dokum form = new Fatura_Kayıt_Sistemi.Fatura_Dokum();
                if (SchoolId != 0)
                {
                    form.Tbox_Okul_No.Text = SchoolId.ToString();
                }
                form.Show();
            }
           
              catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
