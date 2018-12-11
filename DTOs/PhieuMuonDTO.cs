using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhieuMuonDTO
    {
        /*
        private string maphieumuon;
        private string madocgia;
        private string ngaymuon;
        private string manhanvien;
        */

        public string MaPhieuMuon { get ; set ; }
        public string MaDocGia { get ; set ; }
        public DateTime NgayMuon { get ; set ; }
        public string MaNhanVien { get ; set ; }
        public PhieuMuonDTO() { }
        public PhieuMuonDTO(string maphieumuon, string madocgia, DateTime ngaymuon, string manhanvien)
        {
            this.MaPhieuMuon = maphieumuon;
            this.MaDocGia = madocgia;
            this.NgayMuon = ngaymuon;
            this.MaNhanVien = manhanvien;
        }
    }
}
