using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Question;
using BusinessLogicLayer.RequestModel.Subject;
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

        public async Task<ApiResponse> AddListOfQuestionsAsync(List<NewQuestionContentRequest> newListOfQuestion)
        {
            ApiResponse apiResponse = new ApiResponse();
            List<Question> listquestions = new List<Question>();

            foreach (var newQuestion in newListOfQuestion)
            {
                listquestions.Add(new Question()
                {
                    Id = Guid.NewGuid(),
                    Content= JsonSerializer.Serialize(newQuestion),
                });
            }

            await _unitOfWork.Questions.AddRangeAsync(listquestions);
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

        public async Task<ApiResponse> UpdateQuestionAsync(Guid questionId, NewQuestionContentRequest newQuestion)
        {
            ApiResponse apiResponse = new ApiResponse();

            var question = await _unitOfWork.Questions.GetAsync(x => x.Id == questionId);
            if (question == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            question.Content = JsonSerializer.Serialize(newQuestion);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }

        public async Task<ApiResponse> GetQuestionDetailAsync(Guid questionId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var question = await _unitOfWork.Questions.GetAsync(x => x.Id == questionId);
            if (question == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            var questionResponse = _mapper.Map<QuestionResponse>(question);

            return apiResponse.SetOk(questionResponse);
        }
    }
}
