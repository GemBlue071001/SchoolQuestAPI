﻿using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface ISubjectService
    {
        Task<ApiResponse> AddSubjectAsync(NewSubjectRequest newSubjet);
        Task<ApiResponse> GetSubjectPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> UpdateSubjectAsync(Guid subjectId, NewSubjectRequest newSubject);
        Task<ApiResponse> GetSubjectDetailAsync(Guid subjectId);
        Task<ApiResponse> GetTotalOfSubject();
        Task<ApiResponse> DeleteSubject(Guid id);
    }
}
