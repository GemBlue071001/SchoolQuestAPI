using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Attempt;
using BusinessLogicLayer.ResponseModel.Topic;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class AttemptService : IAttemptService
    {
        public IMapper _mapper;
        public IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AttemptService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetUserIdInRequest()
        {
            var _tokenUserId = _httpContextAccessor.HttpContext.User.FindFirst("UserId");
            if (_tokenUserId == null) throw new ArgumentNullException("User can not be found! ");
            var _userId = Guid.Parse(_tokenUserId?.Value.ToString()!);
            return _userId;
        }


        public async Task<ApiResponse> AddAttemptAsync(NewAttemptRequest newAttempt)
        {
            var tokenUserId = GetUserIdInRequest();

            var response = new ApiResponse();
            var attempt = _mapper.Map<Attempt>(newAttempt);
            attempt.Score = 0;
            attempt.Result = "";

            var studentPurchedExams = await _unitOfWork.StudentPurchased.GetStudentPurches(tokenUserId);
            var exam = await _unitOfWork.Examinations.GetAsync(x => x.Id == newAttempt.AttemptDetails[0].ExaminationQuestionId);

            if (!studentPurchedExams.Contains(exam))
            {
                return response.SetBadRequest("bạn cần mua bài ktra này !!! ");
            }

            attempt.UserId = tokenUserId;

            foreach (var userChoice in newAttempt.AttemptDetails)
            {
                if (userChoice.IsCorrect == true)
                    attempt.Score += 1;
            }

            var numberOfAns = newAttempt.AttemptDetails.Count();

            if (attempt.Score > (numberOfAns / 2))
            {
                attempt.Result = "Pass";
            }
            else attempt.Result = "Fail";

            await _unitOfWork.Attempts.AddAsync(attempt);
            await _unitOfWork.SaveChangeAsync();

            var user = await _unitOfWork.Users.GetAsync(x => x.Id == tokenUserId);
            var highestScore = await _unitOfWork.Attempts.GetHighestScore(tokenUserId);
            user.HighestScore = highestScore;

            return response.SetOk();
        }

        public async Task<ApiResponse> GetStudentAttemptPagingAsync(int pageIndex, int pageSize, string search)
        {
            var res = new ApiResponse();

            var tokenUserId = GetUserIdInRequest();
            var attempts = await _unitOfWork.Attempts.GetStudentAttemptsPagingAsync(pageIndex, pageSize, search, tokenUserId);

            var listOfAttempts = _mapper.Map<List<AttemptResponse>>(attempts);
            var totalOfAttempt = await _unitOfWork.Attempts.GetStudentAttemptCountAsync(search, tokenUserId);

            var attemptsResponse = new Pagination<AttemptResponse>(listOfAttempts, totalOfAttempt, pageIndex, pageSize);

            return res.SetOk(attemptsResponse);
        }

        public async Task<ApiResponse> GetAllAttemptPagingAsync(int pageIndex, int pageSize, string search)
        {
            var res = new ApiResponse();

            var attempts = await _unitOfWork.Attempts.GetAllAttemptsPagingAsync(pageIndex, pageSize, search);

            var listOfAttempts = _mapper.Map<List<AttemptResponse>>(attempts);
            var totalOfAttempt = await _unitOfWork.Attempts.GetAllAttemptCountAsync(search);

            var attemptsResponse = new Pagination<AttemptResponse>(listOfAttempts, totalOfAttempt, pageIndex, pageSize);

            return res.SetOk(attemptsResponse);
        }

        public async Task<ApiResponse> GetAttemptDetail(Guid id)
        {
            var res = new ApiResponse();
            var userId = GetUserIdInRequest();

            var attempts = await _unitOfWork.Attempts.GetDetail(id);
            if (attempts != null)
            {
                if (attempts.UserId != userId)
                    return res.SetBadRequest("Bạn không có quyền xem kết quả bài này");

                var attemptResponse = _mapper.Map<AttemptResponse>(attempts);
                return res.SetOk(attemptResponse);
            }
            else
                return res.SetBadRequest("Không tìm thấy bài kiểm tra ! ");
        }

        public async Task<ApiResponse> GetAttemptForAdmin(Guid studentId)
        {
            var res = new ApiResponse();
            var userId = GetUserIdInRequest();

            var attempts = await _unitOfWork.Attempts.GetStudentAttemptForAdmin(studentId);

            var attemptResponse = _mapper.Map<List<AttemptResponse>>(attempts);
            return res.SetOk(attemptResponse);
        }
    }
}
