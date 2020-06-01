using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class login_DAL : DBconnect
    {
      
        public bool dangnhap(string taikhoan, string matkhau)
        {
            using (SqlConnection conn = getConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("dangnhap_dangnhap", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@taikhoan", taikhoan));
                    cmd.Parameters.Add(new SqlParameter("@matkhau", matkhau));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                catch (Exception)
                {
                    return false;

                }
            }
        }
    }
}
