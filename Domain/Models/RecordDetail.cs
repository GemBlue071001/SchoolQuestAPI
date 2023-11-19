namespace Domain.Models
{
    public class RecordDetail
    {
        public int Id { get; set; }
        public int UserRecordId { get; set; }
        public int MBTI_ExamQuestionId { get; set; }
        public string UserChoice { get; set; }

        //Navigation Property
        public MBTI_UserRecord MBTI_UserRecord { get; set; }
        public MBTI_ExamQuestion MBTI_ExamQuestion { get; set; }
    }
}
