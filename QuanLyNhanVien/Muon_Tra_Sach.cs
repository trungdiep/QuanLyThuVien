using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BULs;
using DTOs;
using System.Data.SqlTypes;
using QuanLyThuVien;

namespace QuanLyThuVien
{
    public partial class Muon_Tra_Sach : Form
    {
        TheLoaiBUL myTheLoaiBUL = new TheLoaiBUL();
        TaiLieuBUL myTaiLieuBUL = new TaiLieuBUL();
        NhanVienBUL myNhanVienBUL = new NhanVienBUL();
        DocGiaBUL myDocGiaBUL = new DocGiaBUL();
        PhieuMuonBUL myPhieuMuonBUL = new PhieuMuonBUL();
        PhieuMuonChiTietBUL myPhieuMuonChiTietBUL = new PhieuMuonChiTietBUL();
        public Muon_Tra_Sach()
        {
            InitializeComponent();
        }
        /////////////
        public string maTuTang()
        {

            DateTime time = DateTime.Now;
            string day = time.ToString("dd");
            string month = time.ToString("MM");
            string year = time.ToString("yy");
            string date = day + month + year;
            string s = "";
            DataTable ls = new DataTable();
            ls = myPhieuMuonBUL.getPhieuMuon();
            if (ls.Rows.Count <= 0)
            {
                s = "PM_" + date + "_001";
            }
            else
            {
                string newstt = "";
                int k = ls.Rows.Count;
                int stt = Convert.ToInt32(ls.Rows[k - 1].ItemArray[0].ToString().Substring(10, 3));
                string checkday = ls.Rows[k - 1].ItemArray[0].ToString().Substring(3, 6);
                if (date == checkday)
                {
                    int tempstt = stt + 1;
                    if (tempstt <= 9) newstt = "00" + tempstt.ToString();
                    if (tempstt >= 10 && tempstt <= 99) newstt = "0" + tempstt.ToString();
                    if (tempstt >= 100) newstt = tempstt.ToString();
                    s = "PM_" + date + "_" + newstt;
                }
                else
                {
                    s = "PM_" + date + "_001";
                }
            }
            return s;
        }
        public string ngayMuon()
        {
            string s = "";
            DateTime time = DateTime.Now;
            s = time.ToString("dd-MM-yyyy");
            return s;
        }
        public string dao_ngaymuon()
        {
            string s = "";
            string s1 = "";
            DateTime time = DateTime.Now;
            s = time.ToString("dd-MM-yyyy");
            s1 = s.Substring(6, 4) + "-" + s.Substring(3, 2) + "-" + s.Substring(0, 2);
            return s1;
        }

