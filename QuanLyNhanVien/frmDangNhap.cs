using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALs;
namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string getID = "";
        NhanVienDAL myNhanVienDAL = new NhanVienDAL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            getID = myNhanVienDAL.getDangNhap(txtTaiKhoan.Text,txtMatKhau.Text);
            if (getID == "")
            {
                MessageBox.Show("Sai tài khoản or mật khẩu.","Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            if (getID != "")
            {
                string[] arr = getID.Split('-');
                if (arr[1] == "Thủ Thư")
                {

                    this.Hide();
                    frmThuThu frm = new frmThuThu();
                    frm.lblThuThu_frmAdmin.Text = arr[0];
                    frm.ShowDialog();
                    this.Show();
                }
                if (arr[1] == "Admin")
                {
                    //MessageBox.Show("admin thành công");
                    this.Hide();
                    frmAdmin frm = new frmAdmin();
                    frm.lblAdmin_frmAdmin.Text = arr[0];
                    frm.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
