using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_HienThiDuLieu
{
    public partial class Formmain : Form
    {
        // 🔹 Chuỗi kết nối CSDL
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=D:\NAM4\PTMT\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\QuanLyBanSach.mdf;
Integrated Security=True";

        SqlConnection sqlCon = null;

        public Formmain()
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

        // 🔹 Sự kiện Click nút “Hiển thị danh sách”
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string sql = "SELECT * FROM NhaXuatBan";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "tblNhaXuatBan");
                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
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
