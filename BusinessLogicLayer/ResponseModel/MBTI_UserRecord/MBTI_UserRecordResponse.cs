using BusinessLogicLayer.ResponseModel.MBTI;
using BusinessLogicLayer.ResponseModel.MBTIExamResponse;

namespace BusinessLogicLayer.ResponseModel.MBTI_UserRecord
{
    public class MBTI_UserRecordResponse
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public int mbtiId { get; set; }
        public string DoneBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public MBTIResponse mbti { get; set; }
        public List<RecordDetailResponse> RecordDetails { get; set; }
    }

    public class RecordDetailResponse
    {
        public string UserChoice { get; set; }
        public MBTI_ExamQuestionResponse MBTI_ExamQuestion { get; set; }
    }
}
