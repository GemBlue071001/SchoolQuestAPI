using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.MBTI_Question
{
    public class MBTI_QuestionRequest
    {
        public string NameQuestion { get; set; }
        public MBTI_Letter FirstAnswerType { get; set; }
        public MBTI_Letter SecondAnswerType { get; set; }
        public string NameAns1 { get; set; }
        public string NameAns2 { get; set; }
        public MBTI_Category Category { get; set; }
    }
}
