using System;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                errorProvider1.SetError(txtCustomer, "Tên khách hàng không được để trống!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCustomer, "");
            }

            int tongTien = 0;

            if (chkCaoRang.Checked) tongTien += 50000;
            if (chkTayTrang.Checked) tongTien += 100000;
            if (chkHanRang.Checked) tongTien += (int)numHanRang.Value * 100000;
            if (chkBeRang.Checked) tongTien += (int)numBeRang.Value * 10000;
            if (chkBocRang.Checked) tongTien += (int)numBocRang.Value * 1000000;

            MessageBox.Show($"Khách hàng: {txtCustomer.Text}\nTổng tiền: {tongTien:#,##0} đ",
                "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
