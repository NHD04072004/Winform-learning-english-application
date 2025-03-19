using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using System.Data.SqlClient;

namespace HocTiengAnh
{
    public partial class KetQuaHocVien : Form
    {
        int MaTaiKhoan = 0;
        public KetQuaHocVien(int MaTaiKhoan)
        {
            InitializeComponent();
            this.MaTaiKhoan = MaTaiKhoan;
            LoadReport();
        }

        private void LoadReport()
        {
            ReportDocument reportDocument = new ReportDocument();

            //AE thay duong dan ben may ae
            string reportPath = "D:/NinhCode/HSK/HocTiengAnh/crpKetQuaHocVien.rpt";
            reportDocument.Load(reportPath);

            DataTable dt = GetData(MaTaiKhoan);
            reportDocument.SetDataSource(dt);


            crpKetQuaHocVien.ReportSource = reportDocument;
            crpKetQuaHocVien.Refresh();
        }

        private DataTable GetData(int maHocVien)
        {
            string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM tblBangKetQua WHERE iMaTK = @MaHocVien";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaHocVien", maHocVien);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cnn.Open();
                    da.Fill(dt);
                    cnn.Close();

                    return dt;
                }
            }
        }
    }
}
