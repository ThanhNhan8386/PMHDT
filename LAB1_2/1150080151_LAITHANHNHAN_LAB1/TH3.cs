using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH3
    {
        public static void Run()
        {
            Console.WriteLine("=== TH3: Tìm số lớn nhất trong 3 số ===");

            Console.Write("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"Số lớn nhất là: {max}");
        }
    }
}
