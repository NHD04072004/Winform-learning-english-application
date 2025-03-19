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
    public partial class AdminKhoaHoc : Form
    {
        public AdminKhoaHoc()
        {
            InitializeComponent();
        }
        private string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        private DateTime lastClickTime = DateTime.MinValue;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
        
        private void AdminKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadDSKhoaHoc();
        }
        private void XoaKhoaHoc(string maKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string nameProc = "pr_DeleteCourse";

                using (SqlCommand cmd = new SqlCommand(nameProc, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraMaKhoaHocTonTai0(string maKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM tblKhoaHoc WHERE sMaKhoaHoc = @sMaKhoaHoc and bIsDeleted = 0";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
            }
        }
        private bool KiemTraMaKhoaHocTonTai1(string maKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM tblKhoaHoc WHERE sMaKhoaHoc = @sMaKhoaHoc and bIsDeleted = 1";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
            }
        }

        private void ThemKhoaHoc(string maKhoaHoc, string tenKhoaHoc)
        {
            if (KiemTraMaKhoaHocTonTai0(maKhoaHoc))
            {
                MessageBox.Show("Khóa học này đã tồn tại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                if (KiemTraMaKhoaHocTonTai1(maKhoaHoc))
                {
                    using (SqlCommand cmd = new SqlCommand("pr_AddCourseWithExistID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                        cmd.Parameters.AddWithValue("@sTenKhoaHoc", tenKhoaHoc);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("pr_AddCourse", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                        cmd.Parameters.AddWithValue("@sTenKhoaHoc", tenKhoaHoc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SuaKhoaHoc(string maKhoaHoc, string tenKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_SuaCourse", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaKhoaHoc", maKhoaHoc);
                    cmd.Parameters.AddWithValue("@sTenKhoaHoc", tenKhoaHoc);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDSKhoaHoc()
        {
            flpDSKhoaHoc.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string query = "select sMaKhoaHoc, sTenKhoaHoc from tblKhoaHoc where bIsDeleted = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maKhoaHoc = reader["sMaKhoaHoc"].ToString();
                            string tenKhoaHoc = reader["sTenKhoaHoc"].ToString();

                            Button btnKhoaHoc = new Button
                            {
                                Text = $"{tenKhoaHoc}",
                                Size = new Size(200, 50),
                                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                                BackColor = Color.White,
                                Margin = new Padding(5)
                            };

                            btnKhoaHoc.Click += (s, ev) =>
                            {
                                txtMaKhoaHoc.Text = maKhoaHoc;
                                txtTenKhoaHoc.Text = tenKhoaHoc;
                            };

                            btnKhoaHoc.Click += (s, ev) =>
                            {
                                DateTime now = DateTime.Now;
                                if ((now - lastClickTime).TotalMilliseconds <= SystemInformation.DoubleClickTime)
                                {
                                    this.Hide();
                                    AdminBaiHoc adminBaiHoc = new AdminBaiHoc(maKhoaHoc);
                                    adminBaiHoc.ShowDialog();
                                }
                                lastClickTime = now;
                            };

                            flpDSKhoaHoc.Controls.Add(btnKhoaHoc);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaKhoaHoc = txtMaKhoaHoc.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaKhoaHoc(sMaKhoaHoc);
                LoadDSKhoaHoc();
            }
            txtMaKhoaHoc.Text = "";
            txtTenKhoaHoc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoaHoc = txtMaKhoaHoc.Text;
            string tenKhoaHoc = txtTenKhoaHoc.Text;

            ThemKhoaHoc(maKhoaHoc, tenKhoaHoc);
            LoadDSKhoaHoc();
            txtMaKhoaHoc.Text = "";
            txtTenKhoaHoc.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaKhoaHoc(txtMaKhoaHoc.Text, txtTenKhoaHoc.Text);
            LoadDSKhoaHoc();
            txtMaKhoaHoc.Text = "";
            txtTenKhoaHoc.Text = "";
        }
    }
}
