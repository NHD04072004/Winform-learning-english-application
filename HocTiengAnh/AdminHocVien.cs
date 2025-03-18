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
    public partial class AdminHocVien : Form
    {
        public AdminHocVien()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            AdminKhoaHoc adminKhoaHocForm = new AdminKhoaHoc();
            adminKhoaHocForm.Show();
            this.Hide();
        }

        private void btnDSBaiHoc_Click(object sender, EventArgs e)
        {
            AdminBaiHoc adminBaiHocForm = new AdminBaiHoc();
            adminBaiHocForm.Show();
            this.Hide();
        }

        private void btnDSHocVien_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
