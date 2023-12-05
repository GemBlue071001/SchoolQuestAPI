using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTI_UserRecord;
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


            var newUserRecord = _mapper.Map<MBTI_UserRecord>(newRecord);
            var userId = _claimsService.GetUserIdInRequest();

            var userRecord = _unitOfWork.MBTI_UserRecords.GetAsync(x => x.UserId == userId);
            
                newUserRecord.UserId = userId;
                await _unitOfWork.MBTI_UserRecords.AddAsync(newUserRecord);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk(Resources.CreateSuccess);
            
            

        }

        public async Task<ApiResponse> GetUserRecord()
        {
            var userId = _claimsService.GetUserIdInRequest();
            var userRecords = await _unitOfWork.MBTI_UserRecords.GetUserRecords(userId);
            var userRecordsResponse = _mapper.Map<List<MBTI_UserRecordResponse>>(userRecords);
            var response = new ApiResponse();

            return response.SetOk(userRecordsResponse);
        }
    }
}
