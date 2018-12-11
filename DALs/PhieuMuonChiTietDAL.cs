using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTOs;
using System.Data.SqlTypes;

namespace DALs
{
    public class PhieuMuonChiTietDAL:Connect
    {
        public DataTable getPhieuMuonChiTiet()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuonChiTiet", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public bool them(PhieuMuonChiTietDTO item)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PhieuMuonChiTiet VALUES(@maphieu, @matl, @sl, @ngaytra)",con);
                cmd.Parameters.AddWithValue("maphieu", item.MaPhieuMuon);
                cmd.Parameters.AddWithValue("matl", item.MaTaiLieu);
                cmd.Parameters.AddWithValue("sl", item.SoLuongMuon);
                cmd.Parameters.AddWithValue("ngaytra", SqlDateTime.Null);
                if (cmd.ExecuteNonQuery() > 0) return true;
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
        public DataTable getthongtin_tra(string ma)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PhieuMuonChiTiet.MaPhieuMuon, TaiLieu.MaTaiLieu, TaiLieu.TenTaiLieu, PhieuMuonChiTiet.SoLuongMuon, PhieuMuon.NgayMuon, PhieuMuonChiTiet.NgayTra, NhanVien.HoTen " +
                " FROM PhieuMuonChiTiet , PhieuMuon , TaiLieu , NhanVien  WHERE PhieuMuonChiTiet.MaPhieuMuon = PhieuMuon.MaPhieuMuon AND" +
                " TaiLieu.MaTaiLieu = PhieuMuonChiTiet.MaTaiLieu AND NhanVien.MaNhanVien = PhieuMuon.MaNhanVien AND PhieuMuon.MaDocGia=@ma", con);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public DataTable getthongtin_tra_chuatra(string ma)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PhieuMuonChiTiet.MaPhieuMuon, TaiLieu.MaTaiLieu, TaiLieu.TenTaiLieu, PhieuMuonChiTiet.SoLuongMuon, PhieuMuon.NgayMuon, PhieuMuonChiTiet.NgayTra, NhanVien.HoTen " +
                " FROM PhieuMuonChiTiet , PhieuMuon , TaiLieu , NhanVien  WHERE PhieuMuonChiTiet.MaPhieuMuon = PhieuMuon.MaPhieuMuon AND" +
                " TaiLieu.MaTaiLieu = PhieuMuonChiTiet.MaTaiLieu AND NhanVien.MaNhanVien = PhieuMuon.MaNhanVien AND PhieuMuon.MaDocGia=@ma AND PhieuMuonChiTiet.NgayTra IS NULL", con);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        /*
        public DataTable getthongtin_tra_datra(string ma, DateTime ngaytra)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PhieuMuonChiTiet.MaPhieuMuon, TaiLieu.MaTaiLieu, TaiLieu.TenTaiLieu, PhieuMuonChiTiet.SoLuongMuon, PhieuMuon.NgayMuon, PhieuMuonChiTiet.NgayTra, NhanVien.HoTen " +
                " FROM PhieuMuonChiTiet , PhieuMuon , TaiLieu , NhanVien  WHERE PhieuMuonChiTiet.MaPhieuMuon = PhieuMuon.MaPhieuMuon AND" +
                " TaiLieu.MaTaiLieu = PhieuMuonChiTiet.MaTaiLieu AND NhanVien.MaNhanVien = PhieuMuon.MaNhanVien AND PhieuMuon.MaDocGia=@ma AND PhieuMuonChiTiet.NgayTra=@ngaytra", con);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ngaytra", ngaytra);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        */
        public bool up_ngaytra(string mapm,string matl, DateTime ngaytra)
        {
            try
            {
                con.Open();
                string sql = "UPDATE PhieuMuonChiTiet SET NgayTra=@ngtr WHERE MaPhieuMuon=@mapm AND MaTaiLieu=@matl";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("ngtr", ngaytra);
                cmd.Parameters.AddWithValue("mapm", mapm);
                cmd.Parameters.AddWithValue("matl", matl);
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
