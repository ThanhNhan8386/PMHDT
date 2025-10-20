using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNXB
{
    public partial class Form4 : Form
    {
        // 🔹 Chuỗi kết nối
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\NAM4\PTMT\1150080151_LAITHANHNHAN_LAB6\1150080151_LAITHANHNHAN_LAB6\Database1.mdf;
              Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form4()
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
        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        // ===== NÚT XÓA =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà xuất bản để xóa!", "Thông báo");
                return;
            }

            string ma = lsvDanhSach.SelectedItems[0].SubItems[0].Text;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhà xuất bản {ma} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MoKetNoi();

            SqlCommand cmd = new SqlCommand("XoaNXB", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNXB", SqlDbType.Char).Value = ma;

            int kq = cmd.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                HienThiDanhSachNXB();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã NXB cần xóa!", "Thông báo");
            }

            DongKetNoi();
        }
    }
}
