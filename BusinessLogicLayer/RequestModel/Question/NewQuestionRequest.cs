using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Question
{
    public class NewQuestionRequest
    {
        public NewQuestionContentRequest Content { get; set; }
        public Guid TopicId { get; set; }
    }
}
