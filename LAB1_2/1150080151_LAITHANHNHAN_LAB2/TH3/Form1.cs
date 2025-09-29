using System;
using System.Windows.Forms;

namespace TH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int so))
            {
                lsbDaySo.Items.Add(so);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
                lsbDaySo.Items[i] = Convert.ToInt32(lsbDaySo.Items[i]) + 2;
        }

        private void btnChonDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào!");
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào!");
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            else
                MessageBox.Show("Chưa chọn phần tử để xóa!");
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDay_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
