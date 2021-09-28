using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//<add using>
using System.Data.SqlClient;    //*local DB
using System.Data;              //*ConnectionState, DataTable
//</add using>

namespace The_Librarian.Classes
{
    /// <summary>
    /// 
    /// </summary>
    class Db
    {
        public static SqlConnection Get_DB_Connection()
        {
            string cn_string = Properties.Settings.Default.ConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open)
            {
                cn_connection.Open();
            }
            return cn_connection;
        }

        public static DataTable Get_DataTable(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, cn_connection);
            adapter.Fill(table);

            return table;
        }

        public static void Execute_SQL(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();

            SqlCommand cmd_command = new SqlCommand(SQL_Text, cn_connection);
            cmd_command.ExecuteNonQuery();

        }
        
        public static void Close_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.ConnectionString;

            SqlConnection cn_connection = new SqlConnection(cn_String);

            if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();

        }
    }
}
