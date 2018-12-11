using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TaiLieuDTO
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public string MaTheLoai { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string TacGia { set; get; }
        public TaiLieuDTO ()
        {

        }
        public TaiLieuDTO(string ma,string ten,string matl,int sl,string nxb,int namxb,string tg)
        {
            this.MaTaiLieu = ma;
            this.TenTaiLieu = ten;
            this.MaTheLoai = matl;
            this.SoLuong = sl;
            this.NhaXuatBan = nxb;
            this.NamXuatBan = namxb;
            this.TacGia = tg;
        }

    }
}
