using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_Kayıt_Sistemi.Formlar
{
    public partial class subAddorUpdate : Form
    {
        public bool Mode = false;
        public int SubId = 0;
        public int SchoolId = 0;

        public subAddorUpdate()
        {
            InitializeComponent();
        }
        private void GetSubs()
        {
            try
            {

                string query = "SELECT [SubId], [SubType] FROM [dbo].[SubTypebyId]";
                DataTable dt = Connect_DB.getQuery(query);
                cmbSubs.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbSubs.Items.Add(dt.Rows[i]["SubId"].ToString() + " " + dt.Rows[i]["SubType"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void getSub(int SubId)
        {
            try
            {
                string query = "SELECT  st.[SubId], [SubType] as 'Abonelik Türü', [SubNumber] as 'Abone Numarası' FROM [dbo].[SubTypebyID] st left join [dbo].[Subs] sb on  st.SubId = sb.SubId WHERE SubNumberId=@paramSubNumberId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubNumberId", SubId));
                DataTable dt = Connect_DB.getQuery(query, paramList);
                string billType = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                cmbSubs.SelectedItem = billType;
                txtSubNumber.Text = dt.Rows[0][2].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void subAddorUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                string CompanyName = "";
                string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0]["SetValue"].ToString();
                GetSubs();
                if (!Mode)
                {
                    this.Text = CompanyName + " - Abonelik Ekle";
                    btnDelete.Visible = false;
                }
                else
                {

                    this.Text = CompanyName + " - Abonelik Güncelle";
                    getSub(this.SubId);

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool updateSub(int SubId)
        {
            bool result = false;
            try
            {
                string query = "UPDATE [dbo].[Subs] SET SubId = @paramSubId, SubNumber=@paramSubNumber WHERE SubNumberId=@paramSubNumberId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubNumberId", SubId));
                paramList.Add(new SqlParameter("@paramSubNumber", txtSubNumber.Text));
                String[] tmp = cmbSubs.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramSubId", tmp[0]));
                
                result = Connect_DB.sendQuery(query, paramList);

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        private bool addSub(int SchoolId)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO [dbo].[Subs] (SubId, SubNumber, SchoolId) VALUES (@paramSubId, @paramSubNumber, @paramSchoolId)";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubNumber", txtSubNumber.Text));
                String[] tmp = cmbSubs.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramSubId", tmp[0]));

                paramList.Add(new SqlParameter("@paramSchoolId", SchoolId));
                result = Connect_DB.sendQuery(query, paramList);

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        private void doAddOrUpdate()
        {
            try
            {
                if (Mode)
                {
                    if (updateSub(this.SubId))
                    {
                        MessageBox.Show("Güncelleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (addSub(SchoolId))
                    {
                        MessageBox.Show("Kayıt Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
               if(cmbSubs.SelectedItem.ToString() != "" && txtSubNumber.ToString() != "")
                {
                    doAddOrUpdate();
                }
                else
                {
                    MessageBox.Show("Abonelik tipi seçilmeli ve abone numarası yazılmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void deleteSub(int subId)
        {
            try
            {
                string query = "DELETE FROM dbo.Subs WHERE SubNumberId=@paramSubNumberId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramSubNumberId", SubId));
                Connect_DB.sendQuery(query, paramList);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR = MessageBox.Show("Geçerli Abonelik Silinecektir!", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (DR == DialogResult.Yes)
                {
                    deleteSub(SubId);
                    this.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
