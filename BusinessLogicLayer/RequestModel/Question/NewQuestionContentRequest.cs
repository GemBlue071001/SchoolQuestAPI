using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Question
{
    public class NewQuestionContentRequest
    {
        public string Question { get; set; }
        public List<Answer> ListAnswer { get; set; }
    }


    public class Answer
    {
        public string Value { get; set; }
        public bool IsAnswer { get; set; }
    }
}
