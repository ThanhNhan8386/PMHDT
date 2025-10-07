using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HienThiDanhSachSinhVien
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối CSDL (anh sửa lại tên server của mình nếu khác)
        private string strCon =
            @"Data Source=DESKTOP-KRIBTAK\MSSQLSERVER01;
              Initial Catalog=SinhVien;
              Integrated Security=True;
              Encrypt=False;";

        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Tạo lệnh truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                // 3️⃣ Thực thi truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();

                // Xóa dữ liệu cũ trên ListView trước khi nạp mới
                lsvList.Items.Clear();

                // 4️⃣ Đọc dữ liệu từng dòng và đưa lên ListView
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLop = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);
                    lsvList.Items.Add(lvi);
                }

                reader.Close();
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
