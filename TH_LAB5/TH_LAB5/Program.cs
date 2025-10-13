using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_LAB5
{
    internal static class Program
    {
        /// <summary>
        ///     Điểm khởi đầu của chương trình.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Bật visual style cho WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ Chạy form chính (Formmain) thay vì Form1
            Application.Run(new Formmain());
        }
    }
}