        string laymanv;
        public string Message
        {
            get { return laymanv; }
            set { laymanv = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            texMaPhieuMuon.Text = maTuTang();
            texNgayMuon.Text = ngayMuon();


            ////////////////////
            /////////
            frmThuThu fthuthu = new frmThuThu();

            texMaNhanVien.Text = laymanv;
            texTenNhanVien.Text = myNhanVienBUL.get_tennv(texMaNhanVien.Text.ToString());
            /////////
            ////////////////////


            cboxTenTaiLieu.DataSource = myTaiLieuBUL.getTaiLieu();
            cboxTenTaiLieu.DisplayMember = "TenTaiLieu";
            cboxTenTaiLieu.ValueMember = "MaTaiLieu";
            texMaTaiLieu.Text = "";
            cboxTenTaiLieu.SelectedIndex = -1;
            butDK.Enabled = false;
            butLuu.Enabled = false;
            butHuy.Enabled = false;
            groupBoxTimTaiLieu.Enabled = false;
            listview1.Enabled = false;
            dgv.Enabled = false;
            texMaDocGia.Select();

        }
        public void clear()
        {
            cboxTenTaiLieu.SelectedIndex = -1;
            texMaTaiLieu.Clear();
            texSoLuongCon.Clear();
            cboxSoLuongMuon.SelectedIndex = -1;
            groupBoxTimTaiLieu.Enabled = false;
            butDK.Enabled = false;
            butLuu.Enabled = false;
            butHuy.Enabled = false;
            listview1.Items.Clear();
            listview1.Enabled = false;
            texMaDocGia.Clear();
            texTenDocGia.Clear();
        }
        private void cboxTenTaiLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTenTaiLieu.SelectedIndex != -1)
                {

                    bool check = true;
                    for (int i = 0; i < listview1.Items.Count; i++)
                    {
                        if (cboxTenTaiLieu.Text == listview1.Items[i].SubItems[1].Text.ToString())
                        {
                            check = false;
                        }
                    }
                    if (check == true)
                    {
                        texMaTaiLieu.Enabled = true;
                        texMaTaiLieu.Clear();
                        texSoLuongCon.Enabled = true;
                        texSoLuongCon.Clear();
                        cboxSoLuongMuon.Enabled = true;
                        cboxSoLuongMuon.SelectedIndex = -1;
                        butDK.Enabled = true;


                        texMaTaiLieu.Text = cboxTenTaiLieu.SelectedValue.ToString();
                        texSoLuongCon.Text = myTaiLieuBUL.getthongtinSLTL(cboxTenTaiLieu.SelectedValue.ToString());


                        if (Convert.ToInt32(texSoLuongCon.Text) == 0)
                        {
                            cboxSoLuongMuon.SelectedIndex = -1;
                            cboxSoLuongMuon.Enabled = false;
                            butDK.Enabled = false;
                        }
                        else
                        {
                            int sl = Convert.ToInt32(texSoLuongCon.Text.ToString());
                            List<int> lsl = new List<int>();
                            if (sl == 1) lsl.Add(1);
                            else
                            {
                                if (sl >= 2)
                                {
                                    lsl.Add(1);
                                    lsl.Add(2);
                                }
                            }
                            cboxSoLuongMuon.DataSource = lsl;
                        }

                    }
                    else
                    {
                        texMaTaiLieu.Clear();
                        texMaTaiLieu.Enabled = false;
                        texSoLuongCon.Clear();
                        texSoLuongCon.Enabled = false;
                        cboxSoLuongMuon.SelectedIndex = -1;
                        cboxSoLuongMuon.Enabled = false;
                        butDK.Enabled = false;
                    }
                }
                else
                {
                    texMaTaiLieu.Clear();
                    texMaTaiLieu.Enabled = false;
                    texSoLuongCon.Clear();
                    texSoLuongCon.Enabled = false;
                    cboxSoLuongMuon.SelectedIndex = -1;
                    cboxSoLuongMuon.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void texMaDocGia_TextChanged(object sender, EventArgs e)
        {
            texTenDocGia.Clear();
            if (texMaDocGia.Text.ToString().Length == 13)
            {
                texTenDocGia.Text = myDocGiaBUL.getTDG(texMaDocGia.Text.ToString());
            }
            else
            {
                texTenDocGia.Clear();
                cboxTenTaiLieu.SelectedIndex = -1;
                texMaTaiLieu.Clear();
                texSoLuongCon.Clear();
                cboxSoLuongMuon.SelectedIndex = -1;
                butLuu.Enabled = false;
                butDK.Enabled = false;
                listview1.Items.Clear();
                listview1.Enabled = false;
            }
            if (texTenDocGia.Text.ToString().Length > 0)
            {
                groupBoxTimTaiLieu.Enabled = true;
            }
            else
                groupBoxTimTaiLieu.Enabled = false;
            if (texMaDocGia.Text.ToString().Length != 0)
                butHuy.Enabled = true;
            else butHuy.Enabled = false;
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
           
            PhieuMuonDTO i_pm = new PhieuMuonDTO(texMaPhieuMuon.Text.ToString(), texMaDocGia.Text.ToString(), Convert.ToDateTime(dao_ngaymuon()), texMaNhanVien.Text.ToString());
            myPhieuMuonBUL.them(i_pm);

            int lc = listview1.Items.Count;

            for (int i = 0; i < lc; i++)
            {
                PhieuMuonChiTietDTO i_pmct = new PhieuMuonChiTietDTO(texMaPhieuMuon.Text.ToString(), listview1.Items[i].SubItems[0].Text.ToString(), Convert.ToInt32(listview1.Items[i].SubItems[2].Text.ToString()), DateTime.Now);
                myPhieuMuonChiTietBUL.them(i_pmct);
                int sl_bd = Convert.ToInt32(myTaiLieuBUL.getthongtinSLTL(listview1.Items[i].SubItems[0].Text.ToString()));
                int sl_lay = Convert.ToInt32(listview1.Items[i].SubItems[2].Text.ToString());
                int sl_con = sl_bd - sl_lay;
                myTaiLieuBUL.up_sl(sl_con, listview1.Items[i].SubItems[0].Text.ToString());
            }
            MessageBox.Show("Mượn Tài Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            //////
            ///
            texMaPhieuMuon.Text = maTuTang();
            texNgayMuon.Text = ngayMuon();
            cboxTenTaiLieu.DataSource = myTaiLieuBUL.getTaiLieu();
            cboxTenTaiLieu.DisplayMember = "TenTaiLieu";
            cboxTenTaiLieu.ValueMember = "MaTaiLieu";
            texMaTaiLieu.Text = "";
            cboxTenTaiLieu.SelectedIndex = -1;
            texSoLuongCon.Clear();
            cboxSoLuongMuon.SelectedIndex = -1;
            butDK.Enabled = false;
            butLuu.Enabled = false;
            butHuy.Enabled = false;
            groupBoxTimTaiLieu.Enabled = false;
            listview1.Enabled = false;
            dgv.Enabled = false;
            texMaDocGia.Select();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            clear();
            texMaDocGia.Select();
        }

        private void texMaDocGia2_TextChanged(object sender, EventArgs e)
        {
            texTenDocGia2.Clear();
            if (texMaDocGia2.Text.ToString().Length == 13)
            {
                texTenDocGia2.Text = myDocGiaBUL.getTDG(texMaDocGia2.Text.ToString());
                if (texTenDocGia2.Text.ToString().Length > 0)
                {
                    dgv.Enabled = true;
                    butTraSach.Enabled = true;

                    string ma = texMaDocGia2.Text;
                    dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra(ma);

                    dgv.Columns["MaPhieuMuon"].Width = 140;
                    dgv.Columns["MaTaiLieu"].Width = 140;
                    dgv.Columns["TenTaiLieu"].Width = 160;
                    dgv.Columns["SoLuongMuon"].Width = 80;
                    dgv.Columns["NgayMuon"].Width = 120;
                    dgv.Columns["NgayTra"].Width = 120;
                    dgv.Columns["HoTen"].Width = 160;

                    dgv.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
                    dgv.Columns["MaTaiLieu"].HeaderText = "Mã Tài Liệu";
                    dgv.Columns["TenTaiLieu"].HeaderText = "Tên Tài Liệu";
                    dgv.Columns["SoLuongMuon"].HeaderText = "Số Lượng Mượn";
                    dgv.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dgv.Columns["NgayTra"].HeaderText = "Ngày Trả";
                    dgv.Columns["HoTen"].HeaderText = "Tên Nhân Viên";

                    cboxchon.Enabled = true;
                    cboxchon.SelectedIndex = 0;
                    dgv.ClearSelection();
                }
            }
            else
            {
                butTraSach.Enabled = false;
                cboxchon.SelectedIndex = -1;
                cboxchon.Enabled = false;
                dgv.DataSource = null;
            }
        }
        /// //////////////////////////

        private void butTraSach_Click(object sender, EventArgs e)
        {
            int countselect = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Selected == true)
                {
                    countselect++;
                }
            }
            if (countselect == 0)
            {
                MessageBox.Show("Bạn Chưa Chọn Tài Liệu Nào. Thực Hiện Lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = true;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Selected == true && dgv.Rows[i].Cells[5].Value.ToString().Length > 1)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (dgv.Rows[i].Selected == true)
                        {
                            int sl_bd = Convert.ToInt32(myTaiLieuBUL.getthongtinSLTL(dgv.Rows[i].Cells[1].Value.ToString()));
                            int sl_tra = Convert.ToInt32(dgv.Rows[i].Cells[3].Value.ToString());
                            int sl_sau = sl_bd + sl_tra;
                            myTaiLieuBUL.up_sl(sl_sau, dgv.Rows[i].Cells[1].Value.ToString());
                            myPhieuMuonChiTietBUL.up_ngaytra(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), Convert.ToDateTime(DateTime.Now));
                        }
                    }
                }
                if (check == false) MessageBox.Show("Bạn Chọn Sách Đã Trả Rồi. Thực Hiện Lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (check == true) MessageBox.Show("Thực Hiện Trả Sách Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String ma = texMaDocGia2.Text;
                if (cboxchon.SelectedIndex == 0)
                {
                    dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra(ma);
                }
                else
                {
                    if (cboxchon.SelectedIndex == 1)
                    {
                        dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra_chuatra(ma);

                    }
                }
                dgv.ClearSelection();
            }
        }
        
