using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGaraOto.DAL
{
     public class SqlConnect
    {
     private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
     public DataTable ExecuteQuery (string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }  
       
       
    }
}
