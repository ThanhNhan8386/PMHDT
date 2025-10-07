using System;
using System.Windows.Forms;

namespace QuanAnNhanhThanhNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ====== SỰ KIỆN CHỌN MÓN ĂN ======
        private void btnComChienTrung_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Cơm chiên trứng");
        }

        private void btnBanhMyOpLa_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Bánh mì ốp la");
        }

        private void btnCoca_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Coca");
        }

        private void btnLipton_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Lipton");
        }

        private void btnOcRangMuoi_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Ốc rang muối");
        }

        private void btnKhoaiTayChien_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Khoai tây chiên");
        }

        private void btn7up_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("7 up");
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Cam");
        }

        private void btnMyXaoHaiSan_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Mỳ xào hải sản");
        }

        private void btnCaVienChien_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Cá viên chiên");
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Pepsi");
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Cafe");
        }

        private void btnBugerBoNuong_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Buger bò nướng");
        }

        private void btnDuiGaRan_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Đùi gà rán");
        }

        private void btnBunBoHue_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add("Bún bò Huế");
        }

        // ====== NÚT XÓA ======
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
        }

        // ====== NÚT ORDER ======
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo");
            }
            else if (lstOrder.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn món nào!", "Thông báo");
            }
            else
            {
                string ban = cboBan.SelectedItem.ToString();
                MessageBox.Show($"Đã đặt món cho {ban}.", "Xác nhận");
            }
        }
    }
}
