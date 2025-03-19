using HocTiengAnh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh
{
    public partial class Question: Form
    {
        QuestionAdapter adapter = null;
        Account account = null;
        string MaBaiHoc = null;
        List<Model.Question> listQuestion = new List<Model.Question> ();
        int currentIndex = 0;
        string MaKetQua = null;
        Button btnSelected;
        public Question(string sMaBaiHoc)
        {
            InitializeComponent();
            adapter = new QuestionAdapter();
            this.MaBaiHoc = sMaBaiHoc;
            LoadUserData(MaBaiHoc);
            LoadQuestion();
        }

        public void LoadUserData(string sMaBaiHoc)
        {
            string MaBaiHoc = sMaBaiHoc;
            MaKetQua = adapter.autoGenerateMaKetQua();

            Account account = new Account();
            int MaTaiKhoan = 2;

          
            adapter.CreateResult(MaTaiKhoan.ToString(), MaBaiHoc);

        }
        public void LoadQuestion()
        {
            listQuestion = adapter.LoadQuestion("BH001");
            displayQuestion();
        }

        public void displayQuestion()
        {
            btnNext.Visible = false;
            if (btnSelected != null)
            {
                btnSelected.BackColor = Color.White;
                btnSelected = null;
            }


            if (currentIndex <  listQuestion.Count)
            {
                var question = listQuestion[currentIndex];

                lblQuestion.Text = $"Question {currentIndex+1}/{listQuestion.Count}";
                lblQuestionContent.Text = question.NoiDungCauHoi.ToString();

                for(int i = 0; i<question.listAnswer.Count; i++)
                {
                    Button btnAnswer = this.Controls.Find($"button{i + 1}",true).FirstOrDefault() as Button;
                    if (btnAnswer != null) 
                    {
                        btnAnswer.Text = question.listAnswer[i].NoiDungDapAn.ToString();
                        btnAnswer.Tag = (question.listAnswer[i].MaCauHoi,question.listAnswer[i].MaDapAn,question.listAnswer[i].DapAnDung);
                    
                    }
                }
            }
        }

        private void btnAnswer_onClick(object sender, EventArgs e)
        {
            if(btnSelected != null)
            {
                btnSelected.BackColor = Color.White;
                btnSelected = sender as Button;
                btnSelected.BackColor = Color.Yellow;
            } else
            {
                btnSelected = sender as Button;
                btnSelected.BackColor = Color.Yellow;
            }

        }

        private void btnSubmit_onClick(object sender, EventArgs e)
        {
            if(btnSelected == null)
            {
                MessageBox.Show("Please select an answer");
                return;
            } else
            {
                checkAnswer();
            }
        }

        private void checkAnswer()
        {

            var tagData = ((string MaCauHoi,string MaDapAn, bool isCorrect))btnSelected.Tag;
            string MaCauHoi = tagData.MaCauHoi;
            string MaDapAn = tagData.MaDapAn;
            bool DapAnDung = tagData.isCorrect;
            adapter.CreateResultDetail(MaKetQua, MaCauHoi, MaDapAn, DapAnDung);

            //Hien thi mau sac
            if (DapAnDung)
            {
                btnSelected.BackColor = Color.Green;
                

            } else
            {
                btnSelected.BackColor = Color.Red;
            }

            
            //Hien thi button Next
            btnNext.Visible = true;

            currentIndex++;

            if (currentIndex == listQuestion.Count)
            {
                btnNext.Text = "Hoàn thành";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (currentIndex == listQuestion.Count)
            {
                btnNext.Visible = false;
                MessageBox.Show("Hoàn thành");
                adapter.FinishTest(MaKetQua, DateTime.Now);
                this.Hide();
                Result result = new Result(2,MaBaiHoc);
                result.ShowDialog();
            }
            else
            {
                displayQuestion();
            }

            
        }
    }
}
