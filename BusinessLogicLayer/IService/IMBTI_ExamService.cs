﻿using BusinessLogicLayer.RequestModel.MBTI_Exam;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTIExamResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IMBTI_ExamService
    {
        Task<ApiResponse> AddNewExam(NewMBTIExam newExam);
        Task<ApiResponse> GetExam(int index, int pageSize);
        Task<ApiResponse> GetExamDetail(int examId);
    }
}
