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
    public partial class AdminHocVien : Form
    {
        private string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        private DateTime lastClickTime = DateTime.MinValue;

        public AdminHocVien()
        {
            


            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKhoaHoc adminKhoaHocForm = new AdminKhoaHoc();
            adminKhoaHocForm.ShowDialog();
        }

        private void btnDSBaiHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBaiHoc adminBaiHocForm = new AdminBaiHoc();
            adminBaiHocForm.ShowDialog();
        }

        private void btnDSHocVien_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void LoadDSHocVien()
        {
            flpDSHocVien.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string query = "select iMaTK, sTenTK, sEmail, sMatKhau from tblTaiKhoan where bCheckAdmin = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maTK = (int)reader["iMaTK"];
                            string tenTK = reader["sTenTK"].ToString();
                            string email = reader["sEmail"].ToString();
                            string password = reader["sMatKhau"].ToString();

                            Button btnHocVien = new Button
                            {
                                Text = $"{tenTK}\n{email}",
                                Size = new Size(200, 50),
                                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                                BackColor = Color.White,
                                Margin = new Padding(5)
                            };

                            btnHocVien.Click += (s, ev) =>
                            {
                                string selectedMaTK = maTK.ToString();
                                string selectedTenTK = tenTK;
                                string selectedEmail = email;
                                string selectedPassword = password;


                                txtMaHocVien.Text = selectedMaTK;
                                txtTenHocVien.Text = selectedTenTK;
                                txtEmail.Text = selectedEmail;
                                txtPassword.Text = selectedPassword;
                            };


                            btnHocVien.Click += (s, ev) =>
                            {
                                DateTime now = DateTime.Now;
                                if ((now - lastClickTime).TotalMilliseconds <= SystemInformation.DoubleClickTime)
                                {
                                    AdminChiTietHocVien adminChiTietHocVien = new AdminChiTietHocVien(maTK, tenTK, email, password);
                                    adminChiTietHocVien.Show();
                                }
                                lastClickTime = now;
                            };


                            flpDSHocVien.Controls.Add(btnHocVien);
                        }
                    }
                }
            }
        }

        private void AdminHocVien_Load(object sender, EventArgs e)
        {
            LoadDSHocVien();
        }

        private void XoaHocVien(int maHocVien)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string nameProc = "sp_XoaNguoiDung";

                using (SqlCommand cmd = new SqlCommand(nameProc, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaTK", maHocVien);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Xóa học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maTK = Convert.ToInt32(txtMaHocVien.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaHocVien(maTK);
                LoadDSHocVien();
            }
            txtMaHocVien.Text = "";
            txtTenHocVien.Text = "";
        }

        private void SuaHocVien(int maTK, string tenTK, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_SuaHocVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaTK", maTK);
                    cmd.Parameters.AddWithValue("@sTenTK", tenTK);
                    cmd.Parameters.AddWithValue("@sEmail", email);
                    cmd.Parameters.AddWithValue("@sMatKhau", password);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maTK = Convert.ToInt32(txtMaHocVien.Text);
            string tenTK = txtTenHocVien.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            SuaHocVien(maTK, tenTK, email, password);
            LoadDSHocVien();
            txtMaHocVien.Text = "";
            txtTenHocVien.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private bool KiemTraMaHocVienTonTai(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM tblTaiKhoan WHERE sEmail = @sEmail";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sEmail", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
            }
        }

        private void ThemHocVien(string tenTK, string email, string pass)
        {
            if (KiemTraMaHocVienTonTai(email))
            {
                MessageBox.Show("Học viên này đã tồn tại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ThemHocVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTenTK", tenTK);
                    cmd.Parameters.AddWithValue("@sEmail", email);
                    cmd.Parameters.AddWithValue("@sMatKhau", pass);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenHocVien.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;

            ThemHocVien(tenTK, email, pass);
            LoadDSHocVien();
            txtMaHocVien.Text = "";
            txtTenHocVien.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
