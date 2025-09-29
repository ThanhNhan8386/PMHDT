using System;
using System.IO;
using System.Linq;

namespace _1150080151_LAITHANHHAN
{
    internal class TH10
    {
        public static void Run()
        {
            Console.WriteLine("=== TH10: Selection Sort mảng từ file input_array.txt ===");

            string filePath = "input_array.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không tìm thấy file input_array.txt");
                return;
            }

            // Đọc dữ liệu từ file và chuyển thành mảng số nguyên
            string content = File.ReadAllText(filePath);
            int[] arr = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Console.WriteLine("Mảng ban đầu: " + string.Join(" ", arr));

            // Thuật toán Selection Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                // Đổi chỗ
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(" ", arr));
        }
    }
}
