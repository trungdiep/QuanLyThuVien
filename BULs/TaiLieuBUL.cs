using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
namespace BULs
{
    public class TaiLieuBUL
    {
        TaiLieuDAL myTaiLieuDAL = new TaiLieuDAL();
        public List<TaiLieuDTO> LayDanhSachTaiLieu()
        {  
            return myTaiLieuDAL.LayDanhSachTaiLieu();
        }
        public void ThemMotTaiLieu(TaiLieuDTO TLMoi)
        {
            myTaiLieuDAL.ThemMotTaiLieu(TLMoi);
        }
        public void SuaThongTinTaiLieu(TaiLieuDTO TLSua)
        {
            myTaiLieuDAL.SuaThongTinTaiLieu(TLSua);
        }
        public void XoaTaiLieu(string ma)
        {
            myTaiLieuDAL.XoaMotTaiLieu(ma);
        }
        public List<TaiLieuDTO> TimTaiLieu(string ma)
        {
            return myTaiLieuDAL.TimTaiLieu(ma);
        }


        public List<TaiLieuDTO> getTaiLieu()
        {
            return myTaiLieuDAL.getTaiLieu();
        }
        public string getthongtinSLTL(string ma)
        {
            return myTaiLieuDAL.thongTinSLTL(ma);
        }
        public bool up_sl(int sl, string ma)
        {
            return myTaiLieuDAL.up_sl(sl, ma);
        }

    }
}
