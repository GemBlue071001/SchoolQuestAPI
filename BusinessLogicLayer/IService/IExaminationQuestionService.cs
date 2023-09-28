using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IExaminationQuestionService
    {
        Task<ApiResponse> AddExaminationQuestionAsync(NewExaminationQuestionRequest newExamQuestion);
        

    }
}
