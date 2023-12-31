﻿using BusinessLogicLayer.RequestModel.Examination;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IExaminationService
    {
        Task<ApiResponse> AddExaminationAsync(NewExaminationRequest newExamination);
        Task<ApiResponse> AddExaminationAsync(ExaminationRequest newExamination);
        Task<ApiResponse> GetExamDetailAsync(Guid id);
        Task<ApiResponse> GetExamPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> RandomExaminationAsync(RandomExamRequest request);
        Task<ApiResponse> GetNumberOfTotalExam();
        Task<ApiResponse> RandomExaminationByTopicAsync(RandomExamByTopicRequest request);
        Task<ApiResponse> DeleteExamlAsync(Guid id);
    }
}
