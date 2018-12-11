using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SoLuotMuonTheoTheLoaiDTO
    {
        public string STT { get; set; }
        public string TenTheLoai { get; set; }
        public string SoLuotMuon { get; set; }
        public string GhiChu { get; set; }
        public SoLuotMuonTheoTheLoaiDTO() { }
        public SoLuotMuonTheoTheLoaiDTO(string stt,string ten,string luotmuon,string gc)
        {
            this.STT = stt;
            this.TenTheLoai = ten;
            this.SoLuotMuon = luotmuon;
            this.GhiChu = gc;
        }
    }
}
