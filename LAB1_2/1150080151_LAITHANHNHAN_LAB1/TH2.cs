using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH2
    {
        public static void Run()
        {
            Console.WriteLine("=== TH2: Tìm số lớn hơn trong 2 số ===");
            Console.Write("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"Số lớn hơn là: {a}");
            else if (b > a)
                Console.WriteLine($"Số lớn hơn là: {b}");
            else
                Console.WriteLine("Hai số bằng nhau.");
        }
    }
}
