using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HocTiengAnh
{
    public partial class AdminChiTietHocVien : Form
    {
        string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        int MaHocVien = 0;
        string TenTaiKhoan = null;
        string Email = null;
        string MatKhau = null;
        public AdminChiTietHocVien(int MaHocVien, string TenTaiKhoan, string Email, string MatKhau)
        {
            InitializeComponent();
            this.MaHocVien = MaHocVien;
            this.TenTaiKhoan = TenTaiKhoan;
            this.Email = Email;
            this.MatKhau = MatKhau;

            txtMaHocVien.Text = MaHocVien.ToString();
            txtTenHocVien.Text = TenTaiKhoan.ToString();
            txtEmail.Text = Email.ToString();
            txtPassword.Text = MatKhau.ToString();
            load_dgvKetQuaHocVien(MaHocVien);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_dgvKetQuaHocVien(int maHocVien)
        {
            using (SqlConnection cnn = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM tblBangKetQua WHERE iMaTK = @MaHocVien";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaHocVien", maHocVien);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cnn.Open();
                    da.Fill(dt);
                    cnn.Close();

                    dgvKetQuaHocVien.DataSource = dt;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KetQuaHocVien report = new KetQuaHocVien(MaHocVien);
            report.Show();
            this.Hide();
        }
    }
}
