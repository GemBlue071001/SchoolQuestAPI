using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.MBTI_Question
{
    public class MBTI_QuestionResponse
    {
        public int Id { get; set; }
        public string NameQuestion { get; set; }
        public MBTI_Letter FirstAnswerType { get; set; }
        public MBTI_Letter SecondAnswerType { get; set; }
        public string NameAns1 { get; set; }
        public string NameAns2 { get; set; }
        public MBTI_Category Category { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
