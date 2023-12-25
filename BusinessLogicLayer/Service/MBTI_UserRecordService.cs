using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTI;
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

            newUserRecord.UserId = userId;
            await _unitOfWork.MBTI_UserRecords.AddAsync(newUserRecord);
            await _unitOfWork.SaveChangeAsync();

            var mbti = await _unitOfWork.MBITs.GetAsync(x => x.Code == newRecord.Result);

            if (mbti == null)
            {
                return response.SetBadRequest("The result is wrong ! ");
            }

            return response.SetOk(mbti);
        }

        public async Task<ApiResponse> GetUserRecord()
        {
            var userId = _claimsService.GetUserIdInRequest();
            var userRecords = await _unitOfWork.MBTI_UserRecords.GetUserRecords(userId);
            var userRecordsResponse = _mapper.Map<List<MBTI_UserRecordResponse>>(userRecords);

            foreach (var record in userRecordsResponse)
            {
                var mbti = await _unitOfWork.MBITs.GetAsync(x => x.Code == record.Result);
                record.mbtiId = mbti.Id;
                record.mbti = _mapper.Map<MBTIResponse>(mbti);
            }

            var response = new ApiResponse();

            return response.SetOk(userRecordsResponse);
        }

        public async Task<ApiResponse> GetUserRecordForAdmin(Guid userId)
        {
            var userRecords = await _unitOfWork.MBTI_UserRecords.GetUserRecords(userId);
            var userRecordsResponse = _mapper.Map<List<MBTI_UserRecordResponse>>(userRecords);

            foreach (var record in userRecordsResponse)
            {
                var mbti = await _unitOfWork.MBITs.GetAsync(x => x.Code == record.Result);
                record.mbtiId = mbti.Id;
                record.mbti = _mapper.Map<MBTIResponse>(mbti);
            }

            var response = new ApiResponse();

            return response.SetOk(userRecordsResponse);
        }

        public async Task<ApiResponse> GetUserRecordDetail(int id)
        {
            var response = new ApiResponse();
            var userId = _claimsService.GetUserIdInRequest();

            var userRecords = await _unitOfWork.MBTI_UserRecords.GetUserRecordDetail(id);

            if (userRecords == null)
                return response.SetBadRequest();

            if (userRecords.UserId != userId)
                return response.SetBadRequest("Bạn không được xem bài kiểm tra này !");

            var userRecordsResponse = _mapper.Map<MBTI_UserRecordResponse>(userRecords);

            return response.SetOk(userRecordsResponse);
        }


        public async Task<ApiResponse> GenerateMbtiReport()
        {
            var response = new ApiResponse();
            var mbtiReport = await _unitOfWork.MBTI_UserRecords.GenerateMbtiReport();
            return response.SetOk(mbtiReport);
        }

    }
}
