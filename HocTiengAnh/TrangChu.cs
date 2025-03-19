using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            btnAccount.Text = Adapter.SessionManager.Instance.CurrentAccount.TenTaiKhoan;
            lblWelcome.Text = $"Chào mừng: {Adapter.SessionManager.Instance.CurrentAccount.TenTaiKhoan}";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            DsKhoaHoc dskh = new DsKhoaHoc(Adapter.SessionManager.Instance.CurrentAccount.TenTaiKhoan);
            dskh.ShowDialog();
        }

        private void btnDSKH_user_Click(object sender, EventArgs e)
        {
            DsBaiHoc dsbh = new DsBaiHoc();
            dsbh.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Dangnhap login = new Dangnhap();
            login.ShowDialog();
            this.Hide();
        }
    }
}
