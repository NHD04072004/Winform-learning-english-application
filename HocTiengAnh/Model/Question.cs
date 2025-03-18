using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Model
{
    class Question
    {
        public string MaCauHoi { get; set; }
        public string MaBaiHoc {  get; set; }
        public string NoiDungCauHoi { get; set; }
        public List<Model.Answer> listAnswer { get; set; }
    }
}
