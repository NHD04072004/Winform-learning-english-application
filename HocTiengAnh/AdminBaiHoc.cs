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
    public partial class AdminBaiHoc : Form
    {
        private string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        private string maKhoaHoc;
        public AdminBaiHoc()
        {
            InitializeComponent();
        }
        public AdminBaiHoc(string maKhoaHoc)
        {
            InitializeComponent();
            this.maKhoaHoc = maKhoaHoc;

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
            this.Refresh();
        }

        private void btnDSHocVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHocVien adminHocVienForm = new AdminHocVien();
            adminHocVienForm.ShowDialog();
        }
        private void LoadDSBaiHoc()
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string query = "select sMaBaiHoc, sTenBaiHoc from tblBaiHoc where bIsDeleted = 0 AND sMaKhoaHoc = @MaKhoaHoc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maBaiHoc = reader["sMaBaiHoc"].ToString();
                            string tenBaiHoc = reader["sTenBaiHoc"].ToString();

                            Button btnKhoaHoc = new Button
                            {
                                Text = $"{tenBaiHoc}",
                                Size = new Size(200, 50),
                                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                                BackColor = Color.White,
                                Margin = new Padding(5)
                            };

                            btnKhoaHoc.Click += (s, ev) =>
                            {
                                txtMaBaiHoc.Text = maBaiHoc;
                                txtTenBaiHoc.Text = maBaiHoc;
                            };

                            flowLayoutPanel1.Controls.Add(btnKhoaHoc);
                        }
                    }
                }
            }
        }

        private void AdminBaiHoc_Load(object sender, EventArgs e)
        {
            LoadDSBaiHoc();
        }

        private void XoaBaiHoc(string maBaiHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string nameProc = "pr_DeleteBaiHoc";

                using (SqlCommand cmd = new SqlCommand(nameProc, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaBaiHoc", maBaiHoc);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Xóa bài học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaKhoaHoc = txtMaBaiHoc.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bài học này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaBaiHoc(sMaKhoaHoc);
                LoadDSBaiHoc();
            }
            txtMaBaiHoc.Text = "";
        }

        private void SuaBaiHoc(string maBaiHoc, string tenBaiHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_SuaBaiHoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaBaiHoc", maBaiHoc);
                    cmd.Parameters.AddWithValue("@sTenBaiHoc", tenBaiHoc);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaBaiHoc(txtMaBaiHoc.Text, txtTenBaiHoc.Text);
            LoadDSBaiHoc();
        }

        private bool KiemTraMaBaiHocTonTai0(string maKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM tblBaiHoc WHERE sMaBaiHoc = @sMaBaiHoc and bIsDeleted = 0";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sMaBaiHoc", maKhoaHoc);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
            }
        }
        private bool KiemTraMaBaiHocTonTai1(string maKhoaHoc)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM tblBaiHoc WHERE sMaBaiHoc = @sMaBaiHoc and bIsDeleted = 1";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sMaBaiHoc", maKhoaHoc);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
            }
        }

        private void ThemBaiHoc(string maBaiHoc, string tenbaiHoc)
        {
            if (KiemTraMaBaiHocTonTai0(maBaiHoc))
            {
                MessageBox.Show("Bài học đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                if (KiemTraMaBaiHocTonTai1(maBaiHoc))
                {
                    using (SqlCommand cmd = new SqlCommand("pr_AddBaiHocWithExistID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaBaiHoc", maBaiHoc);
                        cmd.Parameters.AddWithValue("@sTenBaiHoc", tenbaiHoc);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("pr_AddBaiHoc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaBaiHoc", maBaiHoc);
                        cmd.Parameters.AddWithValue("@sTenBaiHoc", tenbaiHoc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaBaiHoc.Text = "";
            txtTenBaiHoc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maBaiHoc = txtMaBaiHoc.Text;
            string tenBaiHoc = txtTenBaiHoc.Text;

            ThemBaiHoc(maBaiHoc, tenBaiHoc);
            LoadDSBaiHoc();
        }
    }
}
