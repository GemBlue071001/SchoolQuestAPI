using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.MBTI_Exam
{
    public class NewMBTIExam
    {
        public string? Note { get; set; }
        public List<int> QuestionIds { get; set; }
    }
}
