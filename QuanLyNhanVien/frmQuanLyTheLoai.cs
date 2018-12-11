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

namespace QuanLyThuVien
{
    public partial class frmQuanLyTheLoai : Form
    {
        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }
        TheLoaiBUL myTheLoaiBUL = new TheLoaiBUL();
        string act = "";
        private string MaTuTang()
        {
            string s = "";
            DateTime time = DateTime.Now;
            string ngay = time.ToString("dd");
            string thang = time.ToString("MM");
            string nam = time.ToString("yy");
            string date = ngay + thang + nam;
            Console.WriteLine(date);
            List<TheLoaiDTO> ds = myTheLoaiBUL.LayDanhSachTheLoai();
            if (ds.Count <= 0)
            {
                s = "ThL_" + date + "_001";
            }
            else
            {
                string newstt = "";
                int k = ds.Count;
                int stt = Convert.ToInt32(ds[k - 1].MaTL.ToString().Substring(11));
                Console.WriteLine(stt);
                string checkday = ds[k - 1].MaTL.ToString().Substring(4, 6);
                Console.WriteLine(checkday);
                if (date == checkday)
                {
                    int tempstt = stt + 1;
                    if (tempstt <= 9) newstt = "00" + tempstt.ToString();
                    if (tempstt >= 10 && tempstt < 100) newstt = "0" + tempstt.ToString();
                    if (tempstt == 100) newstt = "100";
                    s = "ThL_" + date + "_" + newstt;
                }
                else
                {
                    s = "ThL_" + date + "_001";
                }
            }
            return s;
        }

        void viewDaTa()
        {
            dgvHienThiTheLoai.DataSource = myTheLoaiBUL.LayDanhSachTheLoai();
            dgvHienThiTheLoai.Columns[0].HeaderText = "Mã Thể Loại";
            dgvHienThiTheLoai.Columns[0].Width = 150;
            dgvHienThiTheLoai.Columns[1].HeaderText = "Tên Thể Loại";
            dgvHienThiTheLoai.Columns[1].Width = 150;
            dgvHienThiTheLoai.Columns[2].HeaderText = "Ghi Chú";
            dgvHienThiTheLoai.Columns[2].Width = 300;
        }

        void deleteData()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            txtGhiChu.Text = "";
        }

        private void frmQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            viewDaTa();
            deleteData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ("them" != act)
            {
                grbInFor.Enabled = true;
                pnInFor.Visible = true;
                txtMaTheLoai.Enabled = false;
                txtMaTheLoai.Text = MaTuTang();
                act = "them";
                return;
            }

            
            TheLoaiDTO aThL = new TheLoaiDTO
                (
                    txtMaTheLoai.Text,
                    txtTenTheLoai.Text,
                    txtGhiChu.Text
                );

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTheLoaiBUL.ThemMotTheLoai(aThL);
            }
            if (result == DialogResult.No)
            {
                return;
            }
            viewDaTa();
            deleteData();
            txtMaTheLoai.Text = MaTuTang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ("sua" != act)
            {
                grbInFor.Enabled = true;
                pnInFor.Visible = true;
                txtMaTheLoai.Enabled = false;
                act = "sua";
                return;
            }

            TheLoaiDTO aThL = new TheLoaiDTO
                (
                    txtMaTheLoai.Text,
                    txtTenTheLoai.Text,
                    txtGhiChu.Text
                );

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu lại thông tin ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTheLoaiBUL.SuaTheLoai(aThL);
            }
            if (result == DialogResult.No)
            {
                return;
            }

            viewDaTa();
            deleteData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if ("tim" != act)
            {
                act = "tim";
                pnInFor.Visible = false;
                grbInFor.Enabled = true;
                txtMaTheLoai.Enabled = true;
                txtMaTheLoai.Focus();
                return;
            }

            dgvHienThiTheLoai.DataSource = myTheLoaiBUL.TimTheLoai(txtMaTheLoai.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa thể loại đó ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                myTheLoaiBUL.XoaTheLoai(txtMaTheLoai.Text);
            }
            if (result == DialogResult.No)
            {
                txtMaTheLoai.Text = "";
                return;
            }
            viewDaTa();
            deleteData();
        }

        private void dgvHienThiTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvHienThiTheLoai.CurrentRow.Index;
            txtMaTheLoai.Text = dgvHienThiTheLoai.Rows[index].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvHienThiTheLoai.Rows[index].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvHienThiTheLoai.Rows[index].Cells[2].Value.ToString();
        }

        private void lblQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
