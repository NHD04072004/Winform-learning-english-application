using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using HocTiengAnh.Model;

namespace HocTiengAnh.Adapter
{
    class ResultAdapter
    {
        Account account = new Account();
        int MaTaiKhoan = 0;
        string MaBaiHoc = null;

        public ResultAdapter(int MaTaiKhoan, string sMaBaiHoc)
        {
            this.MaTaiKhoan = MaTaiKhoan;
            this.MaBaiHoc = sMaBaiHoc;
        }

        string cnnStr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        public Model.Result GetResult()
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                
                using (SqlCommand cmd = new SqlCommand("pr_getResult", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaTK", MaTaiKhoan);
                    cmd.Parameters.Add("@MaBaiHoc", MaBaiHoc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Model.Result result = new Model.Result
                            {
                                MaKetQua = reader["sMaKetQua"].ToString(),
                                MaTaiKhoan = Convert.ToInt32(reader["iMaTK"]),
                                MaBaiHoc = reader["sMaBaiHoc"].ToString(),
                                ThoiGianNop = reader["dThoiGianNop"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["dThoiGianNop"]),
                                Score = reader["fDiem"] == DBNull.Value ? 0.0f : Convert.ToSingle(reader["fDiem"])
                            };

                            return (Model.Result)result;
                        }


                    }

                    cnn.Close();
                    
                }
            }
            return null;
        }
    }
}
