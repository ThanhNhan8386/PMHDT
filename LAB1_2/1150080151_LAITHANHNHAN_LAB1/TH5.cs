using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH5
    {
        public static void Run()
        {
            Console.WriteLine("=== TH5: Kiểm tra số nguyên n ===");

            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra chẵn/lẻ
            if (n % 2 == 0)
                Console.WriteLine($"a) {n} là số chẵn.");
            else
                Console.WriteLine($"a) {n} là số lẻ.");

            // Kiểm tra âm/không âm
            if (n < 0)
                Console.WriteLine($"b) {n} là số âm.");
            else
                Console.WriteLine($"b) {n} là số không âm.");
        }
    }
}
