namespace ConnectionDatabaseWf
{
    partial class TacGia
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
            this.lbMaTacGia = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.grvDatabase = new System.Windows.Forms.DataGridView();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbTimKiemTheoMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Location = new System.Drawing.Point(291, 20);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(60, 13);
            this.lbMaTacGia.TabIndex = 0;
            this.lbMaTacGia.Text = "Mã tác giả:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.AutoSize = true;
            this.tbHoTen.Location = new System.Drawing.Point(291, 58);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(57, 13);
            this.tbHoTen.TabIndex = 1;
            this.tbHoTen.Text = "Họ và tên:";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.AutoSize = true;
            this.tbGioiTinh.Location = new System.Drawing.Point(291, 99);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.tbGioiTinh.TabIndex = 2;
            this.tbGioiTinh.Text = "Giới tính:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Location = new System.Drawing.Point(291, 150);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(54, 13);
            this.lbQueQuan.TabIndex = 3;
            this.lbQueQuan.Text = "Quê quán";
            // 
            // grvDatabase
            // 
            this.grvDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatabase.Location = new System.Drawing.Point(0, 242);
            this.grvDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.grvDatabase.Name = "grvDatabase";
            this.grvDatabase.Size = new System.Drawing.Size(800, 208);
            this.grvDatabase.TabIndex = 4;
            this.grvDatabase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDatabase_CellDoubleClick);
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(392, 20);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(120, 20);
            this.txtMaTacGia.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(392, 58);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(120, 20);
            this.txtHoVaTen.TabIndex = 6;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(392, 143);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(120, 20);
            this.txtQueQuan.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(620, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 9;
            // 
            // lbTimKiemTheoMa
            // 
            this.lbTimKiemTheoMa.AutoSize = true;
            this.lbTimKiemTheoMa.Location = new System.Drawing.Point(637, 45);
            this.lbTimKiemTheoMa.Name = "lbTimKiemTheoMa";
            this.lbTimKiemTheoMa.Size = new System.Drawing.Size(90, 13);
            this.lbTimKiemTheoMa.TabIndex = 10;
            this.lbTimKiemTheoMa.Text = "Tìm kiếm theo mã";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(125, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(254, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(383, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(522, 183);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(80, 35);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(640, 117);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(392, 99);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(120, 21);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTimKiemTheoMa);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.grvDatabase);
            this.Controls.Add(this.lbQueQuan);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.lbMaTacGia);
            this.Name = "TacGia";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaTacGia;
        private System.Windows.Forms.Label tbHoTen;
        private System.Windows.Forms.Label tbGioiTinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.DataGridView grvDatabase;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbTimKiemTheoMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}
