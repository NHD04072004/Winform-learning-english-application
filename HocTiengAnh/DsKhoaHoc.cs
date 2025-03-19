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
    public partial class DsKhoaHoc : Form
    {
        private string tenTK;
        public DsKhoaHoc(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
        }
        private string str = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

        // hiện các button Khóa Học
        private void LoadKhoaHoc()
        {
            // Xóa các button cũ trong flpDSKhoaHoc
            flpDSKhoaHoc.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "SELECT sMaKhoaHoc, sTenKhoaHoc FROM tblKhoaHoc";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maKhoaHoc = reader["sMaKhoaHoc"].ToString();
                                string tenKhoaHoc = reader["sTenKhoaHoc"].ToString();

                                Button btnKhoaHoc = new Button();
                                btnKhoaHoc.Text = tenKhoaHoc;
                                btnKhoaHoc.Tag = maKhoaHoc;
                                btnKhoaHoc.Width = 250;
                                btnKhoaHoc.Height = 80;
                                btnKhoaHoc.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                                btnKhoaHoc.BackColor = Color.LightBlue;
                                btnKhoaHoc.Click += BtnKhoaHoc_Click;

                                // Thêm button vào FlowLayoutPanel
                                flpDSKhoaHoc.Controls.Add(btnKhoaHoc);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khóa học: " + ex.Message);
            }
        }


        //
        private void BtnKhoaHoc_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string maKhoaHoc = clickedButton.Tag.ToString();
                clickedButton.Click += btnDangKy_Click;
            }

        }

        private void btnDSKHoaHoc_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DsKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadKhoaHoc();
            btnAccount.Text = tenTK;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string maKhoaHoc = clickedButton.Tag.ToString();
            int maTaiKhoan = 6;

            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    // Kiểm tra xem người dùng đã đăng ký khóa học chưa
                    string checkQuery = "SELECT COUNT(*) FROM tblDanhSachKhoaHocDangKy WHERE iMaTK = @MaTaiKhoan AND sMaKhoaHoc = @MaKhoaHoc";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                        checkCmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0) // Nếu chưa đăng ký, thì thêm mới
                        {
                            string insertQuery = "INSERT INTO tblDanhSachKhoaHocDangKy (iMaTK, sMaKhoaHoc) VALUES (@MaTaiKhoan, @MaKhoaHoc)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                                insertCmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
                                insertCmd.ExecuteNonQuery();
                            }

                            // Cập nhật giao diện
                            clickedButton.Text = "Đã đăng ký";
                            clickedButton.Enabled = false;
                            MessageBox.Show("Bạn đã đăng ký thành công khóa học!");
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã đăng ký khóa học này rồi!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký khóa học: " + ex.Message);
            }
        }



        private void LoadKhoaHocDK()
        {
            // Xóa các button cũ trong flpDSKhoaHoc
            flpDSKhoaHoc.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "SELECT sMaKhoaHoc, sTenKhoaHoc FROM tblDanhSachKhoaHocDangKy"; // Điều chỉnh truy vấn phù hợp với database của bạn
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maKhoaHoc = reader["sMaKhoaHoc"].ToString();
                                string tenKhoaHoc = reader["sTenKhoaHoc"].ToString();

                                // Tạo button mới cho khóa học
                                Button btnKhoaHoc = new Button();
                                btnKhoaHoc.Text = tenKhoaHoc;
                                btnKhoaHoc.Tag = maKhoaHoc; // Lưu ID khóa học để sử dụng sau này
                                btnKhoaHoc.Width = 250;
                                btnKhoaHoc.Height = 80;
                                btnKhoaHoc.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                                btnKhoaHoc.BackColor = Color.LightBlue;
                                btnKhoaHoc.Click += BtnKhoaHocDK_Click;

                                // Thêm button vào FlowLayoutPanel
                                flpDSKhoaHoc.Controls.Add(btnKhoaHoc);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khóa học: " + ex.Message);
            }
        }

        private void BtnKhoaHocDK_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            //if (clickedButton != null)
            //{
              //  string maKhoaHoc = clickedButton.Tag.ToString();

                // Mở form danh sách bài học và truyền mã khóa học vào
               // DsBaiHoc ds = new DsBaiHoc(maKhoaHoc);
                //ds.Show();
                //this.Hide();
            //}

        }

        private void btnDSKH_user_Click(object sender, EventArgs e)
        {
            DsBaiHoc ds = new DsBaiHoc();
            ds.ShowDialog();
        }
    }
}
