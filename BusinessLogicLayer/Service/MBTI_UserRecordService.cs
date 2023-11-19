using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;

namespace BusinessLogicLayer.Service
{
    public class MBTI_UserRecordService : IMBTI_UserRecordService
    {
        private IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public IClaimsService _claimsService;

        public MBTI_UserRecordService(IUnitOfWork unitOfWork, IMapper mapper, IClaimsService claimsService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimsService = claimsService;
        }

        public async Task<ApiResponse> AddUserRecord(MBTIUserRecordRequest newRecord)
        {
            var response = new ApiResponse();
            var userRecord = _mapper.Map<MBTI_UserRecord>(newRecord);
            var userId = _claimsService.GetUserIdInRequest();
            userRecord.UserId = userId;

            await _unitOfWork.IMBTI_UserRecords.AddAsync(userRecord);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(Resources.CreateSuccess);
        }
    }
}
