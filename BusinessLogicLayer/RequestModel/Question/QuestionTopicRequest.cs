using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Question
{
    public class QuestionTopicRequest
    {
        public List<NewQuestionContentRequest> listOfQuestion { get; set; }
        public Guid topicId { get; set; }
    }
}
