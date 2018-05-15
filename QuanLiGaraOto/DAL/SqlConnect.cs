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
        private string strConn = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
        SqlConnection conn = null;

        public SqlConnection Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }

        public SqlConnect()
        {
            conn = new SqlConnection(strConn);
        }

        public void OpenConnect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnect()
        {
            if (conn.State ==  ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection conn = new  SqlConnection(strConn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;
        }


    }
}
