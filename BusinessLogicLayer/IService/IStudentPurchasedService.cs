using BusinessLogicLayer.RequestModel.StudentPurchased;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IStudentPurchasedService
    {
        Task<ApiResponse> Purchases(StudentPurchasedRequest request);
        Task<ApiResponse> GetStudentPurches();
    }
}
