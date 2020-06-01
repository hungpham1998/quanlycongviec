using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class baocaotonghop_DAL:DBconnect
   {
        public DataTable Get_baocaotonghop()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_baocaotonghop", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int baocaotonghop_them(DOT_baocaotonghop bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_baocaotonghop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matv", bc.matv));
                cmd.Parameters.Add(new SqlParameter("@mada", bc.mada));
                cmd.Parameters.Add(new SqlParameter("@tondong", bc.tondong));
                cmd.Parameters.Add(new SqlParameter("@ngayht", bc.ngayht));
                cmd.Parameters.Add(new SqlParameter("@dexuat", bc.dexuat));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool baocaotonghop_sua(DOT_baocaotonghop bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_baocaotonghop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mabcth", bc.mabcth));
                cmd.Parameters.Add(new SqlParameter("@matv", bc.matv));
                cmd.Parameters.Add(new SqlParameter("@mada", bc.mada));
                cmd.Parameters.Add(new SqlParameter("@tondong", bc.tondong));
                cmd.Parameters.Add(new SqlParameter("@ngayht", bc.ngayht));
                cmd.Parameters.Add(new SqlParameter("@dexuat", bc.dexuat));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool baocaotonghop_xoa(DOT_baocaotonghop bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_baocaotonghop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mabcth", bc.mabcth));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}
