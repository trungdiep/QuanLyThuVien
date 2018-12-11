using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NhanVienDTO
    {

    
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
        public NhanVienDTO() { }
        public NhanVienDTO(string ma, string ten, string chucvu, string taikhoan, string matkhau, string quyen)
        {
            this.MaNhanVien = ma;
            this.HoTen = ten;
            this.ChucVu = chucvu;
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
            this.Quyen = quyen;
        }
    }
}
