using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Fatura_Kayıt_Sistemi.Formlar
{
    public partial class frmPaymentManage : Form
    {
        public int PaymentId = 0;
        public int CreatorPerson = 0;
        public frmPaymentManage()
        {
            InitializeComponent();
        }
        
        private bool LoadPaymentInfo()
        {
            try
            {
                bool result = false;
                string query = "SELECT " +
                    "SubTypeId," +
                    "SBT.SubType," +
                    "PaymentDate," +
                    " PaymentConfirmDate, " +
                    "PaymentAmount, " +
                    "PaymentTax," +
                    "PaymentNote," +
                    " PaymentConsumption," +
                    " PaymentConfirmPerson," +
                    "UL.[UserName]," +
                    " PaymentStatus," +
                    " OrderOfPaymentNumber," +
                    " OrderOfPaymentConfirmDate," +
                    "py.SchoolTypeId," +
                    "Sct.SchoolType," +
                    "PaymentCreatorPerson," +
                    "UM.[UserName]" +
                    "FROM dbo.Payments py " +
                    "left join  [dbo].[UserList] UL on UL.[UserId] = py.[PaymentConfirmPerson] " +
                    "left join  [dbo].[UserList] UM on UM.[UserId] = py.[PaymentCreatorPerson] " +
                    "left join [dbo].[SubTypebyId] SBT on SBT.[SubId] = py.[SubTypeId]" +
                    "left join [dbo].[SchoolTypebyId] Sct on Sct.[SchoolTypeId] = py.[SchoolTypeId] " +
                    "WHERE py.[PaymentId] = @paramPaymentId";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramPaymentId", this.PaymentId));
                DataTable dt = Connect_DB.getQuery(query, paramList);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ödeme Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    result = true;
                    paymentIdTextBox.Text = this.PaymentId.ToString();
                    subTypeIdTextBox.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                    txtSchoolType.Text = dt.Rows[0][13].ToString() + " " + dt.Rows[0][14].ToString();
                    paymentDateDateTimePicker.Value = (DateTime)dt.Rows[0][2];

                    paymentConfirmDateDateTimePicker.Value = (DateTime)dt.Rows[0][3];

                    paymentAmountTextBox.Text = dt.Rows[0][4].ToString();

                    paymentTaxTextBox.Text = dt.Rows[0][5].ToString();

                    txtDeny.Text = dt.Rows[0][6].ToString();

                    paymentConsumptionTextBox.Text = dt.Rows[0][7].ToString();

                    paymentConfirmPersonComboBox.SelectedItem = dt.Rows[0][8].ToString() + " " + dt.Rows[0][9].ToString();

                    paymentStatusComboBox.SelectedIndex = Convert.ToInt32(dt.Rows[0][10]);

                    orderOfPaymentNumberTextBox.Text = dt.Rows[0][11].ToString();

                    orderOfPaymentConfirmDateDateTimePicker.Value = (DateTime)dt.Rows[0][12];

                    comboBoxCreatorPerson.SelectedItem = dt.Rows[0][15].ToString() + " " + dt.Rows[0][16].ToString();

                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadUserList()
        {
            try
            {
                string query = "SELECT [UserId], [UserName] FROM [dbo].[UserList]";
                DataTable dt = Connect_DB.getQuery(query);
                paymentConfirmPersonComboBox.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    paymentConfirmPersonComboBox.Items.Add(dt.Rows[i]["UserId"].ToString() + " " + dt.Rows[i]["UserName"].ToString());
                    if (Convert.ToInt32(dt.Rows[i]["UserId"]) == CreatorPerson)
                    {
                       paymentConfirmPersonComboBox.SelectedIndex = paymentConfirmPersonComboBox.Items.Count - 1;
                    }
                    comboBoxCreatorPerson.Items.Add(dt.Rows[i]["UserId"].ToString() + " " + dt.Rows[i]["UserName"].ToString());
                    if (Convert.ToInt32(dt.Rows[i]["UserId"]) == CreatorPerson)
                    {
                        comboBoxCreatorPerson.SelectedIndex = comboBoxCreatorPerson.Items.Count - 1;
                        comboBoxCreatorPerson.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        string confirmUser;
        private void Check(int tmp)
        {
            try
            {
                if (tmp != MainForm_Fatura_Kayıt.userId)
                {
                    gBoxPaymentInfo.Enabled = false;
                    orderOfPaymentConfirmDateDateTimePicker.Enabled = false;
                    orderOfPaymentNumberTextBox.Enabled = false;
                    gBoxConfirm.Enabled = false;
                    gBoxConfirmPerson.Enabled = false;
                }
                else
                {
                    gBoxConfirm.Enabled = true;
                    gBoxOrder.Enabled = true;
                    orderOfPaymentConfirmDateDateTimePicker.Enabled = false;
                    orderOfPaymentNumberTextBox.Enabled = true;
                    btnHarcamatalimatı.Enabled = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CheckPaymentStatus()
        {
            confirmUser = paymentConfirmPersonComboBox.Text;
            
            string[] tmp = confirmUser.Split(' ');
            int ConfirmUser = Convert.ToInt32(tmp[0]);
            tmp = comboBoxCreatorPerson.SelectedItem.ToString().Split(' ');
            int CreatorUser = Convert.ToInt32(tmp[0]);
            int status = paymentStatusComboBox.SelectedIndex;
            comboBoxCreatorPerson.Enabled = false;
            if (ConfirmUser != MainForm_Fatura_Kayıt.userId && CreatorUser != MainForm_Fatura_Kayıt.userId)
            {
                gBoxPaymentInfo.Enabled = false;
                orderOfPaymentConfirmDateDateTimePicker.Enabled = false;
                orderOfPaymentNumberTextBox.Enabled = false;
                gBoxConfirm.Enabled = false;
                gBoxConfirmPerson.Enabled = false;
            }
            tmp = confirmUser.Split(' ');
            if (status != 0)
            {
                gBoxPaymentInfo.Enabled = false;
                gBoxConfirmPerson.Enabled = false;
                gBoxOrder.Enabled = false;
            }
            if (status == 0)
            {
                gBoxOrder.Enabled = false;
            }
            if (status == 1)
            {
                if (ConfirmUser != MainForm_Fatura_Kayıt.userId)
                {
                    gBoxPaymentInfo.Enabled = false;
                    orderOfPaymentConfirmDateDateTimePicker.Enabled = false;
                    orderOfPaymentNumberTextBox.Enabled = false;
                    gBoxConfirm.Enabled = false;
                    gBoxConfirmPerson.Enabled = false;
                }
                else
                {
                    gBoxPaymentInfo.Enabled = false;
                    orderOfPaymentConfirmDateDateTimePicker.Enabled = false;
                    orderOfPaymentNumberTextBox.Enabled = false;
                    gBoxConfirm.Enabled = true;
                    gBoxConfirmPerson.Enabled = true;
                }
            }
            if (status == 2)
            {
              
                Check(ConfirmUser);
            }
            if (status == 3)
            {
                gBoxOrder.Enabled = true;
                orderOfPaymentNumberTextBox.Enabled = false;
                orderOfPaymentConfirmDateDateTimePicker.Enabled = true;
                btnDeny.Enabled = false;
                btnHarcamatalimatı.Enabled = true;
            }
            if (status == 4)
            {
                gBoxConfirm.Enabled = false;
                btnHarcamatalimatı.Enabled = false;
            }
           
        }
        private void LoadData()
        {
            try
            {
                LoadUserList();
                if (!LoadPaymentInfo())
                {
                    Close();
                }
                else
                {
                    CheckPaymentStatus();
                }
            }
            catch (Exception )
            {

               throw;

            }
        }
        private void frmPaymentManage_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnShowBills_Click(object sender, EventArgs e)
        {
            try
            {
                Fatura_Dokum form = new Fatura_Dokum();
                form.PaymentID = PaymentId;
                form.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void deleteData()
        {
            try
            {
                string query = "DELETE FROM [dbo].[Payments] WHERE [PaymentId] = @paramPaymentId ";
                query += " UPDATE [dbo].[BillsCorrect] SET PaymentId = 0, BillStatus = 0 WHERE PaymentId = @paramPaymentId";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramPaymentId", this.PaymentId));
                Connect_DB.sendQuery(query, paramList);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sendData(int status)
        {
            try
            {
                string query = "UPDATE [dbo].[Payments] SET " +
                " PaymentNote = @paramPaymentNote," +
                " PaymentConfirmPerson =@paramPerson," +
                " PaymentCreatorPerson =@paramCreatorPerson," +
                " PaymentConfirmDate= @paramConfirmDate," +
                " PaymentStatus =@paramStatus," +
                " OrderOfPaymentNumber = @paramOrderNumber," +
                " OrderOfPaymentConfirmDate = @paramOrderDate " +
                "WHERE [PaymentId] = @paramPaymentId ";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@paramPaymentNote", txtDeny.Text));
                string[] tmp = paymentConfirmPersonComboBox.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramPerson", Convert.ToInt32(tmp[0])));
                tmp = comboBoxCreatorPerson.SelectedItem.ToString().Split(' ');
                paramList.Add(new SqlParameter("@paramCreatorPerson", Convert.ToInt32(tmp[0])));
                paramList.Add(new SqlParameter("@paramStatus", status));
                paramList.Add(new SqlParameter("@paramOrderNumber", orderOfPaymentNumberTextBox.Text));
                paramList.Add(new SqlParameter("@paramOrderDate", orderOfPaymentConfirmDateDateTimePicker.Value));
                paramList.Add(new SqlParameter("@paramPaymentId", this.PaymentId));
                paramList.Add(new SqlParameter("@paramConfirmDate", paymentConfirmDateDateTimePicker.Value));

                Connect_DB.sendQuery(query, paramList);
                if (Convert.ToInt32(tmp[0]) != MainForm_Fatura_Kayıt.userId)
                {
                    Close();
                }
                else
                {
                    LoadUserList();
                    if (!LoadPaymentInfo())
                    {
                        Close();
                    }
                    else
                    {
                        CheckPaymentStatus();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                paymentConfirmDateDateTimePicker.Value = DateTime.Now;
                int PaymentStatus = paymentStatusComboBox.SelectedIndex;
                if (PaymentStatus < 4)
                {
                    PaymentStatus++;
                    if (PaymentStatus == 2)
                    {
                        int tmp = comboBoxCreatorPerson.SelectedIndex;

                        comboBoxCreatorPerson.SelectedIndex = paymentConfirmPersonComboBox.SelectedIndex;
                        paymentConfirmPersonComboBox.SelectedIndex = tmp;
                    }
                    sendData(PaymentStatus);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                paymentConfirmDateDateTimePicker.Value = DateTime.Now;
                int PaymentStatus = paymentStatusComboBox.SelectedIndex;
                if (PaymentStatus == 0)
                {
                    DialogResult dr = MessageBox.Show("Ödeme Silinecektir.", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        deleteData();
                    }
                }
                else
                {
                    if (PaymentStatus == 1)
                    {
                        int tmp = comboBoxCreatorPerson.SelectedIndex;

                        comboBoxCreatorPerson.SelectedIndex = paymentConfirmPersonComboBox.SelectedIndex;
                        paymentConfirmPersonComboBox.SelectedIndex = tmp;
                    }
                    if (PaymentStatus > 2)
                    {
                        paymentConfirmPersonComboBox.SelectedIndex = comboBoxCreatorPerson.SelectedIndex;
                    }
                    PaymentStatus = 0;
                    sendData(PaymentStatus);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void paymentConfirmPersonComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnConfirm.Enabled = true;
                btnDeny.Enabled = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnHarcamatalimatı_Click(object sender, EventArgs e)
        {
            try
            {
                Harcama_Talimati_Olusturucu form = new Harcama_Talimati_Olusturucu();
                form.PaymentId = this.PaymentId;
                form.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
