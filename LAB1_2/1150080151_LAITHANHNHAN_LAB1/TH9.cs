using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH9
    {
        public static void Run()
        {
            Console.WriteLine("=== TH9: Tính tổng các phần tử trong mảng ===");

            Console.Write("Nhập số phần tử của mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử arr[{i}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                tong += arr[i];
            }

            Console.WriteLine("Tổng các phần tử trong mảng = " + tong);
        }
    }
}
