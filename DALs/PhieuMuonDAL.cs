using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTOs;
namespace DALs
{
    public class PhieuMuonDAL:Connect
    {
        public DataTable getPhieuMuon()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public bool them(PhieuMuonDTO item)
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO PhieuMuon VALUES(@maphieu, @madg, @ngaymuon, @manv)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("maphieu", item.MaPhieuMuon);
                cmd.Parameters.AddWithValue("madg", item.MaDocGia);
                cmd.Parameters.AddWithValue("ngaymuon", item.NgayMuon);
                cmd.Parameters.AddWithValue("manv", item.MaNhanVien);
                if (cmd.ExecuteNonQuery() > 0)
                return true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
