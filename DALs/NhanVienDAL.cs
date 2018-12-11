using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data;
namespace DALs
{
    public class NhanVienDAL:Connect
    {
        SqlConnection conn;
        string connstring = @"Data Source=admin\SQLEXPRESS;Initial Catalog=QuanLyThuVienBTL;Integrated Security=True";

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from NhanVien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVienDTO aNV = new NhanVienDTO(reader["MaNhanVien"].ToString(), reader["HoTen"].ToString()
                    , reader["ChucVu"].ToString(), reader["TaiKhoan"].ToString(), reader["MatKhau"].ToString(), reader["Quyen"].ToString());
                dsNhanVien.Add(aNV);
            }
            conn.Close();
            return dsNhanVien;
        }
        public void ThemNhanVien(NhanVienDTO nvMoi)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into NhanVien values (@ma,@ten,@cv,@tk,@mk,@quyen)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", nvMoi.MaNhanVien);
            command.Parameters.AddWithValue("@ten", nvMoi.HoTen);
            command.Parameters.AddWithValue("@cv", nvMoi.ChucVu);
            command.Parameters.AddWithValue("@tk", nvMoi.TaiKhoan);
            command.Parameters.AddWithValue("@mk", nvMoi.MatKhau);
            command.Parameters.AddWithValue("@quyen", nvMoi.Quyen);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public void XoaNhanVien(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from NhanVien where MaNhanVien = @ma";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", ma);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public List<NhanVienDTO> TimNhanVien(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from NhanVien where MaNhanVien = @ma";
            command.Connection = conn; ;
            command.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            List<NhanVienDTO> dsNVCanTim = new List<NhanVienDTO>();
            while (reader.Read())
            {
                NhanVienDTO aNV = new NhanVienDTO(reader["MaNhanVien"].ToString(), reader["HoTen"].ToString()
                    , reader["ChucVu"].ToString(), reader["TaiKhoan"].ToString(), reader["MatKhau"].ToString(), reader["Quyen"].ToString());
                dsNVCanTim.Add(aNV);
            }
            conn.Close();
            return dsNVCanTim;
        }
        public void SuaNhanVien(NhanVienDTO nvSua)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update NhanVien set MaNhanVien = @ma,HoTen=@ten,ChucVu=@cv,TaiKhoan=@tk,MatKhau=@mk,Quyen=@quyen where MaNhanVien=@ma";
            command.Connection = conn;
            command.Parameters.AddWithValue("@ma", nvSua.MaNhanVien);
            command.Parameters.AddWithValue("@ten", nvSua.HoTen);
            command.Parameters.AddWithValue("@cv", nvSua.ChucVu);
            command.Parameters.AddWithValue("@tk", nvSua.TaiKhoan);
            command.Parameters.AddWithValue("@mk", nvSua.MatKhau);
            command.Parameters.AddWithValue("@quyen", nvSua.Quyen);
            int ret = command.ExecuteNonQuery();
            conn.Close();
        }
        public string getDangNhap(string tk,string mk)
        {
            string Id = "";
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MaNhanVien,Quyen from NhanVien where TaiKhoan = @tk and MatKhau = @mk";
            command.Parameters.AddWithValue("@tk",tk);
            command.Parameters.AddWithValue("@mk",mk);
            command.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Id = row["MaNhanVien"].ToString() + "-" + row["Quyen"].ToString();
                }
            }
            return Id;
        }


        public List<NhanVienDTO> getNhanVien()
        {
            con.Open();
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read() == true)
            {
                NhanVienDTO item = new NhanVienDTO(read["MaNhanVien"].ToString(), read["HoTen"].ToString(),
                    read["ChucVu"].ToString(), read["TaiKhoan"].ToString(), read["MatKhau"].ToString(),
                    read["Quyen"].ToString());

                dsNhanVien.Add(item);
            }
            con.Close();
            return dsNhanVien;
        }
        public string get_manv(string ma)
        {
            string key = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE HoTen=@ten", con);
                cmd.Parameters.AddWithValue("ten", ma);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                key = read["MaNhanVien"].ToString();
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
        public string get_tennv(string ma)
        {
            string key = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNhanVien=@ma", con);
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                key = read["HoTen"].ToString();
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
    }
}
