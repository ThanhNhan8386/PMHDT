using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_ChinhSuaDuLieu
{
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=D:\NAM4\PTMT\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\QuanLyBanSach.mdf;
Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

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

        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        // Khi click vào 1 dòng trong DataGridView → đổ dữ liệu lên textbox
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNXB.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells["MaNXB"].Value.ToString();
                txtTenNXB.Text = row.Cells["TenNXB"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        // Nút cập nhật dữ liệu
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                string sql = "UPDATE NhaXuatBan SET TenNXB=@TenNXB, DiaChi=@DiaChi WHERE MaNXB=@MaNXB";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@MaNXB", txtMaNXB.Text);
                cmd.Parameters.AddWithValue("@TenNXB", txtTenNXB.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                    MessageBox.Show("Cập nhật thành công!");
                else
                    MessageBox.Show("Không tìm thấy Mã NXB cần cập nhật!");

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
