using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Question : Base
    {
        public string Content { get; set; }

        //Navigation Property
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<ExaminationQuestion> ExaminationQuestions { get; set; }
    }
}
