using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TheLoaiDTO
    {
        private string _maTL;
        public string MaTL
        {
            get { return _maTL; }
            set { _maTL = value; }
        }

        private string _tenTL;
        public string TenTL
        {
            get { return _tenTL; }
            set { _tenTL = value; }
        }

        private string _ghiChu;
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public TheLoaiDTO()
        {

        }

        public TheLoaiDTO(string MaTheLoai, string TenTheLoai, string Ghichu)
        {
            this.MaTL = MaTheLoai;
            this.TenTL = TenTheLoai;
            this.GhiChu = Ghichu;
        }
    }
}
