using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fatura_Kayıt_Sistemi.Data
{


    partial class DataSet
    {
    }
}

namespace Fatura_Kayıt_Sistemi.Data.DataSetTableAdapters
{


    public partial class DataTable1TableAdapter
    {

        public void SetSelectCommand(DataSetTableAdapters.DataTable1TableAdapter ta, string query)
        {
            SqlCommand command = new SqlCommand(query);
            command.Connection = Connect_DB.con;
            ta.CommandCollection[0] = command;
        }
        public void SetSelectCommand(DataSetTableAdapters.DataTable1TableAdapter ta, string query, List<SqlParameter> paramList)
        {
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(paramList.ToArray());
            command.Connection = Connect_DB.con;
            ta.CommandCollection[0] = command;
        }
        public void SetUpdateCommand(DataSetTableAdapters.DataTable1TableAdapter ta, string query)
        {
            SqlCommand command = new SqlCommand(query);
            command.Connection = Connect_DB.con;
            ta.CommandCollection[1] = command;
        }
        public void SetUpdateCommand(DataSetTableAdapters.DataTable1TableAdapter ta, string query, List<SqlParameter> paramList)
        {
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(paramList.ToArray());
            command.Connection = Connect_DB.con;
            ta.CommandCollection[1] = command;
        }

    }
}
