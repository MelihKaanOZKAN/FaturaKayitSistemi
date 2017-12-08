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
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System.Diagnostics;
using Microsoft.Reporting.WinForms;

namespace Fatura_Kayıt_Sistemi
{
    public partial class Fatura_Dokum : Form
    {
        private List<SqlParameter> paramList = new List<SqlParameter>();
        private bool permEdit = false, permChange = false;
        public int PaymentID = 0;
        public Fatura_Dokum()
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
                    case "#024":
                        {
                            gBoxPayment.Visible = true;
                            break;
                        }
                    case "#021":
                        {
                            permEdit = true;
                            break;
                        }

                }
            }
            if (MainForm_Fatura_Kayıt.perm == "Admin")
            {
                permChange = true;
            }
        }

        private void Fatura_Dokum_Load(object sender, EventArgs e)
        {
            try
            {

                string CompanyName = "";
                string query = "SELECT [SetValue] FROM [dbo].[ProgramSettings] WHERE [SetName] = 'CompanyName'";
                DataTable dt = Connect_DB.getQuery(query);
                CompanyName = dt.Rows[0][0].ToString();
                this.Text = CompanyName + " - Fatura Sorgulama";
                yetkiIsle(MainForm_Fatura_Kayıt.permList);

                fillBillTypes();
                fillSchoolType();
                comboxBillDateMounth.SelectedIndex = DateTime.Now.Month - 1;
                comboxBillDateYear.SelectedItem = DateTime.Now.Year.ToString();
                paramList.Clear();
                if (this.PaymentID != 0)
                {
                    gBoxFilter.Visible = false;
                    permEdit = false;
                    chkBoxCorrectData.Visible = false;
                    chkBoxCorrectData.Checked = true;
                    checkBoxSelectAll.Visible = false;
                    Point loc = new Point(21, 121);
                    DGV_main.Location = loc;
                    DGV_main.Height = 599;
                    DGV_main.Refresh();
                    DGV_main.RefreshEdit();
                    sorgula();
                }
                gBoxPayment.Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                getSchoolInfo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  void DTV_Show(DataTable dt)
        {
            try
            {
                dt.Columns.Add();
                int index = dt.Columns.Count - 1;
                dt.Columns[index].DataType = typeof(string);
                dt.Columns[index].ColumnName = "Fatura Durumu";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (dt.Rows[i][index - 1].ToString())
                    {
                        case "False":
                            dt.Rows[i][index] = "Bekliyor"; break;
                        case "True":
                            dt.Rows[i][index] = "İşleme Alındı/Ödendi"; break;
                    }
                }
                DGV_main.DataSource = dt;
                DGV_main.Refresh();
                DGV_main.Columns[index - 1].Visible = false;
                if (dt.Rows.Count > 0)
                {

                    double SumAmount = Convert.ToDouble(dt.Compute("SUM([Fatura Tutarı])", string.Empty));
                    double SumTax = Convert.ToDouble(dt.Compute("SUM([Katma Değer Vergisi])", string.Empty));
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

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void CheckBox_Only_Notpay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (CheckBox_Only_Notpay.Checked == true)
                {
                   
                    checkBox_Only_Odenen.Checked = false;
                    checkBox_Only_Odenen.Enabled = false;
                   

                }
                else
                {
                    checkBox_Only_Odenen.Enabled = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }

        private void checkBox_Only_Odenen_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (checkBox_Only_Odenen.Checked == true)
                {

                    CheckBox_Only_Notpay.Checked = false;
                    CheckBox_Only_Notpay.Enabled = false;

                }
                else
                {
                    CheckBox_Only_Notpay.Enabled = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }

        private void Fatura_Dokum_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GC.Collect();
                this.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
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
                    case "Ocak":{ month = 1; break;
                    }
                     case "Şubat":{ month = 2; break;
                    } case "Mart":{ month = 3; break;
                    } case "Nisan":{ month =4; break;
                    } case "Mayıs":{ month = 5; break;
                    } case "Haziran":{ month = 6; break;
                    } case "Temmuz":{ month = 7; break;
                    } case "Ağustos":{ month = 8; break;
                    } case "Eylül":{ month = 9; break;
                    } case "Ekim":{ month = 10; break;
                    } case "Kasım":{ month = 11; break;
                    } case "Aralık":{ month = 12; break;
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

        private bool checkOnlyScID()
        {
            try
            {
                bool result = false;
                SqlParameter param = new SqlParameter("@paramSchoolId", SqlDbType.Int);
                if (Tbox_Okul_No.Text != "")
                {

                    param.Value = Convert.ToInt32(Tbox_Okul_No.Text);
                    paramList.Add(param);
                    result = true;
                }
                else
                {
                    paramList.Remove(param);
                    result = false;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string paramCheck(string query)
        {
            try
            {
                if (this.PaymentID != 0)
                {
                    query += "WHERE [PaymentId] = @paramPaymentId ";
                    paramList.Add(new SqlParameter("@paramPaymentId", this.PaymentID));
                }
                else
                {
                  query+=  "WHERE [BillDate] > @paramOne AND [BillDate] <= @paramTwo ";
                    getDates();
                }
                if (checkOnlyScID())
                {
                    query += "AND Bls.[SchoolId]=@paramSchoolId ";
                  
                }
                if (Cbox_Fatura_Türü.Text != "")
                {
                    query += "AND SBS.[SubId] =@paramSubType ";
                    string secim = Cbox_Fatura_Türü.SelectedItem.ToString();
                    string[] tmp = secim.Split(' ');
                    SqlParameter param = new SqlParameter("@paramSubType", SqlDbType.Int);
                    param.Value = tmp[0];
                    paramList.Add(param);
                }
                if (Cbox_Okul_Türü.Text != "")
                {
                    SqlParameter param = new SqlParameter("@paramSchoolType", SqlDbType.Int);
                    query += "AND ScT.[SchoolTypeId]=@paramSchoolType ";
                    string secim = Cbox_Okul_Türü.SelectedItem.ToString();
                    string[] tmp = secim.Split(' ');
                    param.Value = Convert.ToInt32(tmp[0]);
                    paramList.Remove(param3);
                    paramList.Add(param);
                }
                if (checkBox_Only_Odenen.Checked)
                {
                    query += "AND [BillStatus]=@paramBillStatus ";
                    SqlParameter param = new SqlParameter("@paramBillStatus", SqlDbType.Bit);
                    param.Value = System.Data.SqlTypes.SqlBoolean.True;
                    paramList.Add(param);
                }
                if (CheckBox_Only_Notpay.Checked)
                {
                    query += "AND [BillStatus]=@paramBillStatus ";
                    SqlParameter param = new SqlParameter("@paramBillStatus", SqlDbType.Bit);
                    param.Value = System.Data.SqlTypes.SqlBoolean.False;
                    paramList.Add(param);

                }
                query += " ORDER BY [BillId] ASC ";
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
                if (chkBoxCorrectData.Checked)
                {
                    string query = "Select  [BillId] as 'Fatura Nu'," +
                 "Bls.[SchoolId] as 'Okul Nu'," +
                 "[SchoolName] as 'Okul Adı'," +
                 "[SubNumber] as 'Abone Numarası', " +
                 "[BillDate] as 'Fatura Tarihi'," +
                 "[BillLastPayDate] as 'Son Ödeme Tarihi'," +
                 " [BillConsumption] as 'Tüketim Miktarı'," +
                 " [BillAmount] as 'Fatura Tutarı'," +
                 " [BillTax] as 'Katma Değer Vergisi'," +
                 " [BillStatus] as 'Fatura Ödeme Durumu'" +
                 "  FROM [dbo].[BillsCorrect] Bls " +
                 "   inner join [dbo].[Subs] SBS on SBS.[SubNumberId] = Bls.[BillTypeId] "+
                    "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
                 "inner join [dbo].[SubTypebyID] STI on SBS.[SubId] = STI.[SubId]" +
                 "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType] ";


                    query = paramCheck(query);

                    DTV_Show(Connect_DB.getQuery(query, paramList));
                    paramList.Clear();
                }
                else
                {


                    string query = "Select  [BillId] as 'Fatura Nu'," +
                 "Bls.[SchoolId] as 'Okul Nu'," +
                 "[SchoolName] as 'Okul Adı'," +
                 "[SubNumber] as 'Abone Numarası', " +
                 "[BillDate] as 'Fatura Tarihi'," +
                 "[BillLastPayDate] as 'Son Ödeme Tarihi'," +
                 " [BillConsumption] as 'Tüketim Miktarı'," +
                 " [BillAmount] as 'Fatura Tutarı'," +
                 " [BillTax] as 'Katma Değer Vergisi'," +
                 " [BillStatus] as 'Fatura Ödeme Durumu'" +
                 "  FROM [dbo].[Bills] Bls " +
                 "   inner join [dbo].[Subs] SBS on SBS.[SubNumberId] = Bls.[BillTypeId] "+
                    "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
                 "inner join [dbo].[SubTypebyID] STI on SBS.[SubId] = STI.[SubId]" +
                 "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType] ";


                    query = paramCheck(query);

                    DTV_Show(Connect_DB.getQuery(query, paramList));
                    paramList.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                sorgula();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }

        SqlParameter param3;
        private void Cbox_Okul_Türü_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbox_Fatura_Türü.Text != "" && Cbox_Okul_Türü.Text != "")
                {
                    btnSorgulama.Enabled = true;
                    checkBoxSelectAll.Enabled = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_F_D_Al_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxCorrectData.Checked)
                {
                    string query = "Select  " +
                       "ROW_NUMBER() OVER (order by BillId asc) as [BillId], " +
                 " Bls.[SchoolId]," +
                  "[SchoolName]," +
                  "ScT.[SchoolType]," +
                  "SBS.[SubNumber], " +
                  "[BillDate]," +
                   "[BillConsumption]," +
                  " [BillAmount]," +
                  " [BillTax]," +
                   "[BillStatus]," +
                   "STI.[SubType]" +
                  " FROM[dbo].[BillsCorrect] Bls " +
                    "   right join [dbo].[Subs] SBS on SBS.[SubNumberId] = Bls.[BillTypeId] " +
                       "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
                    "inner join [dbo].[SubTypebyID] STI on SBS.[SubId] = STI.[SubId]" +
                    "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType] ";

                    query = paramCheck(query);

                    Formlar.frmReport form = new Formlar.frmReport(query, paramList);
                    form.Show();
                    Close();
                } else
                {
                    string query = "Select  " +
                        "ROW_NUMBER() OVER (order by BillId asc) as [BillId], " +
                  " Bls.[SchoolId]," +
                   "[SchoolName]," +
                   "ScT.[SchoolType]," +
                   "SBS.[SubNumber], " +
                   "[BillDate]," +
                    "[BillConsumption]," +
                   " [BillAmount]," +
                   " [BillTax]," +
                    "[BillStatus]," +
                    "STI.[SubType]" +
                   " FROM[dbo].[Bills] Bls " +
                    "   right join [dbo].[Subs] SBS on SBS.[SubNumberId] = Bls.[BillTypeId] " +
                       "inner join [dbo].[SchoolInfo] SI on SI.[SchoolId] = Bls.[SchoolId]" +
                    "inner join [dbo].[SubTypebyID] STI on SBS.[SubId] = STI.[SubId]" +
                    "inner join [dbo].[SchoolTypebyID] ScT on ScT.[SchoolTypeId] = SI.[SchoolType] ";

                    query = paramCheck(query);

                    Formlar.frmReport form = new Formlar.frmReport(query, paramList);
                    form.Show();
                    Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }

        }

    

        private void Tbox_Okul_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }
        
        private void Cbox_Fatura_Türü_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbox_Fatura_Türü.Text != "" && Cbox_Okul_Türü.Text != "")
                {
                    btnSorgulama.Enabled = true;
                    checkBoxSelectAll.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
      

        private void DGV_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            düzenleToolStripMenuItem.Enabled = true;
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool test = permEdit;
                int selection = DGV_main.SelectedRows[0].Index;
                Fatura_Duzenle form = new Fatura_Duzenle();
                form.BillId = DGV_main.Rows[selection].Cells[0].Value.ToString();
                form.BillDate = Convert.ToDateTime(DGV_main.Rows[selection].Cells[4].Value);
                form.SchoolId = Convert.ToInt32(DGV_main.Rows[selection].Cells[1].Value);
                if (chkBoxCorrectData.Checked)
                {
                    form.isCorrect = true;
                    form.permEdit = permChange;

                }
                else
                {
                    form.isCorrect = false;
                    form.permEdit = permEdit;
                }
                form.ShowDialog();
                düzenleToolStripMenuItem.Enabled = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MakePayment()
        {
            try
            {
                string query = "INSERT INTO [dbo].[Payments] (SubTypeId,  SchoolTypeId, PaymentDate, PaymentStatus, PaymentAmount, PaymentTax, PaymentConsumption, PaymentCreatorPerson)" +
                    " VALUES (@paramSubTypeId, @paramSchoolTypeId, @paramPaymentDate, 0, @paramPaymentAmount, @paramPaymentTax, @paramPaymentConsumption, @paramCreatorPerson) " +
                    "SELECT SCOPE_IDENTITY()";
                List<SqlParameter> paramList = new List<SqlParameter>();
                string[] tmp = Cbox_Okul_Türü.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramSchoolTypeId", tmp[0]));

                 tmp = Cbox_Fatura_Türü.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramSubTypeId", tmp[0]));

                paramList.Add(new SqlParameter("@paramPaymentDate", DateTime.Now.ToShortDateString()));
                paramList.Add(new SqlParameter("@paramPaymentAmount", Convert.ToDouble(Tbox_Top_Tutar.Text)));
                paramList.Add(new SqlParameter("@paramPaymentTax", Convert.ToDouble(Tbox_Top_KDV.Text)));
                paramList.Add(new SqlParameter("@paramPaymentConsumption", Convert.ToDouble(Tbox_Top_Harcama.Text)));
                paramList.Add(new SqlParameter("@paramCreatorPerson", MainForm_Fatura_Kayıt.userId));
                DataTable dt = Connect_DB.getQuery(query, paramList);
                int paymentId = Convert.ToInt32(dt.Rows[0][0].ToString());
                paramList.Clear();

                for (int i = 0; i < DGV_main.SelectedRows.Count; i++)
                {
                    query = "UPDATE [dbo].[BillsCorrect] SET [PaymentId] = @paramPaymentId, [BillStatus]=1  FROM [dbo].[BillsCorrect] Bls inner join [dbo].[Subs] SBS on Bls.[BillTypeId] = SBS.[SubNumberId] WHERE ";
                    paramList.Add(new SqlParameter("@paramPaymentId", paymentId));

                    query += " [BillId] = @paramBillId ";
                    paramList.Add(new SqlParameter("@paramBillId", Convert.ToInt32(DGV_main.Rows[i].Cells[0].Value.ToString())));

                    query += " AND ";
                    query += "[BillDate] = @paramBillDate ";

                    paramList.Add(new SqlParameter("@paramBillDate", DGV_main.Rows[i].Cells[4].Value.ToString()));
                    query += " AND ";
                    query += " Bls.[SchoolId] = @paramSchoolId ";
                    paramList.Add(new SqlParameter("@paramSchoolId", Convert.ToInt32(DGV_main.Rows[i].Cells[1].Value.ToString())));
                    query += " AND ";
                    query += " SBS.[SubNumber] =@paramSubNumber";

                    paramList.Add(new SqlParameter("@paramSubNumber", DGV_main.Rows[i].Cells[3].Value.ToString()));
                    Connect_DB.sendQuery(query, paramList);
                    paramList.Clear();
                }
                Formlar.frmPaymentManage form = new Formlar.frmPaymentManage();
                form.PaymentId = paymentId;
                form.CreatorPerson = MainForm_Fatura_Kayıt.userId;
                form.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                MakePayment();
                Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void DGV_main_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int check = 0;
                if (DGV_main.SelectedRows.Count > 0)
                {
                    double BillAmount = 0;
                    double BillTax = 0;
                    double BillConsumption = 0;
                        for (int i = 0; i < DGV_main.SelectedRows.Count; i++)
                        {
                            int index = DGV_main.SelectedRows[i].Index;
                            BillConsumption += Convert.ToDouble(DGV_main.Rows[index].Cells[6].Value.ToString());
                            BillAmount += Convert.ToDouble(DGV_main.Rows[index].Cells[7].Value.ToString());
                            BillTax += Convert.ToDouble(DGV_main.Rows[index].Cells[8].Value.ToString());
                        
                            if(Convert.ToBoolean(DGV_main.Rows[index].Cells[9].Value) == false)
                                {
                                 check++;
                                }
                        }
                    Tbox_Top_Tutar.Text = BillAmount.ToString();
                    Tbox_Top_KDV.Text = BillTax.ToString();
                    Tbox_Top_Harcama.Text = BillConsumption.ToString();
                    if(check == DGV_main.SelectedRows.Count)
                    {
                        btnPayment.Enabled = true;
                    }
                    else
                    {

                        btnPayment.Enabled = false;
                    }
                }
                else
                {
                    double BillAmount = 0;
                    double BillTax = 0;
                    double BillConsumption = 0;
                    Tbox_Top_Tutar.Text = BillAmount.ToString();
                    Tbox_Top_KDV.Text = BillTax.ToString();
                    Tbox_Top_Harcama.Text = BillConsumption.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxSelectAll.Checked)
                {
                   for ( int i = 0; i < DGV_main.Rows.Count; i++ )
                    {
                        DGV_main.Rows[i].Selected = true;
                    }
                }
                else
                {

                    for (int i = 0; i < DGV_main.Rows.Count; i++)
                    {
                        DGV_main.Rows[i].Selected = false;
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void getSchoolInfo()
        {
            try
            {
                if (Tbox_Okul_No.Text != "" && Tbox_Okul_No.Text != Convert.ToString(0))
                {
                    string query = "SELECT SI.[SchoolType] as 'SchoolTypeId', ScT.[SchoolType] FROM [dbo].[SchoolInfo] SI " +
                       "inner join [dbo].[SchoolTypebyId] ScT on Sct.[SchoolTypeId]=SI.[SchoolType] WHERE SI.[SchoolId] = @paramSchoolId;";
                    List<SqlParameter> paramList_ = new List<SqlParameter>();
                    paramList_.Add(new SqlParameter("@paramSchoolId", Convert.ToInt32(Tbox_Okul_No.Text)));
                    DataTable dt = Connect_DB.getQuery(query, paramList_);
                    Cbox_Okul_Türü.Items.Clear();
                    Cbox_Okul_Türü.Items.Add(dt.Rows[0]["SchoolTypeId"].ToString() + " " + dt.Rows[0]["SchoolType"].ToString());
                    Cbox_Okul_Türü.SelectedIndex = 0;
                    // Cbox_Okul_Türü.Enabled = false;
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void Tbox_Okul_No_TextChanged(object sender, EventArgs e)
        {
            try
            {   if (MainForm_Fatura_Kayıt.SchoolId != 0)
                {

                    if (Tbox_Okul_No.Text == Convert.ToString(0))
                    {
                        Tbox_Okul_No.Text = string.Empty;
                        Tbox_Okul_No.Enabled = true;
                    }
                    else
                    {

                        Tbox_Okul_No.Enabled = false;
                        getSchoolInfo();
                    }
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void chkBoxCorrectData_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxCorrectData.Checked)
                {
                    gBoxPayment.Visible = true;
                }
                else
                {
                    gBoxPayment.Visible = false;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void chBoxAllYear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chBoxAllYear.Checked)
                {
                    comboxBillDateMounth.Enabled = false;
                    comboxBillDateYear.Enabled = false;
                }
                else
                {

                    comboxBillDateMounth.Enabled = true;
                    comboxBillDateYear.Enabled = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
