namespace BusinessLogicLayer.RequestModel.MBTIUserRecord
{
    public class MBTIUserRecordRequest
    {
        public string Result { get; set; }
        public List<RecordDetailRequest> RecordDetails { get; set; }
    }

    public class RecordDetailRequest
    {
        public int MBTI_ExamQuestionId { get; set; }
        public string UserChoice { get; set; }
    }
}
