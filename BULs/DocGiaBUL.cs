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
    public class DocGiaBUL
    {
        DocGiaDAL myDocGiaDAL = new DocGiaDAL();
        public DataTable getDocGia()
        {
            return myDocGiaDAL.getDocGia();
        }
        public string getTDG(string ma)
        {
            return myDocGiaDAL.getTDG(ma);
        }
    }
}
