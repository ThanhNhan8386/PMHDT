using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH_LAB5
{
    public partial class Form2 : Form
    {
        // 🔗 Chuỗi kết nối của bạn
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NAM4\PTMT\LAB5\TH_LAB5\TH_LAB5\Database1.mdf;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        // ========================================
        // 1️⃣ Load danh sách mã lớp khi mở Form
        // ========================================
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadMaLop();
        }

        private void LoadMaLop()
        {
            cboMaLop.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MaLop FROM SinhVien", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboMaLop.Items.Add(dr["MaLop"].ToString());
                }
                conn.Close();
            }
        }

        // ========================================
        // 2️⃣ Khi chọn mã lớp → hiển thị danh sách sinh viên
        // ========================================
        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVienTheoLop();
        }

        private void LoadSinhVienTheoLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM SinhVien WHERE MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", cboMaLop.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                conn.Close();
            }
        }

        // ========================================
        // 3️⃣ Khi click chọn sinh viên trong DataGridView
        // ========================================
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtTenSV.Text = row.Cells["TenSV"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                txtMaLop.Text = row.Cells["MaLop"].Value.ToString();
            }
        }

        // ========================================
        // 4️⃣ Thêm sinh viên (có Parameter)
        // ========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || txtTenSV.Text == "" || txtMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop)
                               VALUES(@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @MaLop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVienTheoLop();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================
        // 5️⃣ Sửa sinh viên (có Parameter)
        // ========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE SinhVien 
                               SET TenSV=@TenSV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh,
                                   QueQuan=@QueQuan, MaLop=@MaLop
                               WHERE MaSV=@MaSV";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Đã cập nhật sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVienTheoLop();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================
        // 6️⃣ Xóa sinh viên (có Parameter)
        // ========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM SinhVien WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Đã xóa sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVienTheoLop();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Không thể xóa sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================
        // 7️⃣ Hàm dọn dữ liệu sau khi thao tác
        // ========================================
        private void ClearInput()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            cboGioiTinh.SelectedIndex = -1;
            txtQueQuan.Clear();
            txtMaLop.Clear();
        }
    }
}
