using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH4
    {
        public static void Run()
        {
            Console.WriteLine("=== TH4: Xác định số ngày trong tháng ===");

            Console.Write("Nhập năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Tháng {thang} năm {nam} có 31 ngày.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Tháng {thang} năm {nam} có 30 ngày.");
                    break;
                case 2:
                    if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                        Console.WriteLine($"Tháng 2 năm {nam} có 29 ngày (năm nhuận).");
                    else
                        Console.WriteLine($"Tháng 2 năm {nam} có 28 ngày.");
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ!");
                    break;
            }
        }
    }
}
