using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TruyVan1Dong
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối CSDL (anh thay tên server nếu khác)
        private string strCon =
            @"Data Source=DESKTOP-KRIBTAK\MSSQLSERVER01;
        Initial Catalog=SinhVien;
        Integrated Security=True;
        Encrypt=False";


        // Đối tượng kết nối
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Lấy mã sinh viên nhập vào
                string maSV = txtNhapMaSV.Text.Trim();

                // 3️⃣ Tạo truy vấn SQL
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";
                sqlCmd.Parameters.AddWithValue("@MaSV", maSV);
                sqlCmd.Connection = sqlCon;

                // 4️⃣ Thực thi truy vấn và đọc dữ liệu
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenSV.Text = reader.GetString(1);
                    txtGioiTinh.Text = reader.GetString(2);
                    txtNgaySinh.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    txtQueQuan.Text = reader.GetString(4);
                    txtMaLop.Text = reader.GetString(5);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã " + maSV);
                }

                reader.Close(); // đóng DataReader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // 5️⃣ Đóng kết nối
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
