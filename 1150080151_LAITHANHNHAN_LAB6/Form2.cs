using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNXB
{
    public partial class Form2 : Form
    {
        // 🔹 Chuỗi kết nối đúng đường dẫn của anh
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\NAM4\PTMT\1150080151_LAITHANHNHAN_LAB6\1150080151_LAITHANHNHAN_LAB6\Database1.mdf;
              Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        // ===== MỞ KẾT NỐI =====
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // ===== ĐÓNG KẾT NỐI =====
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // ===== HIỂN THỊ DANH SÁCH NXB =====
        private void HienThiDanhSachNXB()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiNXB"; // Thủ tục lấy danh sách NXB
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();

            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string diachi = reader.GetString(2);

                ListViewItem lvi = new ListViewItem(ma);
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(diachi);
                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();
        }

        // ===== FORM LOAD =====
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
            txtMaXB.Focus();
        }

        // ===== THÊM DỮ LIỆU =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "ThemDuLieu"; // Thủ tục đã tạo trong SQL
            sqlCmd.Connection = sqlCon;

            // Thêm tham số
            sqlCmd.Parameters.Add("@MaNXB", SqlDbType.Char).Value = txtMaXB.Text.Trim();
            sqlCmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar, 100).Value = txtTenXB.Text.Trim();
            sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 500).Value = txtDiaChi.Text.Trim();

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo");
                HienThiDanhSachNXB();
                txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";
            }

            DongKetNoi();
        }
    }
}
