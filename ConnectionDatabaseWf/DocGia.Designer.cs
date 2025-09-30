namespace ConnectionDatabaseWf
{
    partial class DocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvDatabase = new System.Windows.Forms.DataGridView();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbNhaXuatBan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNgayXuatBan = new System.Windows.Forms.Label();
            this.lbMaTacGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.lbTimKiemTheoMaDocGia = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtNgayLamThe = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDatabase
            // 
            this.grvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatabase.Location = new System.Drawing.Point(0, 242);
            this.grvDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.grvDatabase.Name = "grvDatabase";
            this.grvDatabase.Size = new System.Drawing.Size(800, 205);
            this.grvDatabase.TabIndex = 0;
            this.grvDatabase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDatabase_CellDoubleClick);
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDocGia.Location = new System.Drawing.Point(35, 20);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(71, 15);
            this.lbMaDocGia.TabIndex = 1;
            this.lbMaDocGia.Text = "Mã độc giả:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(35, 59);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(74, 15);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên độc giả:";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(35, 99);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(55, 15);
            this.lbTheLoai.TabIndex = 3;
            this.lbTheLoai.Text = "Giới tính:";
            // 
            // lbNhaXuatBan
            // 
            this.lbNhaXuatBan.AutoSize = true;
            this.lbNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaXuatBan.Location = new System.Drawing.Point(35, 140);
            this.lbNhaXuatBan.Name = "lbNhaXuatBan";
            this.lbNhaXuatBan.Size = new System.Drawing.Size(64, 15);
            this.lbNhaXuatBan.TabIndex = 4;
            this.lbNhaXuatBan.Text = "Ngày sinh:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(125, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNgayXuatBan
            // 
            this.lbNgayXuatBan.AutoSize = true;
            this.lbNgayXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXuatBan.Location = new System.Drawing.Point(346, 20);
            this.lbNgayXuatBan.Name = "lbNgayXuatBan";
            this.lbNgayXuatBan.Size = new System.Drawing.Size(48, 15);
            this.lbNgayXuatBan.TabIndex = 6;
            this.lbNgayXuatBan.Text = "Địa chỉ:";
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTacGia.Location = new System.Drawing.Point(346, 59);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(66, 15);
            this.lbMaTacGia.TabIndex = 7;
            this.lbMaTacGia.Text = "Điện thoại:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(346, 99);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(47, 15);
            this.lbSoLuong.TabIndex = 8;
            this.lbSoLuong.Text = "CMND:";
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien.Location = new System.Drawing.Point(346, 140);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(82, 15);
            this.lbGiaTien.TabIndex = 9;
            this.lbGiaTien.Text = "Ngày làm thẻ:";
            // 
            // lbTimKiemTheoMaDocGia
            // 
            this.lbTimKiemTheoMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiemTheoMaDocGia.Location = new System.Drawing.Point(630, 44);
            this.lbTimKiemTheoMaDocGia.Name = "lbTimKiemTheoMaDocGia";
            this.lbTimKiemTheoMaDocGia.Size = new System.Drawing.Size(127, 31);
            this.lbTimKiemTheoMaDocGia.TabIndex = 10;
            this.lbTimKiemTheoMaDocGia.Text = "Tìm kiếm mã độc giả";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(254, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(383, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(522, 183);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(80, 35);
            this.btnHienThi.TabIndex = 13;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(134, 19);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(120, 20);
            this.txtMaDocGia.TabIndex = 14;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(134, 58);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(120, 20);
            this.txtTenDocGia.TabIndex = 15;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(134, 140);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(120, 20);
            this.dtNgaySinh.TabIndex = 18;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(454, 100);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(120, 20);
            this.txtCMND.TabIndex = 20;
            // 
            // txtTimKiemTheoMa
            // 
            this.txtTimKiemTheoMa.Location = new System.Drawing.Point(620, 78);
            this.txtTimKiemTheoMa.Name = "txtTimKiemTheoMa";
            this.txtTimKiemTheoMa.Size = new System.Drawing.Size(137, 20);
            this.txtTimKiemTheoMa.TabIndex = 22;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(649, 117);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 35);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtNgayLamThe
            // 
            this.dtNgayLamThe.CustomFormat = "";
            this.dtNgayLamThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLamThe.Location = new System.Drawing.Point(454, 140);
            this.dtNgayLamThe.Name = "dtNgayLamThe";
            this.dtNgayLamThe.Size = new System.Drawing.Size(120, 20);
            this.dtNgayLamThe.TabIndex = 24;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(454, 20);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(120, 20);
            this.txtDiaChi.TabIndex = 25;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(454, 59);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(120, 20);
            this.txtDienThoai.TabIndex = 26;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(134, 99);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(120, 21);
            this.cbGioiTinh.TabIndex = 27;
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dtNgayLamThe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiemTheoMa);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbTimKiemTheoMaDocGia);
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbMaTacGia);
            this.Controls.Add(this.lbNgayXuatBan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbNhaXuatBan);
            this.Controls.Add(this.lbTheLoai);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.grvDatabase);
            this.Name = "DocGia";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDatabase;
        private System.Windows.Forms.Label lbMaDocGia;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbNhaXuatBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbNgayXuatBan;
        private System.Windows.Forms.Label lbMaTacGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label lbTimKiemTheoMaDocGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTimKiemTheoMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtNgayLamThe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}
