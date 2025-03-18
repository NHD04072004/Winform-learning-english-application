using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Model
{
    class Account
    {
        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool checkAdmin {  get; set; }
    }
}
