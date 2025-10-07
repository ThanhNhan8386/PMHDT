using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HienThiDanhSachLop
{
    public partial class Form1 : Form
    {
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

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Lấy tên khoa từ TextBox
                string tenKhoa = txtNhapTenKhoa.Text.Trim();
                string maKhoa = "";

                if (tenKhoa == "Công nghệ thông tin")
                    maKhoa = "CNTT";
                else if (tenKhoa == "Cơ khí")
                    maKhoa = "CK";
                else if (tenKhoa == "Điện tử")
                    maKhoa = "DT";
                else if (tenKhoa == "Kinh tế")
                    maKhoa = "KT";
                else
                {
                    MessageBox.Show("Tên khoa không hợp lệ!");
                    return;
                }

                // 3️⃣ Tạo đối tượng truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM Lop WHERE MaKhoa = @maKhoa";
                sqlCmd.Connection = sqlCon;

                // 4️⃣ Thêm tham số
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", SqlDbType.Char);
                parMaKhoa.Value = maKhoa;
                sqlCmd.Parameters.Add(parMaKhoa);

                // 5️⃣ Thực thi truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();

                // Xóa dữ liệu cũ trước khi hiển thị mới
                lsvDanhSach.Items.Clear();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);

                    ListViewItem lvi = new ListViewItem(tenLop);
                    lvi.SubItems.Add(maLop);
                    lsvDanhSach.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
