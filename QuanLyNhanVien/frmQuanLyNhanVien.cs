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
using DTOs;
using DALs;
using BULs;
namespace QuanLyThuVien
{
    public partial class frmQuanLyNhanVien : Form
    {
        string act = "";
        
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        NhanVienBUL myNhanVienBUL = new NhanVienBUL();
        int index;
        private string MaTuTang()
        {
            string s = "";
            DateTime time = DateTime.Now;
            string ngay = time.ToString("dd");
            string thang = time.ToString("MM");
            string nam = time.ToString("yy");
            string date = ngay + thang + nam;
            List<NhanVienDTO> ds = myNhanVienBUL.LayThongTinNhanVien();
            if (ds.Count <= 0)
            {
                s = "NV_" + date + "_001";
            }
            else
            {
                string newstt = "";
                int k = ds.Count;
                int stt = Convert.ToInt32(ds[k - 1].MaNhanVien.ToString().Substring(10, 3));
                string checkday = ds[k - 1].MaNhanVien.ToString().Substring(3, 6);
                if (date == checkday)
                {
                    int tempstt = stt + 1;
                    if (tempstt <= 9) newstt = "00" + tempstt.ToString();
                    if (tempstt >= 10 && tempstt < 100) newstt = "0" + tempstt.ToString();
                    if (tempstt == 100) newstt = "100";
                    s = "NV_" + date + "_" + newstt;
                }
                else
                {
                    s = "NV_" + date + "_001";
                }

            }
            return s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieu();
            index = -1;
        }
        void HienThiDuLieu()
        {
            dgvNhanVien.DataSource = myNhanVienBUL.LayThongTinNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[2].Width = 110;
            dgvNhanVien.Columns[3].HeaderText = "Tài Khoản";
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns[4].Width = 125;
            dgvNhanVien.Columns[5].HeaderText = "Quyền";
            dgvNhanVien.Columns[5].Width = 115;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if ("them" != act)
            {
                index = -1;
                HienThiDuLieu();
                grpThongTin.Enabled = true;
                pnInFor.Visible = true;
                pnInFor.Enabled = true;
                txtMaNV.Enabled = false;
                txtChucVu.Clear();
                txtTaiKhoan.Clear();
                txtTenNV.Clear();
                cboQuyen.Text = "";
                txtMatKhau.Clear();
                txtMaNV.Text = MaTuTang();
                act = "them";
                return;
            }


            NhanVienDTO aNV = new NhanVienDTO(txtMaNV.Text, txtTenNV.Text, txtChucVu.Text, txtTaiKhoan.Text, txtMatKhau.Text, cboQuyen.Text);
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                myNhanVienBUL.ThemMotNhanVien(aNV);
            }
            if(result == DialogResult.No)
            {
                XoaDuLieu();
            }
            HienThiDuLieu();
            XoaDuLieu();
            txtMaNV.Text = MaTuTang();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ("sua" != act)
            {
                HienThiDuLieu();
                grpThongTin.Enabled = true;
                pnInFor.Visible = true;
                pnInFor.Enabled = true;
                txtMaNV.Enabled = false;
                txtMaNV.Clear();
                txtChucVu.Clear();
                txtTaiKhoan.Clear();
                txtTenNV.Clear();
                cboQuyen.Text = "";
                txtMatKhau.Clear();
                act = "sua";
                return;
            }

            NhanVienDTO aNV = new NhanVienDTO(txtMaNV.Text, txtTenNV.Text, txtChucVu.Text, txtTaiKhoan.Text, txtMatKhau.Text, cboQuyen.Text);
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myNhanVienBUL.SuaThongTinSanPham(aNV);
            }
            if (result == DialogResult.No)
            {
                XoaDuLieu();
            }
            HienThiDuLieu();
            XoaDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ("xoa" != act)
            {
                HienThiDuLieu();
                grpThongTin.Enabled = true;
                pnInFor.Visible = true;
                pnInFor.Enabled = false;
                txtMaNV.Enabled = true;
                txtMaNV.Clear();
                txtChucVu.Clear();
                txtTaiKhoan.Clear();
                txtTenNV.Clear();
                cboQuyen.Text = "";
                txtMatKhau.Clear();
                act = "xoa";
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myNhanVienBUL.XoaNhanVien(txtMaNV.Text);
            }
            if (result == DialogResult.No)
            {
                XoaDuLieu();
            }
            HienThiDuLieu();
            XoaDuLieu();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if ("tim" != act)
            {
                grpThongTin.Enabled = true;
                pnInFor.Visible = false;
                txtMaNV.Enabled = true;
                txtMaNV.Clear();
                txtMaNV.Focus();

                act = "tim";
                return;
            }

            dgvNhanVien.DataSource = myNhanVienBUL.TimNhanVienTheoMa(txtMaNV.Text);
            
        }
        private void XoaDuLieu()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtChucVu.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboQuyen.Text = "";

        }
       
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            List<NhanVienDTO> ds = myNhanVienBUL.TimNhanVienTheoMa(txtMaNV.Text);
            foreach (NhanVienDTO anv in ds)
            {
                txtTenNV.Text = anv.HoTen;
                txtChucVu.Text = anv.ChucVu;
                txtTaiKhoan.Text = anv.TaiKhoan;
                txtMatKhau.Text = anv.MatKhau;
                cboQuyen.Text = anv.Quyen;

            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            txtTaiKhoan.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            cboQuyen.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
        }

        private void pnInFor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
