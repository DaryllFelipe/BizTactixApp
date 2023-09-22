using BizTactixApp.DataAccess.Enum;

namespace BizTactixApp.DataAccess.Dto
{
    public class InterviewDto
    {
        public DateTime interviewDate { get; set; }
        public string? title { get; set; }
        public string? interviewers { get; set; }
        public InterviewStatus status { get; set; }
    }
}
