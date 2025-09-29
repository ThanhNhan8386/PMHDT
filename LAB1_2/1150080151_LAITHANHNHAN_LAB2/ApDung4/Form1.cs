using System;
using System.Windows.Forms;

namespace ApDung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo dữ liệu ban đầu
            lstMatHang.Items.AddRange(new object[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN"
            });
        }

        // Nút > : chuyển các phần tử được chọn sang lstDaChon
        private void btnChuyen1_Click(object sender, EventArgs e)
        {
            while (lstMatHang.SelectedItems.Count > 0)
            {
                var item = lstMatHang.SelectedItem;
                lstDaChon.Items.Add(item);
                lstMatHang.Items.Remove(item);
            }
        }

        // Nút >> : chuyển toàn bộ sang lstDaChon
        private void btnChuyenHet1_Click(object sender, EventArgs e)
        {
            lstDaChon.Items.AddRange(lstMatHang.Items);
            lstMatHang.Items.Clear();
        }

        // Nút < : chuyển các phần tử được chọn ngược lại sang lstMatHang
        private void btnChuyen2_Click(object sender, EventArgs e)
        {
            while (lstDaChon.SelectedItems.Count > 0)
            {
                var item = lstDaChon.SelectedItem;
                lstMatHang.Items.Add(item);
                lstDaChon.Items.Remove(item);
            }
        }

        // Nút << : chuyển toàn bộ ngược lại sang lstMatHang
        private void btnChuyenHet2_Click(object sender, EventArgs e)
        {
            lstMatHang.Items.AddRange(lstDaChon.Items);
            lstDaChon.Items.Clear();
        }
    }
}
