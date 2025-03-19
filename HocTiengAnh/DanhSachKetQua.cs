using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh
{
    public partial class DanhSachKetQua : Form
    {
        private string _hienNguoiDung;
        private string _tenBaiHoc;

        public DanhSachKetQua(string hiennguoidung)
        {
            InitializeComponent();
            _hienNguoiDung = hiennguoidung;
            btnHiennguoidung.Text = hiennguoidung;
            LoadDanhSachBaiHoc();
            LoadKetQuaBaiLam();
        }

        private void btnHiennguoidung_Click(object sender, EventArgs e)
        {
            //LoadDanhSachBaiHoc();
            //LoadKetQuaBaiLam();
        }

        // Hàm lấy danh sách bài học
        private void LoadDanhSachBaiHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("LayBaiHoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tentk", _hienNguoiDung);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        btnBaihoc1.Text = " ";
                        btnBaihoc2.Text = " ";
                        btnBaihoc3.Text = " ";
                        btnBaihoc4.Text = " ";

                        int index = 0;
                        while (reader.Read())
                        {
                            string baihoc = reader["sTenBaiHoc"].ToString();

                            if (index == 0) btnBaihoc1.Text = baihoc;
                            else if (index == 1) btnBaihoc2.Text = baihoc;
                            else if (index == 2) btnBaihoc3.Text = baihoc;
                            else if (index == 3) btnBaihoc4.Text = baihoc;

                            index++;
                        }
                    }
                }
            }
        }

        // Hàm lấy kết quả bài làm tất cả bài học
        private void LoadKetQuaBaiLam()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("LayKetQuaBaiLam", conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@tentk", _hienNguoiDung);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvKetquabailam.DataSource = table;
                    dgvKetquabailam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        // Hàm lấy kết quả bài làm của bài học được chọn
        private void LoadKetQuaBaiHoc(string tenBaiHoc)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("LayKetQuaBaiHoc", conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@tentk", _hienNguoiDung);
                    adapter.SelectCommand.Parameters.AddWithValue("@tenBaiHoc", tenBaiHoc);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvKetquabailam.DataSource = table;
                }
            }
        }

        // Sự kiện khi click vào từng bài học
        private void btnBaihoc1_Click(object sender, EventArgs e)
        {
            _tenBaiHoc = btnBaihoc1.Text;
            LoadKetQuaBaiHoc(_tenBaiHoc);
        }

        private void btnBaihoc2_Click(object sender, EventArgs e)
        {
            _tenBaiHoc = btnBaihoc2.Text;
            LoadKetQuaBaiHoc(_tenBaiHoc);
        }

        private void btnBaihoc3_Click(object sender, EventArgs e)
        {
            _tenBaiHoc = btnBaihoc3.Text;
            LoadKetQuaBaiHoc(_tenBaiHoc);
        }

        private void btnBaihoc4_Click(object sender, EventArgs e)
        {
            _tenBaiHoc = btnBaihoc4.Text;
            LoadKetQuaBaiHoc(_tenBaiHoc);
        }

        private void dgvKetquabailam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DsKhoaHoc dsKhoaHoc = new DsKhoaHoc(_hienNguoiDung);
            dsKhoaHoc.ShowDialog();
            this.Close();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu(_hienNguoiDung);
            trangChu.ShowDialog();
            this.Close();
        }
    }
}
