using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALs;
using DTOs;

namespace BULs
{
    public class PhieuMuonChiTietBUL
    {
        PhieuMuonChiTietDAL myPhieuMuonChiTietDAL = new PhieuMuonChiTietDAL();
        public DataTable getPhieuMuonChiTiet()
        {
            return myPhieuMuonChiTietDAL.getPhieuMuonChiTiet();
        }
        public bool them(PhieuMuonChiTietDTO item)
        {
            return myPhieuMuonChiTietDAL.them(item);
        }
        public DataTable getthongtin_tra(string ma)
        {
            return myPhieuMuonChiTietDAL.getthongtin_tra(ma);
        }
        public bool up_ngaytra(string mapm,string matl, DateTime ngaytra)
        {
            return myPhieuMuonChiTietDAL.up_ngaytra(mapm, matl, ngaytra);
        }
        
        public DataTable getthongtin_tra_chuatra(string ma)
        {
            return myPhieuMuonChiTietDAL.getthongtin_tra_chuatra(ma);
        }
        /*
        public DataTable getthongtin_tra_datra(string ma, DateTime ngaytra)
        {
            return myPhieuMuonChiTietDAL.getthongtin_tra_datra(ma, ngaytra);
        }*/
        
    }
}
