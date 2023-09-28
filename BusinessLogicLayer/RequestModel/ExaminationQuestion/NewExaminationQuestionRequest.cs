using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.ExaminationQuestion
{
    public class NewExaminationQuestionRequest
    {
        public Guid ExaminationId { get; set; }
        public Guid QuestionId { get; set; }
    }
}
