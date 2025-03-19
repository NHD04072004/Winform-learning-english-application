using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HocTiengAnh
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        public string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int getTotalStudents()
        {
            int total = 0;
            string query = "select count(*) from tblTaiKhoan where bCheckAdmin = 0";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        total = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi kết nối: ", e.Message);
                }
            }
            return total;
        }

        private int getTotalKQ()
        {
            int total = 0;
            string query = "select count(*) from tblBangKetQua";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        total = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi kết nối: ", e.Message);
                }
            }
            return total;
        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKhoaHoc adminKhoaHocForm = new AdminKhoaHoc();
            adminKhoaHocForm.ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblTongHV.Text = getTotalStudents().ToString();
            lblTongKQ.Text = getTotalKQ().ToString();
        }

        private void btnDSBaiHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBaiHoc adminBaiHocForm = new AdminBaiHoc();
            adminBaiHocForm.ShowDialog();
        }

        private void btnDSHocVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHocVien adminHocVienForm = new AdminHocVien();
            adminHocVienForm.ShowDialog();
        }

        private void dgvDSKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
