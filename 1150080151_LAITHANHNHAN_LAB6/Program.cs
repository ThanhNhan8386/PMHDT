using System;
using System.Windows.Forms;

namespace QuanLyNXB
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo 2 form
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            // Hiển thị cả 2 form
            f1.Show();
            f2.Show();
            f3.Show();
            f4.Show();

            // Giữ chương trình chạy đến khi Form1 đóng
            Application.Run(f1);
        }
    }
}
