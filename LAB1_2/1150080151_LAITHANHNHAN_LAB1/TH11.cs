using System;
using System.Linq;

namespace _1150080151_LAITHANHHAN
{
    internal class TH11
    {
        public static void Run()
        {
            Console.WriteLine("=== TH11: Chèn phần tử vào mảng tăng dần ===");

            // Nhập mảng (đã sắp xếp sẵn)
            Console.Write("Nhập số phần tử của mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Mảng ban đầu: " + string.Join(" ", arr));

            // Nhập số cần chèn
            Console.Write("Nhập số nguyên cần chèn: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Tìm vị trí để chèn
            int[] newArr = new int[n + 1];
            int pos = 0;
            while (pos < n && arr[pos] < x)
            {
                newArr[pos] = arr[pos];
                pos++;
            }

            // Chèn x vào vị trí đúng
            newArr[pos] = x;

            // Dời các phần tử còn lại
            for (int i = pos; i < n; i++)
            {
                newArr[i + 1] = arr[i];
            }

            Console.WriteLine("Mảng sau khi chèn: " + string.Join(" ", newArr));
        }
    }
}
