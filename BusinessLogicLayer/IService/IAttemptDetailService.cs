using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IAttemptDetailService
    {
        Task<ApiResponse> AddAttemptDetailAsync(AttemptDetailRequest userAttempt);
    }
}
