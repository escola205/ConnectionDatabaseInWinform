using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionDatabaseWf
{
    public partial class DocGia : UserControl
    {
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private string connectionString =
    @"Data Source=ESCOLA\ESCOLA;Initial Catalog=Libarys;User ID=sa;Password=123456";

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT
                        MaDGCode AS [Mã độc giả], 
                        HoVaTen AS [Họ và tên], 
                        CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS [Giới tính],
                        CONVERT(date, NgaySinh) AS [Ngày sinh], 
                        DiaChi AS [Địa chỉ], 
                        DienThoai AS [Điện thoại], 
                        CMND, 
                        CONVERT(date, NgayLamThe) AS [Ngày làm thẻ]
                    FROM DocGia";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    grvDatabase.DataSource = dt;

                    // Đặt lại tên cột hiển thị
                    if (grvDatabase.Columns.Contains("MaDGCode"))
                        grvDatabase.Columns["MaDGCode"].HeaderText = "Mã độc giả";
                    if (grvDatabase.Columns.Contains("HoVaTen"))
                        grvDatabase.Columns["HoVaTen"].HeaderText = "Họ và tên";
                    if (grvDatabase.Columns.Contains("GioiTinh"))
                        grvDatabase.Columns["GioiTinh"].HeaderText = "Giới tính";
                    if (grvDatabase.Columns.Contains("NgaySinh"))
                        grvDatabase.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    if (grvDatabase.Columns.Contains("DiaChi"))
                        grvDatabase.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    if (grvDatabase.Columns.Contains("DienThoai"))
                        grvDatabase.Columns["DienThoai"].HeaderText = "Điện thoại";
                    if (grvDatabase.Columns.Contains("CMND"))
                        grvDatabase.Columns["CMND"].HeaderText = "CMND";
                    if (grvDatabase.Columns.Contains("NgayLamThe"))
                        grvDatabase.Columns["NgayLamThe"].HeaderText = "Ngày làm thẻ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) || string.IsNullOrWhiteSpace(txtTenDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã độc giả và Họ tên!");
                return;
            }

            if (cbGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO DocGia
                    (MaDGCode, HoVaTen, GioiTinh, NgaySinh, DiaChi, DienThoai, CMND, NgayLamThe)
                     VALUES
                    (@MaDGCode, @HoVaTen, @GioiTinh, @NgaySinh, @DiaChi, @DienThoai, @CMND, @NgayLamThe)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gán tham số
                        cmd.Parameters.AddWithValue("@MaDGCode", txtMaDocGia.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoVaTen", txtTenDocGia.Text.Trim());

                        // Lấy giới tính từ ComboBox
                        string gioiTinhText = cbGioiTinh.SelectedItem.ToString();
                        int gioiTinh = gioiTinhText == "Nam" ? 1 : 0;
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                        cmd.Parameters.AddWithValue("@CMND", txtCMND.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayLamThe", dtNgayLamThe.Value.Date);

                        // Thực thi
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm độc giả thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
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
                    string query = @"UPDATE DocGia
                             SET HoVaTen = @HoVaTen,
                                 GioiTinh = @GioiTinh,
                                 NgaySinh = @NgaySinh,
                                 DiaChi = @DiaChi,
                                 DienThoai = @DienThoai,
                                 CMND = @CMND,
                                 NgayLamThe = @NgayLamThe
                             WHERE MaDGCode = @MaDGCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDGCode", txtMaDocGia.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoVaTen", txtTenDocGia.Text.Trim());

                        string gioiTinhText = cbGioiTinh.SelectedItem.ToString();
                        int gioiTinh = gioiTinhText == "Nam" ? 1 : 0;
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                        cmd.Parameters.AddWithValue("@CMND", txtCMND.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayLamThe", dtNgayLamThe.Value.Date);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sửa độc giả thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message);
                }
            }
        }

        private void grvDatabase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = grvDatabase.Rows[e.RowIndex];

                txtMaDocGia.Text = row.Cells["Mã độc giả"].Value?.ToString();
                txtTenDocGia.Text = row.Cells["Họ và tên"].Value?.ToString();
                cbGioiTinh.Text = row.Cells["Giới tính"].Value?.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngày sinh"].Value);
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString();
                txtDienThoai.Text = row.Cells["Điện thoại"].Value?.ToString();
                txtCMND.Text = row.Cells["CMND"].Value?.ToString();
                dtNgayLamThe.Value = Convert.ToDateTime(row.Cells["Ngày làm thẻ"].Value);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã độc giả cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa độc giả này?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM DocGia WHERE MaDGCode = @MaDGCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDGCode", txtMaDocGia.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa độc giả thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maDocGia = txtTimKiemTheoMa.Text.Trim();

            if (string.IsNullOrWhiteSpace(maDocGia))
            {
                MessageBox.Show("Vui lòng nhập Mã độc giả cần tìm!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT
                    MaDGCode AS [Mã độc giả], 
                    HoVaTen AS [Họ và tên], 
                    CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS [Giới tính],
                    CONVERT(date, NgaySinh) AS [Ngày sinh], 
                    DiaChi AS [Địa chỉ], 
                    DienThoai AS [Điện thoại], 
                    CMND, 
                    CONVERT(date, NgayLamThe) AS [Ngày làm thẻ]
                FROM DocGia
                WHERE MaDGCode = @MaDGCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDGCode", maDocGia);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            grvDatabase.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy độc giả với mã: " + maDocGia);
                            grvDatabase.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

    }
}
