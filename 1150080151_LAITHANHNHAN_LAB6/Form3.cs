using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNXB
{
    public partial class Form3 : Form
    {
        // 🔹 Chuỗi kết nối đúng đường dẫn của anh
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\NAM4\PTMT\1150080151_LAITHANHNHAN_LAB6\1150080151_LAITHANHNHAN_LAB6\Database1.mdf;
              Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form3()
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

            SqlCommand cmd = new SqlCommand("HienThiNXB", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
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
            DongKetNoi();
        }

        // ===== LOAD FORM =====
        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        // ===== KHI CHỌN DÒNG TRONG LISTVIEW =====
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = lvi.SubItems[0].Text;
            txtTenXB.Text = lvi.SubItems[1].Text;
            txtDiaChi.Text = lvi.SubItems[2].Text;
        }

        // ===== NÚT CẬP NHẬT =====
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Nhà xuất bản cần cập nhật!", "Thông báo");
                return;
            }

            MoKetNoi();

            SqlCommand cmd = new SqlCommand("CapNhatThongTin", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNXB", SqlDbType.Char).Value = txtMaXB.Text.Trim();
            cmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar, 100).Value = txtTenXB.Text.Trim();
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 500).Value = txtDiaChi.Text.Trim();

            int kq = cmd.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                HienThiDanhSachNXB();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã NXB cần cập nhật!", "Thông báo");
            }

            DongKetNoi();
        }
    }
}
