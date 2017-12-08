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

namespace Fatura_Kayıt_Sistemi
{
    public partial class Kullanici_Yonetim : Form
    {
        public static SqlConnection con; public static SqlCommand command = new SqlCommand();
        public static string query = "";
        public static string[] arrYetki = new string[8];
        public Kullanici_Yonetim()
        {
            InitializeComponent();
        }
        private void YetkiAl()
        {
            for (int i = 0; i < arrYetki.Length; i++)
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
                    Btn_Yeni_ky.Text = "Kaydet";
                }
                else if (Btn_Yeni_ky.Text == "Kaydet")
                {
                     query = "INSERT INTO admin_list (username, pass, perm, unvan, MainPerm) VALUES(@user_, @pass_, @perm_, @unvan_, @MainPerm_)";
                    command.CommandText = query;
                    command.Parameters.Clear();
                    YetkiAl();
                    command.Parameters.AddWithValue("@user_", Tbox_Username.Text);
                    command.Parameters.AddWithValue("@pass_", Encrypt(Tbox_Pass.Text));
                    command.Parameters.AddWithValue("@perm_", arrYetki[7]);
                    command.Parameters.AddWithValue("@unvan_", Cbox_Unvan.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@MainPerm_", Cbox_Yetki.SelectedItem.ToString());
                    con.Open();
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    con.Close();
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
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
                    lbl_Message.Font = new Font("Arial", 20);
                    lbl_Message.BackColor = Color.Green;
                    lbl_Message.Text = "Kayıt Başarılı!";
                    Btn_Yeni_ky.Text = "Yeni Kayıt";
                    //lbl_Message.Visible = true;
                    query = "SELECT * FROM admin_list";
                    command.CommandText = query;
                    arrYetki = new string[7];
                    DTV_Show();
                }
            }
            catch (Exception hata)
            {
                con.Close();
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DTV_Show()
        {
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_main.DataSource = dt;
                con.Close();
                command.Parameters.Clear();
                DGV_main.Refresh();
                DGV_main.Columns[0].HeaderText = "Kullanıcı Adı";
                DGV_main.Columns[1].Visible = false;
                DGV_main.Columns[2].Visible = false;
                DGV_main.Columns[3].HeaderText = "Ünvan";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_Username.Text == "")
                {
                    lbl_Message.Font = new Font("Arial", 20);
                    lbl_Message.BackColor = Color.YellowGreen;
                    lbl_Message.Text = "Seçim Yapın";
                    lbl_Message.Visible = true;
                    goto gend;
                }
                DialogResult dr = MessageBox.Show("Kayıt Silinecek! Kullanıkcı Adı: " + Tbox_Username.Text, "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    query = "DELETE FROM admin_list WHERE username=@user_";
                    command.Connection = con;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@user_", Tbox_Username.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    con.Close();
                    lbl_Message.Font = new Font("Arial", 20);
                    lbl_Message.BackColor = Color.Red;
                    lbl_Message.Text = "Silme Başarılı!";
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
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
                    DTV_Show();

                }
                else if (dr == DialogResult.No)
                {

                }
                gend:;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
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
                    case "#030": Cbox_Numarator.Checked = true; break;
                }
            }
        }
        private void DGV_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Tbox_Username.Text = DGV_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                Cbox_Unvan.SelectedItem = DGV_main.Rows[e.RowIndex].Cells[3].Value.ToString();
                yetkiIsle(DGV_main.Rows[e.RowIndex].Cells[2].Value.ToString());
                Cbox_Yetki.SelectedItem = DGV_main.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_Username.Text == "")
                {
                    lbl_Message.Text = "Seçim Yapın.";
                    goto end;
                }
                if (btn_update.Text == "Güncelleme")
                {
                    Tbox_Username.Enabled = true;
                    Tbox_Pass.Enabled = true;
                    Cbox_Unvan.Enabled = true;
                    Cbox_Yetki.Enabled = true;
                    Yetkiler.Enabled = true;
                    btn_update.Text = "Kaydet";
                }
                else if (btn_update.Text == "Kaydet")
                {
                    if (Tbox_Pass.Text == string.Empty)
                    {
                        query = "UPDATE admin_list " +
                       "SET perm=@perm_, unvan=@unvan_, MainPerm=@MainPerm_ WHERE username=@user_";
                        command.CommandText = query;
                        YetkiAl();
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@user_", Tbox_Username.Text);
                        command.Parameters.AddWithValue("@perm_", arrYetki[7]);
                        command.Parameters.AddWithValue("@unvan_", Cbox_Unvan.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@MainPerm_", Cbox_Yetki.SelectedItem.ToString());

                    }
                   else
                    {
                        query = "UPDATE admin_list " +
                       "SET pass=@pass_, perm=@perm_, unvan=@unvan_, MainPerm=@MainPerm_ WHERE username=@user_";
                        command.CommandText = query;
                        YetkiAl();
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@user_", Tbox_Username.Text);
                        command.Parameters.AddWithValue("@pass_", Encrypt(Tbox_Pass.Text));
                        command.Parameters.AddWithValue("@perm_", arrYetki[7]);
                        command.Parameters.AddWithValue("@unvan_", Cbox_Unvan.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@MainPerm_", Cbox_Yetki.SelectedItem.ToString());
                    }
                    con.Open();
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    con.Close();
                    Tbox_Pass.Text = "";
                    Tbox_Username.Text = "";
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
                    lbl_Message.Font = new Font("Arial", 20);
                    lbl_Message.BackColor = Color.Yellow;
                    lbl_Message.Text = "Güncelleme Başarılı!";
                    btn_update.Text = "Güncelleme";
                    lbl_Message.Visible = true;
                    query = "SELECT * FROM admin_list";
                    command.CommandText = query;
                    arrYetki= new string[8];
                    DTV_Show();
                }
                end:;
            }
            catch (Exception hata)
            {
                con.Close();
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kullanici_Yonetim_Load(object sender, EventArgs e)
        {
            try
            {
                string CompanyName = "";
                query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0].ToString();
                this.Text = CompanyName + " - Kullanıcı Yönetim";
                query = "SELECT UserId, UserName, UserPassword, UserInfo, UserPerm, UserPermList FROM [dbo].[UserList]";
                DTV_Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void Kullanici_Yonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modul form = new Fatura_Kayıt_Sistemi.Modul();
            form.Show();
        }

        private void Cbox_Numarator_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbox_Numarator.Checked)
            {
                arrYetki[6] = "#030";
            }
            else
            {
                arrYetki[6] = null;
            }
        }
    }
}
