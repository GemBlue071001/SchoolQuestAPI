﻿using BusinessLogicLayer.ResponseModel.MBTI_Question;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.MBTIExamResponse
{
    public class MBTIExamResponse
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int NumberOfQuestion { get; set; }
        public Guid? CreatedBy { get; set; }
        public List<MBTI_ExamQuestionResponse> MBTI_ExamQuestions { get; set; }
    }

    public class MBTI_ExamQuestionResponse
    {
        public int Id { get; set; }
        public MBTI_QuestionResponse MBTI_Question { get; set; }
    }
}
