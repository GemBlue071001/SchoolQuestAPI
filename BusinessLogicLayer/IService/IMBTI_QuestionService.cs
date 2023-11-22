using BusinessLogicLayer.RequestModel.MBTI_Question;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IMBTI_QuestionService
    {
        Task<ApiResponse> AddNewQuestion(MBTI_QuestionRequest newQuestion);
        Task<ApiResponse> GetQuestion();
        Task<ApiResponse> AddNewListQuestion(List<MBTI_QuestionRequest> questions);
    }
}
