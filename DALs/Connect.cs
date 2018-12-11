using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DALs
{
    public class Connect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=admin\SQLEXPRESS;Initial Catalog=QuanLyThuVienBTL;Integrated Security=True");
    }
}
