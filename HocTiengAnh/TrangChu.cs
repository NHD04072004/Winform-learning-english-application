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
        private string tenTK;
        public TrangChu(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            btnAccount.Text = tenTK;
            lblWelcome.Text = $"Chào mừng: {tenTK}";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DsKhoaHoc dskh = new DsKhoaHoc(tenTK);
            dskh.ShowDialog();
        }

        private void btnDSKH_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            DsBaiHoc dsbh = new DsBaiHoc(tenTK);
            dsbh.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap login = new Dangnhap();
            login.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachKetQua dskq = new DanhSachKetQua(tenTK);
            dskq.ShowDialog();
            this.Close();
        }
    }
}
