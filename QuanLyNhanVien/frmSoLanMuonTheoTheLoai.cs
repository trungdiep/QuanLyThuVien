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
using DALs;
using DTOs;
using BULs;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using System.Globalization;
namespace QuanLyThuVien
{
    public partial class frmSoLanMuonTheoTheLoai : Form
    {
        public frmSoLanMuonTheoTheLoai()
        {
            InitializeComponent();
        }
        PrintDocument pd = new PrintDocument();
        SoLuotMuonTheoTheLoaiBUL ThongKe = new SoLuotMuonTheoTheLoaiBUL();

        private void frmSoLanMuonTheoTheLoai_Load(object sender, EventArgs e)
        {
            //Date1 = " '2018-11-02 '";
            //Date2 = "'" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "'";
            dgvThongKe.DataSource = ThongKe.ThongKe();
            dgvThongKe.Columns[0].HeaderText = "STT";
            dgvThongKe.Columns[0].Width = 100;
            dgvThongKe.Columns[1].HeaderText = "Tên tài liệu";
            dgvThongKe.Columns[1].Width = 200;
            dgvThongKe.Columns[2].HeaderText = "Số lượt mượn";
            dgvThongKe.Columns[2].Width = 154;
            dgvThongKe.Columns[3].HeaderText = "Ghi chú";
            dgvThongKe.Columns[3].Width = 400;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string Date1 = "'" + dtmStart.Value.Year.ToString() + "-" + dtmStart.Value.Month.ToString() + "-" + dtmStart.Value.Day.ToString() + "'";
            string Date2 = "'" + dtmEnd.Value.Year.ToString() + "-" + dtmEnd.Value.Month.ToString() + "-" + dtmEnd.Value.Day.ToString() + "'";
            dgvThongKe.DataSource = ThongKe.ThongKeTheoNgay(Date1, Date2);
        }


        Bitmap bitmap;
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();

                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                    
                }
            }
            catch (Exception)
            {

            }
        }

        private void _CreateReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12,FontStyle.Bold);
            float FontHeight = font.GetHeight();

            graphic.DrawString("THƯ VIỆN 3 TỜ", new Font("Courier New", 18,FontStyle.Bold), new SolidBrush(Color.Black),310,50);

            graphic.DrawString("THÔNG KÊ SỐ LẦN MƯỢN THEO THỂ LOẠI", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Black), 160, 150);
            graphic.DrawString("ngày " + DateTime.Now.Day.ToString() + "tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString()
                , font, new SolidBrush(Color.Black), 500, 200);

            bitmap = new Bitmap(dgvThongKe.Width,dgvThongKe.Height);
            dgvThongKe.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvThongKe.Width,dgvThongKe.Height));
            e.Graphics.DrawImage(bitmap,100,230);

            graphic.DrawString("Số Thể Loại: " + dgvThongKe.RowCount.ToString(), font, new SolidBrush(Color.Black), 500, 750);

            int s = 0;
            for (int i=0;i<dgvThongKe.RowCount;i++)
            {
                s += int.Parse(dgvThongKe.Rows[i].Cells[2].Value.ToString());
            }
            graphic.DrawString("Tổng số lần mượn: " + s.ToString(),font, new SolidBrush(Color.Black), 500, 780);

            graphic.DrawString("Người lập", font, new SolidBrush(Color.Black), 600, 830);
            graphic.DrawString("người duyệt", font, new SolidBrush(Color.Black), 150, 830);
        }
    }     
}
