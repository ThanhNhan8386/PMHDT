using System;
using System.Windows.Forms;

namespace ApDung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tìm USCLN (GCD)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // Hàm tìm BSCNN (LCM)
        private int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                if (rdbUSCLN.Checked)
                {
                    txtKetQua.Text = $"USCLN({a}, {b}) = {GCD(a, b)}";
                }
                else if (rdbBSCNN.Checked)
                {
                    txtKetQua.Text = $"BSCNN({a}, {b}) = {LCM(a, b)}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
