using BizTactixApp.DataAccess.Dto;

namespace BizTactixApp.DataAccess.State
{
    public class PageState
    {
        public string Token { get; set; }
        public UserDto? User { get; set; } = null;
    }
}
