using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Question
{
    public class NewQuestionContentRequest
    {
        public string QuestionContent { get; set; }
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
