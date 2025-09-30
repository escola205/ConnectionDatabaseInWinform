namespace ConnectionDatabaseWf
{
    partial class Sach
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
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbNhaXuatBan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNgayXuatBan = new System.Windows.Forms.Label();
            this.lbMaTacGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.lbTimKiemTheoMa = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.dtNgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.cbMaTacGia = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDatabase
            // 
            this.grvDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatabase.Location = new System.Drawing.Point(0, 242);
            this.grvDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.grvDatabase.Name = "grvDatabase";
            this.grvDatabase.Size = new System.Drawing.Size(800, 205);
            this.grvDatabase.TabIndex = 0;
            this.grvDatabase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDatabase_CellDoubleClick);
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(35, 20);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(57, 15);
            this.lbMaSach.TabIndex = 1;
            this.lbMaSach.Text = "Mã sách:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(35, 59);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(60, 15);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên sách:";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(35, 99);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(54, 15);
            this.lbTheLoai.TabIndex = 3;
            this.lbTheLoai.Text = "Thể loại:";
            // 
            // lbNhaXuatBan
            // 
            this.lbNhaXuatBan.AutoSize = true;
            this.lbNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaXuatBan.Location = new System.Drawing.Point(35, 140);
            this.lbNhaXuatBan.Name = "lbNhaXuatBan";
            this.lbNhaXuatBan.Size = new System.Drawing.Size(83, 15);
            this.lbNhaXuatBan.TabIndex = 4;
            this.lbNhaXuatBan.Text = "Nhà xuất bản:";
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
            this.lbNgayXuatBan.Size = new System.Drawing.Size(88, 15);
            this.lbNgayXuatBan.TabIndex = 6;
            this.lbNgayXuatBan.Text = "Ngày xuất bản:";
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTacGia.Location = new System.Drawing.Point(346, 59);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(73, 15);
            this.lbMaTacGia.TabIndex = 7;
            this.lbMaTacGia.Text = "Mã tác giác:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(346, 99);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(59, 15);
            this.lbSoLuong.TabIndex = 8;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien.Location = new System.Drawing.Point(346, 140);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(49, 15);
            this.lbGiaTien.TabIndex = 9;
            this.lbGiaTien.Text = "Giá tiền";
            // 
            // lbTimKiemTheoMa
            // 
            this.lbTimKiemTheoMa.AutoSize = true;
            this.lbTimKiemTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiemTheoMa.Location = new System.Drawing.Point(632, 43);
            this.lbTimKiemTheoMa.Name = "lbTimKiemTheoMa";
            this.lbTimKiemTheoMa.Size = new System.Drawing.Size(106, 15);
            this.lbTimKiemTheoMa.TabIndex = 10;
            this.lbTimKiemTheoMa.Text = "Tìm kiếm theo mã";
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
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(134, 19);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(120, 20);
            this.txtMaSach.TabIndex = 14;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(134, 58);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(120, 20);
            this.txtTenSach.TabIndex = 15;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(134, 139);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(120, 20);
            this.txtNhaXuatBan.TabIndex = 16;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(134, 99);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(120, 21);
            this.cbTheLoai.TabIndex = 17;
            // 
            // dtNgayXuatBan
            // 
            this.dtNgayXuatBan.CustomFormat = "";
            this.dtNgayXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXuatBan.Location = new System.Drawing.Point(454, 19);
            this.dtNgayXuatBan.Name = "dtNgayXuatBan";
            this.dtNgayXuatBan.Size = new System.Drawing.Size(120, 20);
            this.dtNgayXuatBan.TabIndex = 18;
            // 
            // cbMaTacGia
            // 
            this.cbMaTacGia.FormattingEnabled = true;
            this.cbMaTacGia.Location = new System.Drawing.Point(454, 53);
            this.cbMaTacGia.Name = "cbMaTacGia";
            this.cbMaTacGia.Size = new System.Drawing.Size(120, 21);
            this.cbMaTacGia.TabIndex = 19;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(454, 94);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txtSoLuong.TabIndex = 20;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(454, 135);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(120, 20);
            this.txtGiaTien.TabIndex = 21;
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
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiemTheoMa);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbMaTacGia);
            this.Controls.Add(this.dtNgayXuatBan);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbTimKiemTheoMa);
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbMaTacGia);
            this.Controls.Add(this.lbNgayXuatBan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbNhaXuatBan);
            this.Controls.Add(this.lbTheLoai);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.lbMaSach);
            this.Controls.Add(this.grvDatabase);
            this.Name = "Sach";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDatabase;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbNhaXuatBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbNgayXuatBan;
        private System.Windows.Forms.Label lbMaTacGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label lbTimKiemTheoMa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.DateTimePicker dtNgayXuatBan;
        private System.Windows.Forms.ComboBox cbMaTacGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTimKiemTheoMa;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
