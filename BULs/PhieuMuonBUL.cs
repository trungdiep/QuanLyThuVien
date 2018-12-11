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
    public class PhieuMuonBUL
    {
        PhieuMuonDAL myPhieuMuonDAL = new PhieuMuonDAL();
        public DataTable getPhieuMuon()
        {
            return myPhieuMuonDAL.getPhieuMuon();
        }
        public bool them(PhieuMuonDTO item)
        {
            return myPhieuMuonDAL.them(item);
        }
    }
}
