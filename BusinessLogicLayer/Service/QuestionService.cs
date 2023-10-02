using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Question;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Question;
using BusinessLogicLayer.ResponseModel.Subject;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System.Text.Json;

namespace BusinessLogicLayer.Service
{
    public class QuestionService : IQuestionService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public QuestionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddQuestionAsync(NewQuestionRequest newQuestion)
        {
            ApiResponse apiResponse = new ApiResponse();

            var question = new Question
            {
                Id = Guid.NewGuid(),
                Content = JsonSerializer.Serialize(newQuestion.Content),
                TopicId = newQuestion.TopicId != default ? newQuestion.TopicId : null
            };

            await _unitOfWork.Questions.AddAsync(question);
            await _unitOfWork.SaveChangeAsync();
            
            return apiResponse.SetOk();
        }

        public async Task<ApiResponse> GetQuestionPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfQuestions = await _unitOfWork.Questions.PagingAsync(pageIndex, pageSize, search);
            var listOfQuestionResponse = _mapper.Map<List<QuestionResponse>>(listOfQuestions);
            var totalOfQuestion = await _unitOfWork.Subjects.CountPagingAsync(pageIndex, pageSize, search);
            Pagination<QuestionResponse> response = new Pagination<QuestionResponse>(listOfQuestionResponse, totalOfQuestion, pageIndex, pageSize);

            apiResponse.SetOk(response);
            return apiResponse;
        }
    }
}
