using BizTactixApp.DataAccess.Enum;

namespace BizTactixApp.DataAccess.Dto
{
    public class FileDto
    {
        public string? fileId { get; set; }
        public string? fileName { get; set; }
        public string? fileType { get; set; }
        public  idType idType { get; set;}
    }
}
