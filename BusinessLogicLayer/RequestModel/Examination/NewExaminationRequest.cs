using BusinessLogicLayer.RequestModel.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Examination
{
    public class NewExaminationRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<NewQuestionContentRequest> newListOfQuestion { get; set; }
    }
}
