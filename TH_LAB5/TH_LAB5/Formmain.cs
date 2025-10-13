using System;
using System.Windows.Forms;

namespace TH_LAB5
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            // Mở form KHÔNG dùng Parameter
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            // Mở form CÓ dùng Parameter
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
