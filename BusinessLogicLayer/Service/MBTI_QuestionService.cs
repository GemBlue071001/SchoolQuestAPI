using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTI_Question;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTI_Question;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class MBTI_QuestionService : IMBTI_QuestionService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public MBTI_QuestionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddNewQuestion(MBTI_QuestionRequest newQuestion)
        {
            var response = new ApiResponse();
            var mbtiQuestion = _mapper.Map<MBTI_Question>(newQuestion);
            await _unitOfWork.MBTI_Questions.AddAsync(mbtiQuestion);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk();
        }

        public async Task<ApiResponse> AddNewListQuestion(List<MBTI_QuestionRequest> questions)
        {
            var response = new ApiResponse();
            var mbtiQuestions = _mapper.Map<List<MBTI_Question>>(questions);
            await _unitOfWork.MBTI_Questions.AddRangeAsync(mbtiQuestions);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk();
        }

        public async Task<ApiResponse> GetQuestion()
        {
            var response = new ApiResponse();
            var questions = await _unitOfWork.MBTI_Questions.GetAllAsync();

            var questionList = _mapper.Map<List<MBTI_QuestionResponse>>(questions);

            return response.SetOk(questionList);
        }
    }
}
