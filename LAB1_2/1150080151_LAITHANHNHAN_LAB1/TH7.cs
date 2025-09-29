using System;

namespace _1150080151_LAITHANHHAN
{
    internal class TH7
    {
        public static void Run()
        {
            Console.WriteLine("=== TH7: Tam giác - Chu vi & Diện tích ===");

            // Nhập 3 cạnh
            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiểm tra điều kiện tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                double chuVi = a + b + c;
                double p = chuVi / 2; // nửa chu vi
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Chu vi tam giác: {chuVi}");
                Console.WriteLine($"Diện tích tam giác: {dienTich}");
            }
            else
            {
                Console.WriteLine("Ba cạnh nhập vào KHÔNG tạo thành tam giác!");
            }
        }
    }
}
