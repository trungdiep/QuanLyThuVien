using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
namespace BULs
{
    public class NhanVienBUL
    {
        NhanVienDAL myNhanVienDAL = new NhanVienDAL();
        public List<NhanVienDTO> LayThongTinNhanVien()
        {
            return myNhanVienDAL.LayDanhSachNhanVien();
        }
        public void ThemMotNhanVien(NhanVienDTO aNV)
        {
            myNhanVienDAL.ThemNhanVien(aNV);
        }
        public void XoaNhanVien(string ma)
        {
            myNhanVienDAL.XoaNhanVien(ma);
        }
        public void SuaThongTinSanPham(NhanVienDTO aNV)
        {
            myNhanVienDAL.SuaNhanVien(aNV);
        }
        public List<NhanVienDTO> TimNhanVienTheoMa(string ma)
        {
            return myNhanVienDAL.TimNhanVien(ma);
        }


        public List<NhanVienDTO> getNhanVien()
        {
            return myNhanVienDAL.getNhanVien();
        }
        public string get_manv(string ma)
        {
            return myNhanVienDAL.get_manv(ma);
        }
        public string get_tennv(string ma)
        {
            return myNhanVienDAL.get_tennv(ma);
        }
    }
}
