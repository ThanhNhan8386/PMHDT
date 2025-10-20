using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNXB
{
    public partial class Form1 : Form
    {
        // 🔹 Chuỗi kết nối (đường dẫn của anh)
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\NAM4\PTMT\1150080151_LAITHANHNHAN_LAB6\1150080151_LAITHANHNHAN_LAB6\Database1.mdf;
              Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form1()
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

        // ===== HIỂN THỊ DANH SÁCH NHÀ XUẤT BẢN =====
        private void HienThiDanhSachNXB()
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiNXB";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();

            while (reader.Read())
            {
                string maXB = reader.GetString(0);
                string tenXB = reader.GetString(1);
                string diaChi = reader.GetString(2);

                ListViewItem lvi = new ListViewItem(maXB);
                lvi.SubItems.Add(tenXB);
                lvi.SubItems.Add(diaChi);
                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();
        }

        // ===== FORM LOAD =====
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        // ===== SỰ KIỆN CHỌN 1 DÒNG TRONG LISTVIEW =====
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maXB = lvi.SubItems[0].Text;

            HienThiThongTinNXBTheoMa(maXB);
        }

        // ===== HIỂN THỊ CHI TIẾT NXB THEO MÃ =====
        private void HienThiThongTinNXBTheoMa(string maXB)
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiChiTietNXB";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMaXB = new SqlParameter("@MaNXB", SqlDbType.Char);
            parMaXB.Value = maXB;
            sqlCmd.Parameters.Add(parMaXB);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";

            if (reader.Read())
            {
                txtMaXB.Text = reader.GetString(0);
                txtTenXB.Text = reader.GetString(1);
                txtDiaChi.Text = reader.GetString(2);
            }

            reader.Close();
        }
    }
}
