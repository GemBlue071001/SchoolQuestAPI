using BusinessLogicLayer.ResponseModel.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.Subject
{
    public class SubjectResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int NumberOfTopic { get; set; }
        public List<TopicResponse> Topics { get; set; }
    }
}
