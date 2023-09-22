using System.ComponentModel.DataAnnotations;

namespace BizTactixApp.DataAccess.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
