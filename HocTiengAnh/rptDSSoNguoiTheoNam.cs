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
    public partial class rptDSSoNguoiTheoNam : Form
    {
        private int nam;
        public rptDSSoNguoiTheoNam(int nam)
        {
            InitializeComponent();
            this.nam = nam;
            LoadrptHocVien();
        }
        private void LoadrptHocVien()
        {
            ReportDocument reportDocument = new ReportDocument();

            string reportPath = "D:\\test\\C Sharp\\baitaplon\\HocTiengAnh\\HocTiengAnh\\DSHocVienTheoNam.rpt";
            reportDocument.Load(reportPath);

            DataTable dt = GetData(nam);
            reportDocument.SetDataSource(dt);


            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }

        private DataTable GetData(int nam)
        {
            string connectString = ConfigurationManager.ConnectionStrings["db_hoc_tieng_anh"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(connectString))
            {
                string query = "select sTenTK, sEmail, nam from tblTaiKhoan where nam = @nam";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@nam", nam);

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
