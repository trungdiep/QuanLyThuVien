using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhieuMuonChiTietDTO
    {
        /*
        private string maphieumuon;
        private string matailieu;
        private int soluongmuon;
        private string ngaytra;
        */

        public string MaPhieuMuon { get ; set ; }
        public string MaTaiLieu { get ; set ; }
        public int SoLuongMuon { get ; set ; }
        public DateTime NgayTra { get ; set ; }
        public PhieuMuonChiTietDTO(string v) { }
        public PhieuMuonChiTietDTO(string maphieumuon, string matailieu, int soluongmuon, DateTime ngaytra)
        {
            this.MaPhieuMuon = maphieumuon;
            this.MaTaiLieu = matailieu;
            this.SoLuongMuon = soluongmuon;
            this.NgayTra = ngaytra;
        }
    }
}
