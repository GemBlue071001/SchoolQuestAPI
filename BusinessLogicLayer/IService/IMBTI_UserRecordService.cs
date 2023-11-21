using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IMBTI_UserRecordService
    {
        Task<ApiResponse> AddUserRecord(MBTIUserRecordRequest newRecord);
        Task<ApiResponse> GetUserRecord();
    }
}
