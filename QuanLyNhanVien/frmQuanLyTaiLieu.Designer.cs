namespace QuanLyThuVien
{
    partial class frmQuanLyTaiLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuanLyTaiLieu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTaiLieu = new System.Windows.Forms.DataGridView();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnTìm = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbInFor = new System.Windows.Forms.GroupBox();
            this.pnInFor = new System.Windows.Forms.Panel();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtMaTaiLieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiLieu)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbInFor.SuspendLayout();
            this.pnInFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanLyTaiLieu
            // 
            this.lblQuanLyTaiLieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuanLyTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyTaiLieu.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQuanLyTaiLieu.Location = new System.Drawing.Point(218, -1);
            this.lblQuanLyTaiLieu.Name = "lblQuanLyTaiLieu";
            this.lblQuanLyTaiLieu.Size = new System.Drawing.Size(800, 74);
            this.lblQuanLyTaiLieu.TabIndex = 75;
            this.lblQuanLyTaiLieu.Text = "Quản Lý Tài Liệu";
            this.lblQuanLyTaiLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.dgvTaiLieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(436, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(878, 615);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiện thị";
            // 
            // dgvTaiLieu
            // 
            this.dgvTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiLieu.Location = new System.Drawing.Point(3, 21);
            this.dgvTaiLieu.Name = "dgvTaiLieu";
            this.dgvTaiLieu.ReadOnly = true;
            this.dgvTaiLieu.RowTemplate.Height = 24;
            this.dgvTaiLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiLieu.Size = new System.Drawing.Size(872, 592);
            this.dgvTaiLieu.TabIndex = 0;
            this.dgvTaiLieu.SelectionChanged += new System.EventHandler(this.dgvTaiLieu_SelectionChanged);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnTìm);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Location = new System.Drawing.Point(9, 515);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(421, 86);
            this.grbChucNang.TabIndex = 77;
            this.grbChucNang.TabStop = false;
            // 
            // btnTìm
            // 
            this.btnTìm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTìm.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnTìm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTìm.Location = new System.Drawing.Point(108, 20);
            this.btnTìm.Margin = new System.Windows.Forms.Padding(1);
            this.btnTìm.Name = "btnTìm";
            this.btnTìm.Padding = new System.Windows.Forms.Padding(1);
            this.btnTìm.Size = new System.Drawing.Size(93, 49);
            this.btnTìm.TabIndex = 64;
            this.btnTìm.Text = "Tìm";
            this.btnTìm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTìm.UseVisualStyleBackColor = false;
            this.btnTìm.Click += new System.EventHandler(this.btnTìm_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(205, 20);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(1);
            this.btnSua.Size = new System.Drawing.Size(87, 49);
            this.btnSua.TabIndex = 67;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(11, 20);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(1);
            this.btnThem.Size = new System.Drawing.Size(93, 49);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(307, 20);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(1);
            this.btnXoa.Size = new System.Drawing.Size(99, 49);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbInFor
            // 
            this.grbInFor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbInFor.Controls.Add(this.txtMaTaiLieu);
            this.grbInFor.Controls.Add(this.label12);
            this.grbInFor.Enabled = false;
            this.grbInFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInFor.Location = new System.Drawing.Point(9, 96);
            this.grbInFor.Margin = new System.Windows.Forms.Padding(0);
            this.grbInFor.Name = "grbInFor";
            this.grbInFor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInFor.Size = new System.Drawing.Size(375, 400);
            this.grbInFor.TabIndex = 85;
            this.grbInFor.TabStop = false;
            this.grbInFor.Text = "Nhập thông tin ";
            // 
            // pnInFor
            // 
            this.pnInFor.Controls.Add(this.cboTheLoai);
            this.pnInFor.Controls.Add(this.txtSoLuong);
            this.pnInFor.Controls.Add(this.txtTenTL);
            this.pnInFor.Controls.Add(this.label1);
            this.pnInFor.Controls.Add(this.label13);
            this.pnInFor.Controls.Add(this.txtTacGia);
            this.pnInFor.Controls.Add(this.label11);
            this.pnInFor.Controls.Add(this.txtNamXB);
            this.pnInFor.Controls.Add(this.label5);
            this.pnInFor.Controls.Add(this.label3);
            this.pnInFor.Controls.Add(this.label4);
            this.pnInFor.Controls.Add(this.txtNXB);
            this.pnInFor.Enabled = false;
            this.pnInFor.Location = new System.Drawing.Point(5, 194);
            this.pnInFor.Margin = new System.Windows.Forms.Padding(4);
            this.pnInFor.Name = "pnInFor";
            this.pnInFor.Size = new System.Drawing.Size(372, 302);
            this.pnInFor.TabIndex = 86;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(135, 52);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(218, 24);
            this.cboTheLoai.TabIndex = 30;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(135, 100);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(219, 30);
            this.txtSoLuong.TabIndex = 29;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTL.Location = new System.Drawing.Point(135, 2);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTL.Multiline = true;
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(219, 30);
            this.txtTenTL.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Số Lượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 31);
            this.label13.TabIndex = 9;
            this.label13.Text = "Tên tài liệu";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTacGia.Location = new System.Drawing.Point(135, 256);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(219, 30);
            this.txtTacGia.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 31);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nhà Xuất Bản";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNamXB.Location = new System.Drawing.Point(135, 206);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamXB.Multiline = true;
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(219, 30);
            this.txtNamXB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã thể loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Năm Xuất Bản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tác giả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNXB.Location = new System.Drawing.Point(135, 153);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNXB.Multiline = true;
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(219, 30);
            this.txtNXB.TabIndex = 19;
            // 
            // txtMaTaiLieu
            // 
            this.txtMaTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTaiLieu.Location = new System.Drawing.Point(139, 49);
            this.txtMaTaiLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTaiLieu.Multiline = true;
            this.txtMaTaiLieu.Name = "txtMaTaiLieu";
            this.txtMaTaiLieu.Size = new System.Drawing.Size(219, 30);
            this.txtMaTaiLieu.TabIndex = 14;
            this.txtMaTaiLieu.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Mã tài liệu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmQuanLyTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnInFor);
            this.Controls.Add(this.grbInFor);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblQuanLyTaiLieu);
            this.Name = "frmQuanLyTaiLieu";
            this.Text = "frmTaiLieu";
            this.Load += new System.EventHandler(this.frmTaiLieu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiLieu)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbInFor.ResumeLayout(false);
            this.grbInFor.PerformLayout();
            this.pnInFor.ResumeLayout(false);
            this.pnInFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyTaiLieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTaiLieu;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnTìm;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbInFor;
        private System.Windows.Forms.TextBox txtMaTaiLieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnInFor;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.ComboBox cboTheLoai;
    }
}