using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTOs;
namespace DALs
{
    public class DocGiaDAL:Connect
    {
        public DataTable getDocGia()
        {
            con.Open();
            List<DocGiaDTO> dsDocGia = new List<DocGiaDTO>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public string getTDG(string ma)
        {
            string key = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DocGia WHERE MaDocGia=@ma COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                key = read["HoTen"].ToString();
                return key;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return key;
        }
    }
}
