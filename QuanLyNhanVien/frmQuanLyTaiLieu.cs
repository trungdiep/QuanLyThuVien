using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using DALs;
using BULs;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmQuanLyTaiLieu : Form
    {
        string act = "";

        public frmQuanLyTaiLieu()
        {
            InitializeComponent();
        }
        TaiLieuBUL myTaiLieuBUL = new TaiLieuBUL();
        TheLoaiDAL myTheLoaiDAL = new TheLoaiDAL();
        private string MaTuTang()
        {
            string s = "";
            DateTime time = DateTime.Now;
            string ngay = time.ToString("dd");
            string thang = time.ToString("MM");
            string nam = time.ToString("yy");
            string date = ngay + thang + nam;
            List<TaiLieuDTO> ds = myTaiLieuBUL.LayDanhSachTaiLieu();
            if (ds.Count <= 0)
            {
                s = "TL_" + date + "_001";
            }
            else
            {
                string newstt = "";
                int k = ds.Count;
                int stt = Convert.ToInt32(ds[k - 1].MaTaiLieu.ToString().Substring(10, 3));
                string checkday = ds[k - 1].MaTaiLieu.ToString().Substring(3, 6);
                if (date == checkday)
                {
                    int tempstt = stt + 1;
                    if (tempstt <= 9) newstt = "00" + tempstt.ToString();
                    if (tempstt >= 10 && tempstt < 100) newstt = "0" + tempstt.ToString();
                    if (tempstt == 100) newstt = "100";
                    s = "TL_" + date + "_" + newstt;
                }
                else
                {
                    s = "TL_" + date + "_001";
                }

            }
            return s;
        }
        void HienThiDuLieu()
        {
            dgvTaiLieu.DataSource = myTaiLieuBUL.LayDanhSachTaiLieu();
            dgvTaiLieu.Columns[0].HeaderText = "Mã Tài Liệu";
            dgvTaiLieu.Columns[0].Width = 132;
            dgvTaiLieu.Columns[1].HeaderText = "Tên Tài Liệu";
            dgvTaiLieu.Columns[1].Width = 120;
            dgvTaiLieu.Columns[2].HeaderText = "Mã Thể Loại";
            dgvTaiLieu.Columns[2].Width = 120;
            dgvTaiLieu.Columns[3].HeaderText = "Số Lượng";
            dgvTaiLieu.Columns[3].Width = 100;
            dgvTaiLieu.Columns[4].HeaderText = "Nhà Xuất Bản";
            dgvTaiLieu.Columns[4].Width = 120;
            dgvTaiLieu.Columns[5].HeaderText = "Năm Xuất Bản";
            dgvTaiLieu.Columns[5].Width = 130;
            dgvTaiLieu.Columns[6].HeaderText = "Tác Giả";
            dgvTaiLieu.Columns[6].Width = 150;
        }

        private void frmTaiLieu_Load(object sender, EventArgs e)
        {

            cboTheLoai.DataSource = myTheLoaiDAL.getTenTheLoai();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
            HienThiDuLieu();
            XoaDuLieu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //dectect current action

            if ("them" != act)
            {
                //HienThiDuLieu();
                pnInFor.Visible = true;
                pnInFor.Enabled = true;
                txtMaTaiLieu.Enabled = false;
                XoaDuLieu();
                txtMaTaiLieu.Enabled = false;
                txtMaTaiLieu.Text = MaTuTang();
                act = "them";
                return;
            }

            TaiLieuDTO aTL = new TaiLieuDTO(txtMaTaiLieu.Text, txtTenTL.Text, cboTheLoai.Text, int.Parse(txtSoLuong.Text), txtNXB.Text, int.Parse(txtNamXB.Text), txtTacGia.Text);
            txtMaTaiLieu.Text = MaTuTang();
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTaiLieuBUL.ThemMotTaiLieu(aTL);
            }
            if (result == DialogResult.No)
            {
                return;
            }
            HienThiDuLieu();
            XoaDuLieu();
            txtMaTaiLieu.Text = MaTuTang();
        }
       

        private void btnSua_Click(object sender, EventArgs e)
        {
            //action: sua
            //dectect current action
            if ("sua" != act)
            {
                HienThiDuLieu();
                grbInFor.Enabled = true;
                pnInFor.Visible = true;
                pnInFor.Enabled = true;
                XoaDuLieu();
                txtMaTaiLieu.Enabled = true;
                
                act = "sua";
                return;
            }

            TaiLieuDTO aTL = new TaiLieuDTO(txtMaTaiLieu.Text, txtTenTL.Text, cboTheLoai.Text, int.Parse(txtSoLuong.Text), txtNXB.Text, int.Parse(txtNamXB.Text), txtTacGia.Text);
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu lại thông tin ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTaiLieuBUL.SuaThongTinTaiLieu(aTL);
            }
            if (result == DialogResult.No)
            {
                return;
            }
            HienThiDuLieu();
            XoaDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if ("xoa" != act)
            {
                frmTaiLieu_Load(null, null);
                grbInFor.Enabled = true;
                pnInFor.Visible = true;
                txtMaTaiLieu.Enabled = true;
                pnInFor.Enabled = false;
                act = "xoa";
                return;
            }
            txtMaTaiLieu.ReadOnly = true;
            txtTenTL.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtNXB.ReadOnly = true;
            txtNamXB.ReadOnly = true;
            txtTacGia.ReadOnly = true;
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa tài liệu ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTaiLieuBUL.XoaTaiLieu(txtMaTaiLieu.Text);
            }
            if (result == DialogResult.No)
            {
                return;
            }
            HienThiDuLieu();
            XoaDuLieu();
        }

        private void btnTìm_Click(object sender, EventArgs e)
        {
            //action: tim

            if ("tim" != act)
            {
                act = "tim";
                pnInFor.Visible = false;
                grbInFor.Enabled = true;
                txtMaTaiLieu.Enabled = true;
                txtMaTaiLieu.Focus();
                txtMaTaiLieu.Clear();
                return;
            }


            dgvTaiLieu.DataSource = myTaiLieuBUL.TimTaiLieu(txtMaTaiLieu.Text);
        }


        private void XoaDuLieu()
        {
            txtMaTaiLieu.Text = "";
            txtTenTL.Text = "";
            cboTheLoai.Text = "";
            txtSoLuong.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtTacGia.Text = "";
        }

        private void txtMaTL_TextChanged(object sender, EventArgs e)
        {
            List<TaiLieuDTO> ds =  myTaiLieuBUL.TimTaiLieu(txtMaTaiLieu.Text);
            foreach(TaiLieuDTO atl in ds)
            {
                txtTenTL.Text = atl.TenTaiLieu;
                cboTheLoai.Text = atl.MaTheLoai;
                txtSoLuong.Text = atl.SoLuong.ToString();
                txtNXB.Text = atl.NhaXuatBan;
                txtNamXB.Text = atl.NamXuatBan.ToString();
                txtTacGia.Text = atl.TacGia;
            }
        }

        private void dgvTaiLieu_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvTaiLieu.CurrentRow.Index;
            txtMaTaiLieu.Text = dgvTaiLieu.Rows[index].Cells[0].Value.ToString();
            txtTenTL.Text = dgvTaiLieu.Rows[index].Cells[1].Value.ToString();
            cboTheLoai.Text = dgvTaiLieu.Rows[index].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvTaiLieu.Rows[index].Cells[3].Value.ToString();
            txtNXB.Text = dgvTaiLieu.Rows[index].Cells[4].Value.ToString();
            txtNamXB.Text = dgvTaiLieu.Rows[index].Cells[5].Value.ToString();
            txtTacGia.Text = dgvTaiLieu.Rows[index].Cells[6].Value.ToString();
        }


    }
}
