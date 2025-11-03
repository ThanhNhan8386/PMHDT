using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_XoaDuLieu
{
    public partial class Form4 : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=D:\NAM4\PTMT\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\LAITHANHNHAN_1150080151_LAB7_BTTUAN9\QuanLyBanSach.mdf;
Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNXB.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            string maNXB = dgvNXB.CurrentRow.Cells["MaNXB"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa Mã NXB: {maNXB}?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi();
                    string sql = "DELETE FROM NhaXuatBan WHERE MaNXB=@MaNXB";
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    cmd.Parameters.AddWithValue("@MaNXB", maNXB);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!");
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
}
