using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using System.Data;
using DTOs;
namespace BULs
{
    public class SoLuotMuonTheoTheLoaiBUL
    {
        SoLuotMuonTheoTheLoaiDAL MymuonTheoTheLoaiBUL = new SoLuotMuonTheoTheLoaiDAL();
        public List<SoLuotMuonTheoTheLoaiDTO> ThongKe()
        {
            return MymuonTheoTheLoaiBUL.ThongKe();
        }
        public List<SoLuotMuonTheoTheLoaiDTO> ThongKeTheoNgay(string date1, string date2)
        {
            return MymuonTheoTheLoaiBUL.ThongKeTheoNgay(date1, date2);
        }
    }
}
