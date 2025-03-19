using HocTiengAnh.Adapter;
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
    public partial class Result: Form
    {
        Model.Result result = null;
        int MaTaiKhoan = 0;
        string MaBaiHoc = null;
        public Result(int sMaTaiKhoan, string sMaBaiHoc)
        {
            InitializeComponent();
            this.MaTaiKhoan = sMaTaiKhoan;
            this.MaBaiHoc = sMaBaiHoc;
            ResultAdapter adapter = new ResultAdapter(MaTaiKhoan, MaBaiHoc);
            result = adapter.GetResult();

            displayResult();
        }

        private void displayResult()
        {
            lblScore.Text = result.Score.ToString();
            lblSubmitTime.Text = result.ThoiGianNop.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu(MaBaiHoc);
            tc.ShowDialog();
        }
    }
}
