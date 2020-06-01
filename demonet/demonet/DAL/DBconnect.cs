using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class DBconnect
    {
        private String connStr = "Data Source=DESKTOP-2EOLT06;Initial Catalog=quanlycongviec;Integrated Security=True";
        public SqlConnection conn = null;
        public DBconnect()
        {
            conn = new SqlConnection(connStr);
        }
        public SqlConnection getConnect()
        {
            if (conn == null || conn.State == ConnectionState.Closed)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            return conn;
        }
    }
}
