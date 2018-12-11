using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALs;
namespace QuanLyThuVien
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        NhanVienDAL NhanVienDAL = new NhanVienDAL();
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }



        private void btnQLTheLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyTheLoai frmQuanLyNhanVien = new frmQuanLyTheLoai();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void btnQLTaiLieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyTaiLieu frmQuanLyNhanVien = new frmQuanLyTaiLieu();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Show();
        }

        public Label lblAdmin_frmAdmin
        {
            get
            {
                return lblAdmin;
            }
            set
            {
                lblAdmin = value;
            }
        }
    }
}
