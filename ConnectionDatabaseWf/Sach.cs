using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnectionDatabaseWf
{
    public partial class Sach : UserControl
    {
        private string connectionString =
    @"Data Source=ESCOLA\ESCOLA;Initial Catalog=Libarys;User ID=sa;Password=123456";
        public Sach()
        {
            InitializeComponent();
        }
        private void Sach_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboboxes();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    s.MaSachCode,
                    s.MaTG,
                    s.MaTL,              
                    t.TenTL,
                    s.TenSach,
                    s.NhaXuatBan,
                    CONVERT(date, s.NgayXuatBan) as NgayXuatBan,
                    s.SoLuong,
                    s.GiaTien
                FROM Sach s
                JOIN TheLoai t ON s.MaTL = t.MaTL";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    grvDatabase.DataSource = dt;

                    // ẩn cột mã thể loại (vẫn có trong DataSource để map combobox)
                    if (grvDatabase.Columns.Contains("MaTL"))
                        grvDatabase.Columns["MaTL"].Visible = false;
                    if (grvDatabase.Columns.Contains("MaTG"))
                        grvDatabase.Columns["MaTG"].Visible = false;

                    // Đặt header hiển thị tiếng Việt
                    if (grvDatabase.Columns.Contains("MaSachCode")) grvDatabase.Columns["MaSachCode"].HeaderText = "Mã sách";
                    if (grvDatabase.Columns.Contains("MaTG")) grvDatabase.Columns["MaTG"].HeaderText = "Mã tác giả";
                    if (grvDatabase.Columns.Contains("TenTL")) grvDatabase.Columns["TenTL"].HeaderText = "Thể loại";
                    if (grvDatabase.Columns.Contains("TenSach")) grvDatabase.Columns["TenSach"].HeaderText = "Tên sách";
                    if (grvDatabase.Columns.Contains("NhaXuatBan")) grvDatabase.Columns["NhaXuatBan"].HeaderText = "Nhà xuất bản";
                    if (grvDatabase.Columns.Contains("NgayXuatBan"))
                    {
                        grvDatabase.Columns["NgayXuatBan"].HeaderText = "Ngày xuất bản";
                        grvDatabase.Columns["NgayXuatBan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    if (grvDatabase.Columns.Contains("SoLuong")) grvDatabase.Columns["SoLuong"].HeaderText = "Số lượng";
                    if (grvDatabase.Columns.Contains("GiaTien")) grvDatabase.Columns["GiaTien"].HeaderText = "Giá tiền";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }


        private void grvDatabase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            DataGridViewRow row = grvDatabase.Rows[e.RowIndex];

            string GetValue(string colName, int fallbackIndex = -1)
            {
                if (grvDatabase.Columns.Contains(colName))
                {
                    var v = row.Cells[colName].Value;
                    return v == null ? string.Empty : v.ToString();
                }
                if (fallbackIndex >= 0 && fallbackIndex < row.Cells.Count)
                {
                    var v = row.Cells[fallbackIndex].Value;
                    return v == null ? string.Empty : v.ToString();
                }
                return string.Empty;
            }

            txtMaSach.Text = GetValue("MaSachCode", 0);
            txtTenSach.Text = GetValue("TenSach");
            txtNhaXuatBan.Text = GetValue("NhaXuatBan");

            string ngayStr = GetValue("NgayXuatBan");
            if (DateTime.TryParse(ngayStr, out DateTime dt))
                dtNgayXuatBan.Value = dt;

            txtSoLuong.Text = GetValue("SoLuong");
            txtGiaTien.Text = GetValue("GiaTien");

            if (grvDatabase.Columns.Contains("MaTG"))
                cbMaTacGia.SelectedValue = row.Cells["MaTG"].Value;

            if (grvDatabase.Columns.Contains("MaTL"))
            {
                cbTheLoai.SelectedValue = row.Cells["MaTL"].Value;
            }
            else if (grvDatabase.Columns.Contains("TenTL"))
            {
                cbTheLoai.Text = row.Cells["TenTL"].Value?.ToString();
            }
        }


        private void LoadComboboxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

           
                string queryTG = "SELECT MaTG, MaTGCode, HoVaTenTG FROM TacGia";
                SqlDataAdapter daTG = new SqlDataAdapter(queryTG, conn);
                DataTable dtTG = new DataTable();
                daTG.Fill(dtTG);

                cbMaTacGia.DataSource = dtTG;
                cbMaTacGia.DisplayMember = "MaTGCode";
                cbMaTacGia.ValueMember = "MaTG";
                cbMaTacGia.SelectedIndex = -1;


  
                string queryTL = "SELECT MaTL, TenTL FROM TheLoai";
                SqlDataAdapter daTL = new SqlDataAdapter(queryTL, conn);
                DataTable dtTL = new DataTable();
                daTL.Fill(dtTL);

                cbTheLoai.DataSource = dtTL;
                cbTheLoai.DisplayMember = "TenTL";   // Hiển thị tên
                cbTheLoai.ValueMember = "MaTL";      // Giá trị thực là mã
                cbTheLoai.SelectedIndex = -1; 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Sach 
                            (MaSachCode, TenSach, NhaXuatBan, NgayXuatBan, SoLuong, GiaTien, MaTG, MaTL) 
                             VALUES 
                            (@MaSachCode, @TenSach, @NhaXuatBan, @NgayXuatBan, @SoLuong, @GiaTien, @MaTG, @MaTL)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSachCode", txtMaSach.Text);
                        cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", txtNhaXuatBan.Text);
                        cmd.Parameters.AddWithValue("@NgayXuatBan", dtNgayXuatBan.Value);
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                        cmd.Parameters.AddWithValue("@GiaTien", int.Parse(txtGiaTien.Text));
                        cmd.Parameters.AddWithValue("@MaTG", cbMaTacGia.SelectedValue);   // combobox value = MaTG
                        cmd.Parameters.AddWithValue("@MaTL", cbTheLoai.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm sách thành công!");
                    LoadData(); // gọi lại hàm load để refresh datagridview
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Sach 
                             SET TenSach=@TenSach, 
                                 NhaXuatBan=@NhaXuatBan, 
                                 NgayXuatBan=@NgayXuatBan, 
                                 SoLuong=@SoLuong, 
                                 GiaTien=@GiaTien, 
                                 MaTG=@MaTG, 
                                 MaTL=@MaTL
                             WHERE MaSachCode=@MaSachCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSachCode", txtMaSach.Text);
                        cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", txtNhaXuatBan.Text);
                        cmd.Parameters.AddWithValue("@NgayXuatBan", dtNgayXuatBan.Value);
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                        cmd.Parameters.AddWithValue("@GiaTien", int.Parse(txtGiaTien.Text));
                        cmd.Parameters.AddWithValue("@MaTG", cbMaTacGia.SelectedValue);
                        cmd.Parameters.AddWithValue("@MaTL", cbTheLoai.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Bạn phải double click chọn 1 sách trước khi xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Sach WHERE MaSachCode=@MaSachCode";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSachCode", txtMaSach.Text);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Xóa thành công!");
                        LoadData();

                        // clear form sau khi xóa
                        txtMaSach.Clear();
                        txtTenSach.Clear();
                        txtNhaXuatBan.Clear();
                        txtSoLuong.Clear();
                        txtGiaTien.Clear();
                        cbMaTacGia.SelectedIndex = -1;
                        cbTheLoai.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSachCanTim = txtTimKiemTheoMa.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSachCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        s.MaSachCode,
                        s.MaTG,
                        t.TenTL,
                        s.TenSach,
                        s.NhaXuatBan,
                        CONVERT(date, s.NgayXuatBan) as NgayXuatBan,
                        s.SoLuong,
                        s.GiaTien
                    FROM Sach s
                    JOIN TheLoai t ON s.MaTL = t.MaTL
                    WHERE s.MaSachCode LIKE @MaSachCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSachCode", "%" + maSachCanTim + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            grvDatabase.DataSource = dt;

                            // chỉnh lại header
                            if (grvDatabase.Columns.Contains("MaSachCode"))
                                grvDatabase.Columns["MaSachCode"].HeaderText = "Mã sách";
                            if (grvDatabase.Columns.Contains("MaTG"))
                                grvDatabase.Columns["MaTG"].HeaderText = "Mã tác giả";
                            if (grvDatabase.Columns.Contains("TenTL"))
                                grvDatabase.Columns["TenTL"].HeaderText = "Thể loại";
                            if (grvDatabase.Columns.Contains("TenSach"))
                                grvDatabase.Columns["TenSach"].HeaderText = "Tên sách";
                            if (grvDatabase.Columns.Contains("NhaXuatBan"))
                                grvDatabase.Columns["NhaXuatBan"].HeaderText = "Nhà xuất bản";
                            if (grvDatabase.Columns.Contains("NgayXuatBan"))
                                grvDatabase.Columns["NgayXuatBan"].HeaderText = "Ngày xuất bản";
                            if (grvDatabase.Columns.Contains("SoLuong"))
                                grvDatabase.Columns["SoLuong"].HeaderText = "Số lượng";
                            if (grvDatabase.Columns.Contains("GiaTien"))
                                grvDatabase.Columns["GiaTien"].HeaderText = "Giá tiền";

                            // format ngày
                            grvDatabase.Columns["NgayXuatBan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách nào với mã: " + maSachCanTim);
                            grvDatabase.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
