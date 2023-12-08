using BusinessLogicLayer.ResponseModel.MBTI_Question;
using BusinessLogicLayer.ResponseModel.MBTIExamResponse;
using Domain.Models;

namespace BusinessLogicLayer.ResponseModel.MBTI_UserRecord
{
    public class MBTI_UserRecordResponse
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public List<RecordDetailResponse> RecordDetails { get; set; }
    }

    public class RecordDetailResponse
    {
        public string UserChoice { get; set; }
        public MBTI_ExamQuestionResponse MBTI_ExamQuestion { get; set; }
    }
}
