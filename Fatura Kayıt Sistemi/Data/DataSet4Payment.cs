using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fatura_Kayıt_Sistemi.Data
{


    partial class DataSet4Payment
    {
    }
}

namespace Fatura_Kayıt_Sistemi.Data.DataSet4PaymentTableAdapters {


    public partial class BillsTableAdapter {
       
        public void SetSelectCommand(DataSet4PaymentTableAdapters.BillsTableAdapter ta, string query)
        {
            SqlCommand command = new SqlCommand(query);
            command.Connection = Connect_DB.con;
            ta.CommandCollection[0] = command;
        }
        public Data.DataSet4Payment.BillsDataTable SetSelectCommand(DataSet4PaymentTableAdapters.BillsTableAdapter ta, string query, List<SqlParameter> paramList, Data.DataSet4Payment.BillsDataTable DT)
        {

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(paramList.ToArray());
            command.Connection = Connect_DB.con;
            Connect_DB.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(DT);
            command.Parameters.Clear();
            return DT;
        }
        public void SetUpdateCommand(DataSet4PaymentTableAdapters.BillsTableAdapter ta, string query)
        {
            SqlCommand command = new SqlCommand(query);
            command.Connection = Connect_DB.con;
            ta.CommandCollection[1] = command;
        }
        public void SetUpdateCommand(DataSet4PaymentTableAdapters.BillsTableAdapter ta, List<SqlParameter> paramList)
        {
            string query = "Update  [dbo].[Bills] SET" +
                   "[SchoolId] = @paramSchoolId," +
                   "[BillTypeId] = @paramBillTypeId," +
                   "[BillDate]= @paramBillDate," +
                   "[BillConsumption] = @paramBillConsumption," +
                   "[BillAmount] = @paramBillAmount," +
                   "[BillTax] = @paramBillTax," +
                   "[BillStatus] = @paramBillStatus," +
                   "[BillImage] = @paramBillImage " +
                   " WHERE [BillId] = @paramBillId AND [BillDate]= @paramBillOldDate AND [SchoolId] = @paramOldSchoolId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(paramList.ToArray());
            command.Connection = Connect_DB.con;
            ta.CommandCollection[1] = command;
        }
    }
}
