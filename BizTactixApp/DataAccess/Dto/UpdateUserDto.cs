using BizTactixApp.DataAccess.Enum;

namespace BizTactixApp.DataAccess.Dto
{
    public class UpdateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string PostalCode { get; set; }
        public string Company { get; set; }
        public CountryCode CountryCode { get; set; }
        public MobileDto? mobilePhone { get; set; }
        public MobileDto? phone { get; set; }
    }
}
