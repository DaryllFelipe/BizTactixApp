using System.ComponentModel.DataAnnotations;

namespace BizTactixApp.DataAccess.Dto
{
    public class UserDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool firstLogin { get; set; }
        public MobileDto? mobilePhone { get; set; }
        public MobileDto? phone { get; set; }
        public string? companyName { get; set; }
        public List<FileDto>? files { get; set; }
        public List<InterviewDto>? interviews { get; set; }
        public List<AddressDto>? addresses { get; set; }
    }
}
