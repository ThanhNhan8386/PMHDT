using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemSoLuongSinhVien
{
    public partial class Form1 : Form
    {
        private string strCon =
     @"Data Source=DESKTOP-KRIBTAK\MSSQLSERVER01;
      Initial Catalog=SinhVien;
      Integrated Security=True;
      Encrypt=False";

        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                int soLuongSV = (int)sqlCmd.ExecuteScalar();
                MessageBox.Show("Số lượng sinh viên là: " + soLuongSV.ToString());
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
