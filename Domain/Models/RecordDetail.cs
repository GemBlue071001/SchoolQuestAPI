namespace Domain.Models
{
    public class RecordDetail
    {
        public int Id { get; set; }
        public int UserRecordId { get; set; }
        public int QuestionId { get; set; }
        public string UserChoice { get; set; }

        //Navigation Property
        public MBTI_UserRecord MBTI_UserRecord { get; set; }
        public MBTI_Question MBTI_Question { get; set; }
    }
}
