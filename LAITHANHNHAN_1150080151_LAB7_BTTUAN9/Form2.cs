using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_ThemDuLieu
{
    public partial class Form2 : Form
    {
        // 🔹 Chuỗi kết nối CSDL
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=D:\NAM4\PTMT\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\QuanLyBanSach.mdf;
Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        // 🔹 Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // 🔹 Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // 🔹 Hiển thị dữ liệu ra DataGridView
        private void HienThiDuLieu()
        {
            MoKetNoi();
            string sql = "SELECT * FROM NhaXuatBan";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNXB.DataSource = dt;
            DongKetNoi();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        // 🔹 Sự kiện nhấn nút "Thêm dữ liệu"
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                string sql = "INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi) VALUES (@MaNXB, @TenNXB, @DiaChi)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@MaNXB", txtMaNXB.Text);
                cmd.Parameters.AddWithValue("@TenNXB", txtTenNXB.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công!");
                HienThiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
