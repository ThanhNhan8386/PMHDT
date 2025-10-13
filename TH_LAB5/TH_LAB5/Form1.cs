using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH_LAB5
{
    public partial class Form1 : Form
    {
        // 👉 Chuỗi kết nối của bạn
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NAM4\PTMT\LAB5\TH_LAB5\TH_LAB5\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMaLop();
        }

        // =============================
        // 1️⃣ LOAD DANH SÁCH MÃ LỚP
        // =============================
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

        // =============================
        // 2️⃣ LOAD DANH SÁCH SINH VIÊN
        // =============================
        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVienTheoLop();
        }

        private void LoadSinhVienTheoLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM SinhVien WHERE MaLop='" + cboMaLop.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                conn.Close();
            }
        }

        // =============================
        // 3️⃣ CHỌN DÒNG TRONG DATAGRIDVIEW
        // =============================
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

        // =============================
        // 4️⃣ NÚT THÊM SINH VIÊN
        // =============================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || txtTenSV.Text == "" || txtMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop) VALUES('" +
                             txtMaSV.Text + "', N'" + txtTenSV.Text + "', N'" + cboGioiTinh.Text +
                             "', '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', N'" + txtQueQuan.Text +
                             "', '" + txtMaLop.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Đã thêm sinh viên thành công!");
                    LoadSinhVienTheoLop();
                }
                else
                    MessageBox.Show("Không thêm được sinh viên!");
            }
        }

        // =============================
        // 5️⃣ NÚT SỬA SINH VIÊN
        // =============================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE SinhVien SET " +
                             "TenSV = N'" + txtTenSV.Text + "', " +
                             "GioiTinh = N'" + cboGioiTinh.Text + "', " +
                             "NgaySinh = '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', " +
                             "QueQuan = N'" + txtQueQuan.Text + "', " +
                             "MaLop = '" + txtMaLop.Text + "' " +
                             "WHERE MaSV = '" + txtMaSV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Đã cập nhật thông tin sinh viên!");
                    LoadSinhVienTheoLop();
                }
                else
                    MessageBox.Show("Không thể cập nhật!");
            }
        }

        // =============================
        // 6️⃣ NÚT XÓA SINH VIÊN
        // =============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM SinhVien WHERE MaSV='" + txtMaSV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Đã xóa sinh viên thành công!");
                    LoadSinhVienTheoLop();
                    ClearInput();
                }
                else
                    MessageBox.Show("Không thể xóa sinh viên!");
            }
        }

        // =============================
        // 7️⃣ HÀM DỌN FORM
        // =============================
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
