using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TrangChu());
            Application.Run(new Dangnhap());
            //Application.Run(new Dangky());
            //Application.Run(new DSCauhoi());
            //Application.Run(new DanhSachKetQua());
        }
    }
}
