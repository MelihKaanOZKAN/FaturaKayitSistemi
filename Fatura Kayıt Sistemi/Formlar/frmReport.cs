using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fatura_Kayıt_Sistemi.Data;
using Fatura_Kayıt_Sistemi.Formlar;
using System.Data.SqlClient;

namespace Fatura_Kayıt_Sistemi.Formlar
{
    public partial class frmReport : Form
    {

        public frmReport(string query, List<SqlParameter> paramList)
        {
            InitializeComponent();
            /*SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddRange(paramList.ToArray());*/
            this.dataTable1TableAdapter1.SetSelectCommand(this.dataTable1TableAdapter1, query, paramList);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter1.Fill(this.dataSet1.DataTable1);
                this.reportViewer1.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
