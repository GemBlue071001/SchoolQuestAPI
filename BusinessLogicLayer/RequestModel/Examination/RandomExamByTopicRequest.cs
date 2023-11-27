using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Examination
{
    public class RandomExamByTopicRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Guid> TopicIds { get; set; }
    }
}
