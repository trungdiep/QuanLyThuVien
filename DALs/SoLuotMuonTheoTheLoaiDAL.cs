using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data.SqlClient;
using System.Data;
namespace DALs
{
    public class SoLuotMuonTheoTheLoaiDAL
    {
        
        SqlConnection conn = new SqlConnection();
        string connstring = @"Data Source=admin\SQLEXPRESS;Initial Catalog=QuanLyThuVienBTL;Integrated Security=True";
        public List<SoLuotMuonTheoTheLoaiDTO> ThongKe()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            List<SoLuotMuonTheoTheLoaiDTO> ds = new List<SoLuotMuonTheoTheLoaiDTO>();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select  TenTheLoai, COUNT(*) , thl.GhiChu FROM PhieuMuonChiTiet phm,PhieuMuon pm, TheLoai thl, TaiLieu tl where  " +
                "thl.MaTheLoai=tl.MaTheLoai and tl.MaTaiLieu =  phm.MaTaiLieu and phm.MaPhieuMuon = pm.MaPhieuMuon " +
                "group by thl.TenTheLoai,thl.GhiChu";
            command.Connection = conn;

            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //return dt;
            SqlDataReader dr = command.ExecuteReader();
            int i = 1;
            while (dr.Read())
            {
                SoLuotMuonTheoTheLoaiDTO aTK = new SoLuotMuonTheoTheLoaiDTO(i.ToString(), dr["TenTheLoai"].ToString(), dr[1].ToString(), dr["GhiChu"].ToString());
                i++;
                ds.Add(aTK);
            }
            conn.Close();
            return ds;

        }
        public  List<SoLuotMuonTheoTheLoaiDTO>  ThongKeTheoNgay(string date1, string date2)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            List<SoLuotMuonTheoTheLoaiDTO> ds = new List<SoLuotMuonTheoTheLoaiDTO>();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select  TenTheLoai, COUNT(*) , thl.GhiChu FROM PhieuMuonChiTiet phm,PhieuMuon pm, TheLoai thl, TaiLieu tl where  " +
                "thl.MaTheLoai=tl.MaTheLoai and tl.MaTaiLieu =  phm.MaTaiLieu and phm.MaPhieuMuon = pm.MaPhieuMuon and NgayMuon BETWEEN " + date1 + " and " + date2 +
                "group by thl.TenTheLoai,thl.GhiChu";
            command.Connection = conn;
            Console.WriteLine(command.CommandText);
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //return dt;
            SqlDataReader dr = command.ExecuteReader();
            int i = 1;
            while (dr.Read())
            {
                SoLuotMuonTheoTheLoaiDTO soLuotMuonTheo
                    = new SoLuotMuonTheoTheLoaiDTO(i.ToString(), dr["TenTheLoai"].ToString(), dr[1].ToString(), dr["GhiChu"].ToString());
                i++;
                ds.Add(soLuotMuonTheo);
            }
            dr.Close();
            conn.Close();
            return ds;
           
        }
    } 
}
