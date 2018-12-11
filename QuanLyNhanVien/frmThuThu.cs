using QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmThuThu : Form
    {
        public frmThuThu()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }
        public Label lblThuThu_frmAdmin
        {
            get
            {
                return lblThuThu;
            }
            set
            {
                lblThuThu = value;
            }
        }


        ////////////////////
        /////////
        private void btnQLMuonTraSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Muon_Tra_Sach newmt = new Muon_Tra_Sach();
            newmt.Message = lblThuThu.Text;
            newmt.ShowDialog();
            this.Show();
        }

        private void frmThuThu_Load(object sender, EventArgs e)
        {

        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            grpThongKe.Visible = true;
        }

        private void btnThongKeSoLuotMuonTheoTheLoai_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSoLanMuonTheoTheLoai frm = new frmSoLanMuonTheoTheLoai();
            frm.ShowDialog();
            this.Show();

        }
    }
}
