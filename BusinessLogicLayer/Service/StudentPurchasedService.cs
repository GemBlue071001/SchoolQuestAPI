using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.StudentPurchased;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Examination;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class StudentPurchasedService : IStudentPurchasedService
    {
        private IUnitOfWork _unitOfWork;
        private IClaimsService _claimsService;
        private IMapper _mapper;

        public StudentPurchasedService(IUnitOfWork unitOfWork, IClaimsService claimsService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _claimsService = claimsService;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Purchases(StudentPurchasedRequest request)
        {
            var userId = _claimsService.GetUserIdInRequest();
            var response = new ApiResponse();

            var exam = await _unitOfWork.StudentPurchased.GetAsync(x => x.ExaminationId == request.ExamId);
            if (exam != null)
            {
                return response.SetOk("Bài kiểm tra này bạn đã mua rồi ^^ ");
            }

            var user = await _unitOfWork.Users.GetAsync(x => x.Id == userId);
            user.GameToken -= 10;
            if (user.GameToken < 0)
            {
                return response.SetOk("Bạn không đủ tiền");
            }

            await _unitOfWork.StudentPurchased.AddAsync(new StudentPurchased
            {
                ExaminationId = request.ExamId,
                UserId = userId,
            });
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk(Resources.CreateSuccess);
        }

        public async Task<ApiResponse> GetStudentPurches()
        {
            var response = new ApiResponse();
            var userId = _claimsService.GetUserIdInRequest();
            var studentPurches = await _unitOfWork.StudentPurchased.GetStudentPurches(userId);
            var exams = _mapper.Map<List<ExamResponse>>(studentPurches);

            return response.SetOk(exams);
        }

    }
}
