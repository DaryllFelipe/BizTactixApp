using BizTactixApp.DataAccess.Enum;
using System.ComponentModel.DataAnnotations;

namespace BizTactixApp.DataAccess.Dto
{
    public class AddressDto
    {
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public CountryCode countryCode { get; set; }
    }
}
