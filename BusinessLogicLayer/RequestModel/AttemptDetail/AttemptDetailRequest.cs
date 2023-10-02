namespace BusinessLogicLayer.RequestModel.AttempDetail
{
    public class AttemptDetailRequest
    {
        //public Guid AttemptId { get; set; }
        public Guid UserId { get; set; }
        public Guid ExaminationQuestionId { get; set; }
        public bool IsCorrect { get; set; }
        public string UserAnswered { get; set; }
    }
}
