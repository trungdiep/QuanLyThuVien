using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
namespace DALs
{
    public class TheLoaiDAL:Connect
    {
        SqlConnection conn;
        string connstring = @"Data Source=admin\SQLEXPRESS;Initial Catalog=QuanLyThuVienBTL;Integrated Security=True";

        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            List<TheLoaiDTO> dsTheLoai = new List<TheLoaiDTO>();
            conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from TheLoai";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TheLoaiDTO aThL = new TheLoaiDTO
                    (
                        reader["MaTheLoai"].ToString(),
                        reader["TenTheLoai"].ToString(),
                        reader["GhiChu"].ToString()
                    );

                dsTheLoai.Add(aThL);
            }

            conn.Close();
            return dsTheLoai;
        }

        public void AddTheLoai(TheLoaiDTO ThLM)
        {
            conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into TheLoai values (@ma,@ten,@ghichu)";
            command.Connection = conn;

            //add values
            command.Parameters.AddWithValue("@ma", ThLM.MaTL);
            command.Parameters.AddWithValue("@ten", ThLM.TenTL);
            command.Parameters.AddWithValue("@ghichu", ThLM.GhiChu);

            int ret = command.ExecuteNonQuery();
            conn.Close();
        }

        public List<TheLoaiDTO> FindTaiLieu(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from TheLoai where MaTheLoai LIKE @ma";
            command.Connection = conn;

            command.Parameters.AddWithValue("ma", "%" + ma + "%");
            SqlDataReader reader = command.ExecuteReader();
            List<TheLoaiDTO> ds = new List<TheLoaiDTO>();
            while (reader.Read())
            {
                TheLoaiDTO aThL = new TheLoaiDTO
                    (
                        reader["MaTheLoai"].ToString(),
                        reader["TenTheLoai"].ToString(),
                        reader["GhiChu"].ToString()
                    );
                ds.Add(aThL);
            }

            conn.Close();
            return ds;
        }

        public void SuaThongTinTheLoai(TheLoaiDTO ThLSua)
        {
            conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update TheLoai set TenTheLoai=@ten, GhiChu=@ghichu where MaTheLoai=@ma";
            command.Connection = conn;

            command.Parameters.AddWithValue("@ma", ThLSua.MaTL);
            command.Parameters.AddWithValue("@ten", ThLSua.TenTL);
            command.Parameters.AddWithValue("@ghichu", ThLSua.GhiChu);

            int ret = command.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteTheLoai(string ma)
        {
            conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from TheLoai where MaTheLoai=@ma";
            command.Connection = conn;

            command.Parameters.AddWithValue("@ma", ma);

            int ret = command.ExecuteNonQuery();
            conn.Close();
        }



        public List<TheLoaiDTO> getTheLoai()
        {
            con.Open();
            List<TheLoaiDTO> dsTheLoai = new List<TheLoaiDTO>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TheLoai", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read() == true)
            {
                TheLoaiDTO item = new TheLoaiDTO(read["MaTheLoai"].ToString(), read["TenTheLoai"].ToString(), read["GhiChu"].ToString());
                dsTheLoai.Add(item);
            }
            con.Close();
            return dsTheLoai;
        }
        public DataTable getTenTheLoai()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable("TenTheLoai");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaTheLoai , TenTheLoai  FROM TheLoai";
            command.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            return dt;
        }
    }
}
