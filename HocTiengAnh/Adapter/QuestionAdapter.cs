using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using HocTiengAnh.Model;

namespace HocTiengAnh
{
    class QuestionAdapter
    {
        string cnnStr = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;
        string MaKetQua_AutoGenerate = null;
        public List<Model.Question> LoadQuestion(string MaBaiHoc)
        {
            List<Model.Question> questionList = new List<Model.Question>();
            Dictionary<string, Model.Question> questionMap = new Dictionary<string, Model.Question>();

            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_loadQuestion", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaBaiHoc", MaBaiHoc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string QuestionID = reader["sMaCauHoi"].ToString();

                            if (!questionMap.ContainsKey(QuestionID))
                            {
                                questionMap[QuestionID] = new Model.Question
                                {
                                    MaCauHoi = reader["sMaCauHoi"].ToString(),
                                    MaBaiHoc = reader["sMaBaiHoc"].ToString(),
                                    NoiDungCauHoi = reader["sNoiDungCauHoi"].ToString(),
                                    listAnswer = new List<Answer>()
                                };
                            }

                            Answer answer = new Answer
                            {
                                MaCauHoi = reader["sMaCauHoi"].ToString(),
                                MaDapAn = reader["sMaDapAn"].ToString(),
                                NoiDungDapAn = reader["sNoiDungDapAn"].ToString(),
                                DapAnDung = (bool)reader["bDapAnDung"]
                            };

                            questionMap[QuestionID].listAnswer.Add(answer);
                            
                        }
                    }
                }
            }   

            questionList.AddRange(questionMap.Values);
            return questionList;
        }
        public string autoGenerateMaKetQua()
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                string cnnStr = "SELECT TOP 1 sMaKetQua FROM tblBangKetQua order by sMaKetQua desc";
                using (SqlCommand cmd = new SqlCommand(cnnStr, cnn))
                {
                    var result = cmd.ExecuteScalar();
                    if(result != null)
                    {

                        return "KQ" + (int.Parse(result.ToString().Substring(2)) + 1).ToString();
                    }
                    else
                    {
                        return "KQ001";
                    }
                }
            }
        }
        public string autoGenerateMaTraLoi()
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                string query = "SELECT TOP 1 sMaTraLoi FROM tblBangTraLoi ORDER BY sMaTraLoi DESC";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int newId = int.Parse(result.ToString().Substring(2)) + 1;
                        return "TL" + newId.ToString("D3"); // D3 đảm bảo mã có dạng TL001, TL002, ...
                    }
                    else
                    {
                        return "TL001";
                    }
                }
            }
        }

        public void CreateResult(string MaTaiKhoan, string MaBaiHoc)
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_createResult", cnn))
                {
                    MaKetQua_AutoGenerate = autoGenerateMaKetQua();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKetQua", MaKetQua_AutoGenerate);
                    cmd.Parameters.Add("@MaTaiKhoan", MaTaiKhoan);
                    cmd.Parameters.Add("@MaBaiHoc", MaBaiHoc);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void CreateResultDetail(string MaKetQua, string MaCauHoi, string MaDapAn, bool DapAnDung)
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_createResultDetail", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKetQua", MaKetQua_AutoGenerate);
                    cmd.Parameters.Add("@MaTraLoi", autoGenerateMaTraLoi());
                    cmd.Parameters.Add("@MaCauHoi", MaCauHoi);
                    cmd.Parameters.Add("@MaDapAnTraLoi", MaDapAn);
                    cmd.Parameters.Add("@DapAnDung", DapAnDung);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void FinishTest(string MaKetQua, DateTime ThoiGianNop)
        {
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pr_finishTest", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKetQua", MaKetQua);
                    cmd.Parameters.Add("@ThoiGianNop", ThoiGianNop);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
