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
    public partial class frmPaymentsList : Form
    {
        private List<SqlParameter> paramList = new List<SqlParameter>();
        public bool onlyPending = false;
        public frmPaymentsList()
        {
            InitializeComponent();
        }
        private void checkPending()
        {
            if (onlyPending)
            {
                gBoxFilter.Visible = false;
                grpRapor.Visible = false;
                grpToplam.Visible = false;
                Point loc = new Point(8, 3);
                DGV_main.Location = loc;
                DGV_main.Height = 686;
                DGV_main.Refresh();
                DGV_main.RefreshEdit();
                sorgula();
                timerRefresh.Enabled = true;
                timerRefresh.Interval = 10000;
                timerRefresh.Start();
            }
        }
        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            string CompanyName = "";
            string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
            DataTable dt = Connect_DB.getQuery(query);
            CompanyName = dt.Rows[0][0].ToString();
            this.Text = CompanyName + " - Ödeme  Sorgulama";

            fillBillTypes();
            comboxBillDateMounth.SelectedIndex = DateTime.Now.Month - 1;
            comboxBillDateYear.SelectedItem = DateTime.Now.Year.ToString();
            paramList.Clear();
            checkPending();
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


        public void DTV_Show(DataTable dt)
        {
            try
            { // 0 1 2 3 4 5 6 7 8 9 
                dt.Columns.Add();
                int index = dt.Columns.Count -1;
                dt.Columns[index].DataType = typeof(string);
                dt.Columns[index].ColumnName = "Ödeme Durumu";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    switch (dt.Rows[i][index - 1 ].ToString())
                    {
                        case "0":
                            dt.Rows[i][index] = "Düzeltme Bekliyor"; break;
                        case "1":
                            dt.Rows[i][index] = "Onay Bekliyor"; break;
                        case "2":
                            dt.Rows[i][index] = "Onaylandı"; break;
                        case "3":
                            dt.Rows[i][index] = "Ödeme Emri Gönderildi"; break;
                        case "4":
                            dt.Rows[i][index] = "Muhasebeşti"; break;

                    }
                }
                dt.Columns.RemoveAt(index-1);
                DGV_main.DataSource = dt;
                DGV_main.Refresh();

                if (dt.Rows.Count > 0)
                {

                    double SumAmount = Convert.ToDouble(dt.Compute("SUM([Ödeme Tutarı])", string.Empty));
                    double SumTax = Convert.ToDouble(dt.Compute("SUM([Vergi Tutarı])", string.Empty));
                    int SumConsumption = Convert.ToInt32(dt.Compute("SUM([Tüketim Miktarı])", string.Empty));
                    Tbox_Top_Tutar.Text = SumAmount.ToString();
                    Tbox_Top_KDV.Text = SumTax.ToString();
                    Tbox_Top_Harcama.Text = SumConsumption.ToString();

                }
                else
                {
                    
                    Tbox_Top_Tutar.Text = String.Empty;
                    Tbox_Top_KDV.Text = String.Empty;
                    Tbox_Top_Harcama.Text = String.Empty;
                    grpRapor.Enabled = false;

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getDates()
        {
            SqlParameter param = new SqlParameter("@paramOne", SqlDbType.Date);
            SqlParameter param2 = new SqlParameter("@paramTwo", SqlDbType.Date);

            if (chBoxAllYear.Checked)
            {
                int year = Convert.ToInt32(comboxBillDateYear.Text);
                DateTime DT = new DateTime(year, 1, 1);

                param.Value = DT.Date;
                DT = new DateTime(year, 12, 31);
                param2.Value = DT.Date;
            }
            else
            {
                int month = 0;
                int year = Convert.ToInt32(comboxBillDateYear.Text);
                switch (comboxBillDateMounth.Text)
                {
                    case "Ocak":
                        {
                            month = 1; break;
                        }
                    case "Şubat":
                        {
                            month = 2; break;
                        }
                    case "Mart":
                        {
                            month = 3; break;
                        }
                    case "Nisan":
                        {
                            month = 4; break;
                        }
                    case "Mayıs":
                        {
                            month = 5; break;
                        }
                    case "Haziran":
                        {
                            month = 6; break;
                        }
                    case "Temmuz":
                        {
                            month = 7; break;
                        }
                    case "Ağustos":
                        {
                            month = 8; break;
                        }
                    case "Eylül":
                        {
                            month = 9; break;
                        }
                    case "Ekim":
                        {
                            month = 10; break;
                        }
                    case "Kasım":
                        {
                            month = 11; break;
                        }
                    case "Aralık":
                        {
                            month = 12; break;
                        }
                }
                DateTime DT = new DateTime(year, month, 1);

                param.Value = DT.Date;
                DT = new DateTime(year, month, DateTime.DaysInMonth(Convert.ToInt32(comboxBillDateYear.Text), month));
                param2.Value = DT.Date;
            }

            paramList.Add(param);
            paramList.Add(param2);
        }
        

        private string paramCheck(string query)
        {
            try
            {
                if (!onlyPending)
                {
                    query += "WHERE [PaymentDate] > @paramOne AND [PaymentDate] <= @paramTwo ";
                    getDates();
                }
                else
                {
                    paramList.Add(new SqlParameter("@paramPerson", MainForm_Fatura_Kayıt.userId));
                    query += "WHERE  [PaymentStatus] <> 4 AND ([PaymentConfirmPerson] = @paramPerson OR [PaymentCreatorPerson] = @paramPerson) ";
                }
                if (Cbox_Fatura_Türü.Text != "")
                {
                    query += "AND py.[SubTypeId]=@paramSubType ";
                    string secim = Cbox_Fatura_Türü.SelectedItem.ToString();
                    string[] tmp = secim.Split(' ');
                    SqlParameter param = new SqlParameter("@paramSubType", SqlDbType.Int);
                    param.Value = tmp[0];
                    paramList.Add(param);
                }
                if (cBoxStatus.Text != "")
                {
                    query += "AND py.[PaymentStatus]=@paramStatus ";
                    SqlParameter param = new SqlParameter("@paramStatus", SqlDbType.Int);
                    param.Value = cBoxStatus.SelectedIndex;
                    paramList.Add(param);
                }
                return query;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sorgula()
        {
            try
            {
                if (txtPayNo.Text == "")
                {

                    string query = "SELECT" +
                        " PaymentId as 'Ödeme Numarası', " +
                          "SBT.SubType as 'Ödeme Türü', " +
                          "PaymentDate as 'Oluşturulma Tarihi'," +
                          "UM.[UserName] as 'Oluşturan Kişi'," +
                          "UL.[UserName] as 'Onaylayacak Kişi'," +
                          "PaymentAmount as 'Ödeme Tutarı', " +
                          "PaymentTax as 'Vergi Tutarı'," +
                          "PaymentConsumption as 'Tüketim Miktarı'," +
                          "PaymentStatus " +
                          "FROM dbo.Payments py " +
                          "left join  [dbo].[UserList] UL on UL.[UserId] = py.[PaymentConfirmPerson]  " +
                          "left join  [dbo].[UserList] UM on UM.[UserId] = py.[PaymentCreatorPerson]  " +
                          "left join [dbo].[SubTypebyId] SBT on SBT.[SubId] = py.[SubTypeId] ";
                    query = paramCheck(query);

                    DTV_Show(Connect_DB.getQuery(query, paramList));
                    paramList.Clear();
                }
                else
                {
                    Formlar.frmPaymentManage form = new frmPaymentManage();
                    int PaymentId = Convert.ToInt32(txtPayNo.Text);
                    form.PaymentId = PaymentId;
                    form.ShowDialog();
                    txtPayNo.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSorgulama_Click(object sender, EventArgs e)
        {
            try
            {
                sorgula();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Formlar.frmPaymentManage form = new frmPaymentManage();
                int PaymentId = Convert.ToInt32(DGV_main.Rows[e.RowIndex].Cells[0].Value);
                form.PaymentId = PaymentId;
                form.ShowDialog();
                sorgula();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                sorgula();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
