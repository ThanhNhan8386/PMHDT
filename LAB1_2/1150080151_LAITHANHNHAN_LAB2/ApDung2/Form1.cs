using System;
using System.Windows.Forms;

namespace ApDung2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi bấm nút số
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPassword.Text += btn.Text;
        }

        // Clear password
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        // Enter: kiểm tra password
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text.Trim();
            string nhom = "Không có";
            string ketqua = "Từ chối!";

            // Bảng password
            if (pwd == "1496" || pwd == "2673")
            {
                nhom = "Phát triển công nghệ";
                ketqua = "Chấp nhận!";
            }
            else if (pwd == "7462")
            {
                nhom = "Nghiên cứu viên";
                ketqua = "Chấp nhận!";
            }
            else if (pwd == "8884" || pwd == "3842" || pwd == "3383")
            {
                nhom = "Thiết kế mô hình";
                ketqua = "Chấp nhận!";
            }

            // Ghi log vào ListView
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());
            item.SubItems.Add(nhom);
            item.SubItems.Add(ketqua);
            lvLog.Items.Add(item);

            // Reset password
            txtPassword.Clear();
        }

        // RING: báo động
        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo động! Người lạ đang cố gắng vào phòng!",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
