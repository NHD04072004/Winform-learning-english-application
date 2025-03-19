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

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            DsKhoaHoc dskh = new DsKhoaHoc();
            dskh.Show();
            this.Hide();
        }

        private void btnDSKH_user_Click(object sender, EventArgs e)
        {
            int maTK = 6;
            DsBaiHoc dsbh = new DsBaiHoc(maTK);
            dsbh.Show();
            this.Hide();
        }
    }
}
