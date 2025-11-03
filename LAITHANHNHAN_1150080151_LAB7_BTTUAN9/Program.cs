using Lab7_HienThiDuLieu; // nếu FormMain nằm cùng namespace thì dòng này không cần
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAITHANHNHAN_1150080151_LAB7_BTTUAN9
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🔸 Chạy FormMain làm form khởi động chính
            Application.Run(new FormMain());
        }
    }
}