        private void butDK_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            arr[0] = texMaTaiLieu.Text;
            arr[1] = cboxTenTaiLieu.Text;
            arr[2] = cboxSoLuongMuon.Text;
            ListViewItem item = new ListViewItem(arr);
            listview1.Items.Add(item);


            butLuu.Enabled = true;
            butHuy.Enabled = true;
            butDK.Enabled = false;

            cboxTenTaiLieu.SelectedIndex = -1;
            texMaTaiLieu.Clear();
            texMaTaiLieu.Enabled = false;
            texSoLuongCon.Clear();
            texSoLuongCon.Enabled = false;
            cboxSoLuongMuon.SelectedIndex = -1;
            cboxSoLuongMuon.Enabled = false;

            if (listview1.Items.Count == 3)
            {
                groupBoxTimTaiLieu.Enabled = false;
            }
        }

        private void cboxchon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxchon.SelectedIndex == 0)
            {
                string ma = texMaDocGia2.Text;
                dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra(ma);
            }
            else
            {
                if (cboxchon.SelectedIndex == 1)
                {
                    string ma = texMaDocGia2.Text;
                    dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra_chuatra(ma);
                }
            }
            dgv.ClearSelection();
        }

       

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                texMaDocGia2.Select();
                if (texTenDocGia2.Text.ToString().Length > 0)
                {
                    dgv.Enabled = true;
                    butTraSach.Enabled = true;
                    cboxchon.Enabled = true;
                    string ma = texMaDocGia2.Text;
                    if(cboxchon.Text=="Tất Cả")
                    {
                        dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra(ma);
                    }
                    else
                    {
                        if(cboxchon.Text=="Chưa Trả")
                        {
                            dgv.DataSource = myPhieuMuonChiTietBUL.getthongtin_tra_chuatra(ma);
                        }
                    }
                    

                    dgv.Columns["MaPhieuMuon"].Width = 140;
                    dgv.Columns["MaTaiLieu"].Width = 140;
                    dgv.Columns["TenTaiLieu"].Width = 160;
                    dgv.Columns["SoLuongMuon"].Width = 80;
                    dgv.Columns["NgayMuon"].Width = 120;
                    dgv.Columns["NgayTra"].Width = 120;
                    dgv.Columns["HoTen"].Width = 160;

                    dgv.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
                    dgv.Columns["MaTaiLieu"].HeaderText = "Mã Tài Liệu";
                    dgv.Columns["TenTaiLieu"].HeaderText = "Tên Tài Liệu";
                    dgv.Columns["SoLuongMuon"].HeaderText = "Số Lượng Mượn";
                    dgv.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dgv.Columns["NgayTra"].HeaderText = "Ngày Trả";
                    dgv.Columns["HoTen"].HeaderText = "Tên Nhân Viên";

                    dgv.ClearSelection();
                }
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                texMaDocGia.Select();
            }
        }

    }
}
