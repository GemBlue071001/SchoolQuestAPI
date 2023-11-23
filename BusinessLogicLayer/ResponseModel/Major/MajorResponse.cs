using BusinessLogicLayer.ResponseModel.Department;
using Domain.Models;

namespace BusinessLogicLayer.ResponseModel.Major
{
    public class MajorResponse{
        public Guid Id { get; set; }
        public string MajorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public DepartmentResponse Department { get; set;}

    }
    
}