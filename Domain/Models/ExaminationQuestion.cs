namespace Domain.Models
{
    public class ExaminationQuestion : Base
    {
        public Guid ExaminationId { get; set; }
        public Guid QuestionId { get; set; }

        //Property Navigation
        public List<AttemptDetail> AttemptDetails { get; set; }
        public Question Question { get; set; }
        public Examination Examination { get; set; }
    }
}
