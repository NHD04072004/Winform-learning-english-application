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
    public partial class Dangky : Form
    {
        ErrorProvider errorProvider =  new ErrorProvider();
        public Dangky()
        {
            InitializeComponent();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            if (cbHienthimatkhau.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbXacnhanPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbXacnhanPassword.PasswordChar = '*';
            }
        }

        private void cbHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienthimatkhau.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbXacnhanPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbXacnhanPassword.PasswordChar = '*';
            }
        }

private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
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
            if (username.All(char.IsLetterOrDigit) == false)
            {
                errorProvider.SetError(tbUsername, "Tên đăng nhập không chữa ký tự đặc biệt!");
                return;
            }
            errorProvider.SetError(tbUsername, "");
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Focus();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                errorProvider.SetError(tbEmail, "Email không được để trống!");
                return;
            }
            errorProvider.SetError(tbEmail, "");
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
            if (password.Contains(" "))
            {
                errorProvider.SetError(tbPassword, "Mật khẩu không chứa khoảng trắng!");
                return;
            }
            errorProvider.SetError(tbPassword, "");
        }

        private void lblXacnhanPassword_Click(object sender, EventArgs e)
        {
            tbXacnhanPassword.Focus();
        }

        private void tbXacnhanPassword_Validating(object sender, CancelEventArgs e)
        {
            string xacnhanpassword = tbXacnhanPassword.Text.Trim();
            if (string.IsNullOrEmpty(xacnhanpassword))
            {
                errorProvider.SetError(tbXacnhanPassword, "Mật khẩu không được để trống!");
                return;
            }
            if (xacnhanpassword.Contains(" "))
            {
                errorProvider.SetError(tbXacnhanPassword, "Mật khẩu không chứa khoảng trắng!");
                return;
            }
            errorProvider.SetError(tbXacnhanPassword, "");
        }

        private int Check_login(string username, string password)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh_Toan"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("check_login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stentk", username);
                    cmd.Parameters.AddWithValue("@smatkhau", password);

                    conn.Open();

                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string xacnhanpassword = tbXacnhanPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lbThongbaoloi.Text = "Vui lòng nhập đầy đủ thông tin!";
                return;
            }

            int ktr = Check_login(username, password);

            if(ktr != 0)
            {
                if (xacnhanpassword == password)
                {
                    string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh_Toan"].ConnectionString;

                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("insert_data_login", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@stentk", username);
                            cmd.Parameters.AddWithValue("@semail", email);
                            cmd.Parameters.AddWithValue("@smatkhau", password);

                            int check = cmd.ExecuteNonQuery();

                            if (check > 0)
                            {
                                lbThongbaoloi.Text = "Đăng ký thành công!";
                            }
                            else
                            {
                                lbThongbaoloi.Text = "Đăng ký không thành công!";
                            }
                        }
                    }
                }
                else
                {
                    lbThongbaoloi.Text = "Mật khẩu xác nhận chưa chính xác!";
                }
            }
            else
            {
                lbThongbaoloi.Text = "Tài khoản này đã tồn tại";
            }
            
        }

        

        
    }
}
