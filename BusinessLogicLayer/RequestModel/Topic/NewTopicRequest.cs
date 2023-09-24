using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Topic
{
    public class NewTopicRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }

        public Guid SubjectId { get; set; }
    }
}
