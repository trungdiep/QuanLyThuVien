using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
namespace BULs
{
    public class TheLoaiBUL
    {
        TheLoaiDAL myTheLoaiDAL = new TheLoaiDAL();
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            return myTheLoaiDAL.LayDanhSachTheLoai();
        }

        public void ThemMotTheLoai(TheLoaiDTO ThLM)
        {
            myTheLoaiDAL.AddTheLoai(ThLM);
        }

        public List<TheLoaiDTO> TimTheLoai(string ma)
        {
            return myTheLoaiDAL.FindTaiLieu(ma);
        }

        public void SuaTheLoai(TheLoaiDTO ThLSua)
        {
            myTheLoaiDAL.SuaThongTinTheLoai(ThLSua);
        }

        public void XoaTheLoai(string ma)
        {
            myTheLoaiDAL.DeleteTheLoai(ma);
        }


        public List<TheLoaiDTO> getTheLoai()
        {
            return myTheLoaiDAL.getTheLoai();
        }
    }
}
