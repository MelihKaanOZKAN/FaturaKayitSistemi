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
    public partial class Harcama_Kurumu : Form
    {
        public Harcama_Kurumu()
        {
            InitializeComponent();
        }
        

        private void Tbox_Talimat_Oluştur_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Harcama_Kurumu_Load(object sender, EventArgs e)
        {
            try
            {
                string CompanyName = "";
               string  query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0][0].ToString();
                this.Text = CompanyName + " - Harcama Kurumuları";
                query = "SELECT " +
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
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnOlustur.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata Oluştu: \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DTVShowPay(DataTable dt)
        {
            try
            {
                DGVPay.DataSource = dt;
                DGVPay.Refresh();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                int CompanyId = Convert.ToInt32(Tbox_Kurum_No.Text);
                Harcama_Talimati_Olusturucu form = new Harcama_Talimati_Olusturucu();
                form.CompanyId = CompanyId;
                form.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
