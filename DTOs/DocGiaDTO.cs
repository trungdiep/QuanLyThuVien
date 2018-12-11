using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DocGiaDTO
    {
        /*
        private string madocgia;
        private string hoten;
        private string gioitinh;
        private string ngaysinh;
        private string doituong;
        private string ngaycap;
        private string ngayhethan;
        */

        public string MaDocGia { get ; set ; }
        public string HoTen { get ; set ; }
        public string GioiTinh { get ; set ; }
        public string NgaySinh { get ; set ; }
        public string DoiTuong { get ; set ; }
        public string NgayCap { get ; set ; }
        public string NgayHetHan { get ; set ; }
        public DocGiaDTO() { }
        public DocGiaDTO(string madocgia, string hoten, string gioitinh, string ngaysinh, string doituong, string ngaycap, string ngayhethan)
        {
            this.MaDocGia = madocgia;
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.DoiTuong = doituong;
            this.NgayCap = ngaycap;
            this.NgayHetHan = ngayhethan;
        }
    }
}
