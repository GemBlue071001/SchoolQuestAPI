using BusinessLogicLayer.ResponseModel.Examination;
using BusinessLogicLayer.ResponseModel.Question;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.Attempt
{
    public class AttemptResponse
    {
        public DateTime ExamDate { get; set; }
        public AttempType AttempType { get; set; }
        public int? Score { get; set; }
        public string? Result { get; set; }

        public List<AttemptDetailResponse> AttemptDetails { get; set; }
    }

    public class AttemptDetailResponse
    {
        public ExamQuestionResponse ExaminationQuestion { get; set; }
    }
}
