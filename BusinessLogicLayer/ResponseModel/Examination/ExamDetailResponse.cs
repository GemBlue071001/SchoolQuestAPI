using BusinessLogicLayer.ResponseModel.Question;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.Examination
{
    public class ExamDetailResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalNumberOfQuestion { get; set; }
        public List<ExamQuestionResponse> ExaminationQuestions { get; set; }

    }

    public class ExamQuestionResponse
    {
        public Guid Id { get; set; }
        public QuestionResponse Question { get; set; }
    }
}
