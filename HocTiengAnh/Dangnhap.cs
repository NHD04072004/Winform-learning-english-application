using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HocTiengAnh
{
    public partial class Dangnhap : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            if (cbHienthimatkhau.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void cbHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHienthimatkhau.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = tbUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                errorProvider.SetError(tbUsername, "Tên đăng nhập không được để trống!");
                return;
            }
            if(username.All(char.IsLetterOrDigit) == false)
            {
                errorProvider.SetError(tbUsername, "Tên đăng nhập không chứa ký tự đặc biệt!");
                return;
            }
            errorProvider.SetError(tbUsername, "");
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(tbPassword, "Mật khẩu không được để trống!");
                return;
            }
            if(password.Contains(" "))
            {
                errorProvider.SetError(tbPassword, "Mật khẩu không chứa khoảng trắng!");
                return;
            }
            errorProvider.SetError(tbPassword, "");
        }

        private int Check_login(string username, string password, out bool isAdmin)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh_Toan"].ConnectionString;
            int ktr = -1;
            isAdmin = false;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("check_login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stentk", username);
                    cmd.Parameters.AddWithValue("@smatkhau", password);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ktr = reader.GetInt32(0);
                            if (!reader.IsDBNull(1))
                            {
                                isAdmin = reader.GetBoolean(1);
                            }
                        }
                    }
                }
            }
            return ktr;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lbThongbaoloi.Text = "Vui lòng nhập đầy đủ thông tin!";
                return;
            }

            bool isAdmin;
            int ktr = Check_login(username, password, out isAdmin);

            if (ktr == 1)
            {
                this.Hide();

                if (isAdmin)
                {
                    // Nếu là admin, mở giao diện Admin
                    AdminHome adminHome = new AdminHome();
                    adminHome.ShowDialog();
                }
                else
                {
                    // Nếu là user, mở giao diện User
                    TrangChu trangChu = new TrangChu();
                    trangChu.ShowDialog();
                }

                this.Close();
            }
            else if (ktr == 0)
            {
                lbThongbaoloi.Text = "Mật khẩu không đúng!";
            }
            else if (ktr == -1)
            {
                lbThongbaoloi.Text = "Tài khoản này không tồn tại!";
            }
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangky dangky = new Dangky();
            dangky.ShowDialog();
            this.Close();
        }

    }
}
