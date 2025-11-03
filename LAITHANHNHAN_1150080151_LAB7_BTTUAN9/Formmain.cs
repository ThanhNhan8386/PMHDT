using System;
using System.Windows.Forms;
using Lab7_HienThiDuLieu;
using Lab7_ThemDuLieu;
using Lab7_ChinhSuaDuLieu;
using Lab7_XoaDuLieu;

namespace LAITHANHNHAN_1150080151_LAB7_BTTUAN9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }

    internal class Form1
    {
        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
