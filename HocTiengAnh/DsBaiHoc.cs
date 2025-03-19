﻿using System;
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
    public partial class DsBaiHoc : Form
    {
        private string str = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        private string tenTK;

        public DsBaiHoc(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            LoadKhoaHoc();
        }
        private void LoadKhoaHoc()
        {
            flpDSBaiHoc.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "dskhcb";
                        cmd.Parameters.AddWithValue("@tenTK", tenTK);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string smaKhoaHoc = reader["sMaKhoaHoc"].ToString();
                                string tenKhoaHoc = reader["sTenKhoaHoc"].ToString();

                                // Tạo button mới cho khóa học
                                Button btnKhoaHoc = new Button();
                                btnKhoaHoc.Text = tenKhoaHoc;
                                btnKhoaHoc.Tag = smaKhoaHoc; // Lưu ID khóa học để sử dụng sau này
                                btnKhoaHoc.Width = 250;
                                btnKhoaHoc.Height = 80;
                                btnKhoaHoc.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                                btnKhoaHoc.BackColor = Color.LightBlue;
                                btnKhoaHoc.Click += BtnKhoaHocCuaBan_Click;

                                // Thêm button vào FlowLayoutPanel
                                flpDSBaiHoc.Controls.Add(btnKhoaHoc);
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


        private void BtnKhoaHocCuaBan_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string maKhoaHoc = clickedButton.Tag.ToString();

                flpDSBaiHoc.Controls.Clear(); // Xóa các button cũ nếu có

                try
                {
                    using (SqlConnection conn = new SqlConnection(str))
                    {
                        conn.Open();
                        string query = "SELECT sMaBaiHoc, sTenBaiHoc FROM tblBaiHoc WHERE sMaKhoaHoc = @MaKhoaHoc";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string maBaiHoc = reader["sMaBaiHoc"].ToString();
                                    string tenBaiHoc = reader["sTenBaiHoc"].ToString();

                                    // Tạo button cho từng bài học
                                    Button btnBaiHoc = new Button();
                                    btnBaiHoc.Text = tenBaiHoc;
                                    btnBaiHoc.Tag = maBaiHoc; // Gán mã bài học vào Tag để dùng khi mở bài học
                                    btnBaiHoc.Width = 250;
                                    btnBaiHoc.Height = 80;
                                    btnBaiHoc.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                                    btnBaiHoc.BackColor = Color.LightBlue;
                                    btnBaiHoc.Click += BtnBaiHoc_Click; // Xử lý khi nhấn vào bài học

                                    // Thêm button vào FlowLayoutPanel
                                    flpDSBaiHoc.Controls.Add(btnBaiHoc);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách bài học: " + ex.Message);
                }


            }

        }

        private void BtnBaiHoc_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //string maBaiHoc = clickedButton.Tag.ToString();

            
            //DsCauHoi ch = new DsCauHoi(maBaiHoc);
            //ch.Show();
        }

        private void btnDSKHoaHoc_Click(object sender, EventArgs e)
        {

            
        }

        private void btnDSKH_user_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            
        }

        private void DsBaiHoc_Load(object sender, EventArgs e)
        {
            btnAccount.Text = tenTK;
        }
    }
}
