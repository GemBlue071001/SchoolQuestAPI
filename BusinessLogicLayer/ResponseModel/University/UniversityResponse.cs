using BusinessLogicLayer.ResponseModel.Department;

namespace BusinessLogicLayer.ResponseModel.University
{
    public class UniversityResponse
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public List<UniversityDepartmentResponse> UniversityDepartments { get; set; }
    }

    public class UniversityDepartmentResponse
    {
        public DepartmentResponse? Department { get; set; }
    }
}
