using System;
using System.Windows.Forms;
using DemSoLuongSinhVien;
using TruyVan1Dong;
using HienThiDanhSachSinhVien;
using HienThiDanhSachLop;
using ApDung_HienThiSinhVienTheoLop;

namespace LAB4_TH2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form 1
            Application.Run(new DemSoLuongSinhVien.Form1());

            // Sau khi đóng form 1 thì chạy form 2
            Application.Run(new TruyVan1Dong.Form1());

            // Sau khi đóng form 2 thì chạy form 3
            Application.Run(new HienThiDanhSachSinhVien.Form1());

            Application.Run(new HienThiDanhSachLop.Form1());
            Application.Run(new ApDung_HienThiSinhVienTheoLop.Form1());
        }
    }
}
