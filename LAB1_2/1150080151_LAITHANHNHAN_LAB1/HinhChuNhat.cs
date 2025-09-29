using System;

namespace _1150080151_LAITHANHHAN
{
    internal class HinhChuNhat
    {
        public static void Run()
        {
            // Nhập dữ liệu
            Console.Write("Nhập vào chiều dài: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập vào chiều rộng: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Tính chu vi và diện tích
            double chuVi = (a + b) * 2;
            double dienTich = a * b;

            // Hiển thị kết quả
            Console.WriteLine("Chu vi là: " + chuVi);
            Console.WriteLine("Diện tích là: " + dienTich);

            // Giữ màn hình console
            Console.ReadKey();
        }
    }
}
