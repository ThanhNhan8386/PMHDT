using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH6
    {
        public static void Run()
        {
            Console.WriteLine("=== TH6: Chu vi & Diện tích Hình chữ nhật ===");

            double dai, rong;

            // Nhập chiều dài (phải > 0)
            do
            {
                Console.Write("Nhập chiều dài (>0): ");
                dai = Convert.ToDouble(Console.ReadLine());
                if (dai <= 0)
                {
                    Console.WriteLine("Chiều dài phải là số thực dương!");
                }
            } while (dai <= 0);

            // Nhập chiều rộng (phải > 0)
            do
            {
                Console.Write("Nhập chiều rộng (>0): ");
                rong = Convert.ToDouble(Console.ReadLine());
                if (rong <= 0)
                {
                    Console.WriteLine("Chiều rộng phải là số thực dương!");
                }
            } while (rong <= 0);

            // Tính chu vi & diện tích
            double chuVi = (dai + rong) * 2;
            double dienTich = dai * rong;

            // In kết quả
            Console.WriteLine($"Chu vi hình chữ nhật: {chuVi}");
            Console.WriteLine($"Diện tích hình chữ nhật: {dienTich}");
        }
    }
}
