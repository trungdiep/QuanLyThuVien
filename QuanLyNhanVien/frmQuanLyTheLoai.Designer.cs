namespace QuanLyThuVien
{
    partial class frmQuanLyTheLoai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHienThiTheLoai = new System.Windows.Forms.DataGridView();
            this.grbInFor = new System.Windows.Forms.GroupBox();
            this.pnInFor = new System.Windows.Forms.Panel();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiTheLoai)).BeginInit();
            this.grbInFor.SuspendLayout();
            this.pnInFor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHienThiTheLoai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(438, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 615);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị dữ liệu";
            // 
            // dgvHienThiTheLoai
            // 
            this.dgvHienThiTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHienThiTheLoai.Location = new System.Drawing.Point(3, 22);
            this.dgvHienThiTheLoai.Name = "dgvHienThiTheLoai";
            this.dgvHienThiTheLoai.Size = new System.Drawing.Size(844, 590);
            this.dgvHienThiTheLoai.TabIndex = 0;
            this.dgvHienThiTheLoai.SelectionChanged += new System.EventHandler(this.dgvHienThiTheLoai_SelectionChanged);
            // 
            // grbInFor
            // 
            this.grbInFor.Controls.Add(this.pnInFor);
            this.grbInFor.Controls.Add(this.txtMaTheLoai);
            this.grbInFor.Controls.Add(this.label2);
            this.grbInFor.Enabled = false;
            this.grbInFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbInFor.Location = new System.Drawing.Point(12, 74);
            this.grbInFor.Name = "grbInFor";
            this.grbInFor.Size = new System.Drawing.Size(396, 369);
            this.grbInFor.TabIndex = 6;
            this.grbInFor.TabStop = false;
            this.grbInFor.Text = "Nhập thông tin";
            // 
            // pnInFor
            // 
            this.pnInFor.Controls.Add(this.txtTenTheLoai);
            this.pnInFor.Controls.Add(this.label3);
            this.pnInFor.Controls.Add(this.txtGhiChu);
            this.pnInFor.Controls.Add(this.label4);
            this.pnInFor.Location = new System.Drawing.Point(0, 110);
            this.pnInFor.Name = "pnInFor";
            this.pnInFor.Size = new System.Drawing.Size(396, 259);
            this.pnInFor.TabIndex = 6;
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(129, 20);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(233, 26);
            this.txtTenTheLoai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên thể loại";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(129, 84);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(233, 122);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi chú";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Enabled = false;
            this.txtMaTheLoai.Location = new System.Drawing.Point(129, 56);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(233, 26);
            this.txtMaTheLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thể loại";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(12, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 92);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.Location = new System.Drawing.Point(220, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTim.Location = new System.Drawing.Point(322, 21);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(93, 49);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSua.Location = new System.Drawing.Point(113, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThem.Location = new System.Drawing.Point(6, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyNhanVien.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(213, -3);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(800, 74);
            this.lblQuanLyNhanVien.TabIndex = 75;
            this.lblQuanLyNhanVien.Text = "Quản Lý Thể Loại\r\n";
            this.lblQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuanLyNhanVien.Click += new System.EventHandler(this.lblQuanLyNhanVien_Click);
            // 
            // frmQuanLyTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInFor);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyTheLoai";
            this.Text = "frmQuanLyTheLoai";
            this.Load += new System.EventHandler(this.frmQuanLyTheLoai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiTheLoai)).EndInit();
            this.grbInFor.ResumeLayout(false);
            this.grbInFor.PerformLayout();
            this.pnInFor.ResumeLayout(false);
            this.pnInFor.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHienThiTheLoai;
        private System.Windows.Forms.GroupBox grbInFor;
        private System.Windows.Forms.Panel pnInFor;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
    }
}