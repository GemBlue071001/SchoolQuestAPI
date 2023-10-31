using BusinessLogicLayer.RequestModel.Question;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IQuestionService
    {
        Task<ApiResponse> AddQuestionAsync(NewQuestionRequest newQuestion);
        Task<ApiResponse> AddListOfQuestionsWithTopicAsync(QuestionTopicRequest questionTopic);
        Task<ApiResponse> GetQuestionPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> AddListOfQuestionsAsync(List<NewQuestionContentRequest> newListOfQuestion);
        Task<ApiResponse> UpdateQuestionAsync(Guid questionId, NewQuestionContentRequest newQuestion);
        Task<ApiResponse> GetQuestionDetailAsync(Guid questionId);
        Task<ApiResponse> GetTotalOfQuestion();
    }
}
