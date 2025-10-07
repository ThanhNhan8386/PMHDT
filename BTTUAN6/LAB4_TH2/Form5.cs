using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApDung_HienThiSinhVienTheoLop
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Lấy danh sách lớp
                SqlCommand sqlCmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                // 3️⃣ Đưa dữ liệu lớp vào ListBox
                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);
                    // Hiển thị cả tên lớp và mã lớp
                    lsbDSLop.Items.Add($"{tenLop} - {maLop}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void lsbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDSLop.SelectedItem == null)
                return;

            try
            {
                // 1️⃣ Mở lại kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Lấy mã lớp được chọn
                string selected = lsbDSLop.SelectedItem.ToString();
                string maLop = selected.Substring(selected.LastIndexOf('-') + 1).Trim();

                // 3️⃣ Tạo truy vấn lấy sinh viên theo mã lớp
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT MaSV, TenSV, GioiTinh, QueQuan FROM SinhVien WHERE MaLop = @maLop";
                sqlCmd.Parameters.AddWithValue("@maLop", maLop);
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                // 4️⃣ Xóa dữ liệu cũ và hiển thị mới
                lsvSinhVien.Items.Clear();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string queQuan = reader.GetString(3);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(queQuan);
                    lsvSinhVien.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sinh viên: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
