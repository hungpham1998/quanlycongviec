using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class nhanvien_DAL :DBconnect
    {
        public DataTable Get_nhanvien()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_nhanvien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int nhanvien_them(DOT_nhanvien nv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_nhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tennv", nv.tennv));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", nv.ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@diachi", nv.diachi));
                cmd.Parameters.Add(new SqlParameter("@taikhoan", nv.taikhoan));
                cmd.Parameters.Add(new SqlParameter("@matkhau", nv.matkhau));
                cmd.Parameters.Add(new SqlParameter("@chucvu", nv.chucvu));
                cmd.Parameters.Add(new SqlParameter("@sdt", nv.sdt));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool nhanvien_sua(DOT_nhanvien nv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_nhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manv", nv.manv));
                cmd.Parameters.Add(new SqlParameter("@tennv", nv.tennv));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", nv.ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@diachi", nv.diachi));
                cmd.Parameters.Add(new SqlParameter("@taikhoan", nv.taikhoan));
                cmd.Parameters.Add(new SqlParameter("@matkhau", nv.matkhau));
                cmd.Parameters.Add(new SqlParameter("@chucvu", nv.chucvu));
                cmd.Parameters.Add(new SqlParameter("@sdt", nv.sdt));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool nhanvien_xoa(DOT_nhanvien nv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_nhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manv", nv.manv));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public DataTable nhanvien_tim(DOT_nhanvien nv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("nhanvien_tim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tennv", nv.tennv));
                cmd.Parameters.Add(new SqlParameter("@chucvu", nv.chucvu));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
