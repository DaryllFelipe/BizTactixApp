using BizTactixApp.Components;
using BizTactixApp.DataAccess.Dto;
using Refit;

namespace BizTactixApp.DataAccess.Service
{
    [Headers("Authorization: Basic")]
    public interface IPageService
    {
        [Post("/auth/userlogin")]
        Task<string> Login([Body] LoginRequestDto loginRequestDto);

        [Get("/profile")]
        Task<UserDto> Get([Authorize("Bearer")] string token);

        [Put("/profile")]
        Task<UserDto> Put([Authorize("Bearer")] string token, [Body] UpdateUserDto userForm);
    }
}
