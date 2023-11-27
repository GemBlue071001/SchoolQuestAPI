namespace BusinessLogicLayer.RequestModel.Major
{
    public class NewMajorRequest
    {
         public string MajorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Guid DepartmentId { get; set; }
    }
}