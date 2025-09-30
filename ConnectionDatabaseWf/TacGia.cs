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
    public partial class TacGia : UserControl
    {
        private string connectionString = @"Data Source=ESCOLA\ESCOLA; Initial Catalog=Libarys; User Id=sa;Password=123456";

        public TacGia()
        {
            InitializeComponent();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                   SELECT MaTGCode,
                        HoVaTenTG,
                        CASE 
                            WHEN GioiTinh = 1 THEN N'Nam'
                            ELSE N'Nữ'
                        END AS GioiTinh,
                        QueQuan 
                FROM TacGia
                ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grvDatabase.DataSource = dt;

                if (grvDatabase.Columns.Contains("MaTGCode")) grvDatabase.Columns["MaTGCode"].HeaderText = "Mã tác giả";
                if (grvDatabase.Columns.Contains("HoVaTenTG")) grvDatabase.Columns["HoVaTenTG"].HeaderText = "Tên tác giả";
                if (grvDatabase.Columns.Contains("GioiTinh")) grvDatabase.Columns["GioiTinh"].HeaderText = "Giới tính";
                if (grvDatabase.Columns.Contains("QueQuan")) grvDatabase.Columns["QueQuan"].HeaderText = "Quê quán";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã tác giả cần xóa!");
                return;
            }

            var confirm = MessageBox.Show(
                        "Tác giả này có thể đang được sử dụng trong bảng Sách.\n" +
                        "Bạn có chắc chắn muốn xóa không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM TacGia WHERE MaTGCode = @MaTGCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTGCode", txtMaTacGia.Text.Trim());
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Xóa tác giả thành công!");
                        else
                            MessageBox.Show("Không tìm thấy tác giả để xóa!");
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTacGia.Text) || string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO TacGia(MaTGCode, HoVaTenTG, GioiTinh, QueQuan)
                             VALUES (@MaTGCode, @HoVaTenTG, @GioiTinh, @QueQuan)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTGCode", txtMaTacGia.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoVaTenTG", txtHoVaTen.Text.Trim());

                        string gioiTinhText = cbGioiTinh.SelectedItem.ToString().Trim();
                        int gioiTinhValue = (gioiTinhText == "Nam") ? 1 : 0;
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinhValue);

                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm tác giả thành công!");
                    LoadData();
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
                    string query = @"
                    UPDATE TacGia 
                    SET HoVaTenTG = @HoVaTenTG,
                        GioiTinh = @GioiTinh,
                        QueQuan = @QueQuan
                    WHERE MaTGCode = @MaTGCode;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTGCode", txtMaTacGia.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoVaTenTG", txtHoVaTen.Text.Trim());

                        string gioiTinhText = cbGioiTinh.SelectedItem.ToString();
                        int gioiTinh = gioiTinhText == "Nam" ? 1 : 0;
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Sửa tác giả thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maTG = textBox5.Text.Trim();
            if (string.IsNullOrWhiteSpace(maTG))
            {
                MessageBox.Show("Vui lòng nhập mã tác giả để tìm kiếm!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT MaTGCode,
                       HoVaTenTG,
                       CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
                       QueQuan
                FROM TacGia
                WHERE MaTGCode LIKE @MaTGCode";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@MaTGCode", "%" + maTG + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            grvDatabase.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tác giả!");
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

        private void grvDatabase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDatabase.Rows[e.RowIndex];

                txtMaTacGia.Text = row.Cells["MaTGCode"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["HoVaTenTG"].Value?.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString();

                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                if (!string.IsNullOrEmpty(gioiTinh))
                {
                    int index = cbGioiTinh.FindStringExact(gioiTinh);
                    if (index >= 0)
                        cbGioiTinh.SelectedIndex = index;
                }
            }
        }
    }
}
