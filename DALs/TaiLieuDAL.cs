using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data.SqlClient;
namespace DALs
{
    public class TaiLieuDAL:Connect
    {
        SqlConnection conn;
        string connstring = @"Data Source=admin\SQLEXPRESS;Initial Catalog=QuanLyThuVienBTL;Integrated Security=True";
        public List<TaiLieuDTO> LayDanhSachTaiLieu()
        {
            List<TaiLieuDTO> dsTaiLieu = new List<TaiLieuDTO>();
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from TaiLieu";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                TaiLieuDTO aTL = new TaiLieuDTO(reader["MaTaiLieu"].ToString(), reader["TenTaiLieu"].ToString(), reader["MaTheLoai"].ToString(), int.Parse(reader["SoLuong"].ToString()),
                    reader["NhaXuatBan"].ToString(), int.Parse(reader["NamXuatBan"].ToString()), reader["TacGia"].ToString());
                dsTaiLieu.Add(aTL);
            }
            conn.Close();
            return dsTaiLieu;
        }
        public void ThemMotTaiLieu(TaiLieuDTO TLMoi)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into TaiLieu values (@ma,@ten,@matl,@sl,@nxb,@namxb,@tg)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", TLMoi.MaTaiLieu);
            command.Parameters.AddWithValue("@ten", TLMoi.TenTaiLieu);
            command.Parameters.AddWithValue("@matl", TLMoi.MaTheLoai);
            command.Parameters.AddWithValue("@sl", TLMoi.SoLuong);
            command.Parameters.AddWithValue("@nxb", TLMoi.NhaXuatBan);
            command.Parameters.AddWithValue("@namxb", TLMoi.NamXuatBan);
            command.Parameters.AddWithValue("@tg", TLMoi.TacGia);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public void SuaThongTinTaiLieu(TaiLieuDTO TLSua)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update TaiLieu set TenTaiLieu=@ten,MaTheLoai=@matl,SoLuong=@sl,NhaXuatBan=@nxb,NamXuatBan=@namxb,TacGia=@tg where MaTaiLieu=@ma";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", TLSua.MaTaiLieu);
            command.Parameters.AddWithValue("@ten", TLSua.TenTaiLieu);
            command.Parameters.AddWithValue("@matl", TLSua.MaTheLoai);
            command.Parameters.AddWithValue("@sl", TLSua.SoLuong);
            command.Parameters.AddWithValue("@nxb", TLSua.NhaXuatBan);
            command.Parameters.AddWithValue("@namxb", TLSua.NamXuatBan);
            command.Parameters.AddWithValue("@tg", TLSua.TacGia);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public void XoaMotTaiLieu(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from TaiLieu where MaTaiLieu=@ma";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma",ma);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public List<TaiLieuDTO> TimTaiLieu(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from TaiLieu where MaTaiLieu = @ma";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            List<TaiLieuDTO> ds = new List<TaiLieuDTO>();
            while(reader.Read())
            {
                TaiLieuDTO aTL = new TaiLieuDTO(reader["MaTaiLieu"].ToString(), reader["TenTaiLieu"].ToString(), reader["MaTheLoai"].ToString(), int.Parse(reader["SoLuong"].ToString()),
                   reader["NhaXuatBan"].ToString(),int.Parse(reader["NamXuatBan"].ToString()), reader["TacGia"].ToString());
                ds.Add(aTL);
            }
            conn.Close();
            return ds;
        }




        public List<TaiLieuDTO> getTaiLieu()
        {
            con.Open();
            List<TaiLieuDTO> dsTaiLieu = new List<TaiLieuDTO>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiLieu", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read() == true)
            {
                TaiLieuDTO item = new TaiLieuDTO(read["MaTaiLieu"].ToString(), read["TenTaiLieu"].ToString(),
                    read["MaTheLoai"].ToString(), Convert.ToInt32(read["SoLuong"]), read["NhaXuatBan"].ToString(),
                    int.Parse(read["NamXuatBan"].ToString()), read["TacGia"].ToString());
                dsTaiLieu.Add(item);
            }
            con.Close();
            return dsTaiLieu;
        }
        public String thongTinSLTL(string ma)
        {
            string key = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiLieu WHERE MaTaiLieu=@ma", con);
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                key = read["SoLuong"].ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return key;
        }
        public bool up_sl(int sl, string ma)
        {
            try
            {
                con.Open();
                string sql = "UPDATE TaiLieu SET SoLuong=@sl WHERE MaTaiLieu=@matl";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("sl", sl);
                cmd.Parameters.AddWithValue("matl", ma);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
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
