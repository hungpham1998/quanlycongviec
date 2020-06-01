using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class inbaocaotonghop_DAL: DBconnect
    {
        public DataTable Get_baocaotonghop(int id) 
        {
            using (SqlConnection conn = getConnect())
            {

                SqlCommand cmd = new SqlCommand("inbaocaotonghop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        
    }
}
