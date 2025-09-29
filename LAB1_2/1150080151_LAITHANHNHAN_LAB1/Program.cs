using System;

namespace _1150080151_LAITHANHHAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Hình chữ nhật");
                Console.WriteLine("2. TH2 - Tìm số lớn hơn trong 2 số");
                Console.WriteLine("3. TH3 - Tìm số lớn nhất trong 3 số");
                Console.WriteLine("4. TH4 - Xác định số ngày trong tháng");
                Console.WriteLine("5. TH5 - Kiểm tra số nguyên n");
                Console.WriteLine("6. TH6 - Chu vi & diện tích HCN");
                Console.WriteLine("7. TH7 - Chu vi & diện tích tam giác");
                Console.WriteLine("8. TH8 - Giải phương trình bậc 2");
                Console.WriteLine("9. TH9 - Tính tổng mảng");
                Console.WriteLine("10. TH10 - Selection Sort từ file");
                Console.WriteLine("11. TH11 - Chèn phần tử vào mảng tăng dần");

                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: HinhChuNhat.Run(); break;
                    case 2: TH2.Run(); break;
                    case 3: TH3.Run(); break;
                    case 4: TH4.Run(); break;
                    case 5: TH5.Run(); break;
                    case 6: TH6.Run(); break;
                    case 7: TH7.Run(); break;
                    case 8: TH8.Run(); break;
                    case 9: TH9.Run(); break;
                    case 10: TH10.Run(); break;
                    case 11: TH11.Run(); break;

                    case 0: Console.WriteLine("Thoát chương trình."); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }
    }
}
