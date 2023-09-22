using BizTactixApp.DataAccess.Dto;
using BizTactixApp.DataAccess.Service;
using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace BizTactixApp.Components
{
    public partial class LoginForm
    {
        #region Properties
        [Inject]
        public IPageService PageService { get; set; }
        [Inject]
        public PageState PageState { get; set; }
        [Parameter]
        public EventCallback OnSuccess{ get; set; }
        #endregion

        #region Fields
        LoginRequestDto Model;
        bool IsShowError;
        bool IsLogin;
        #endregion

        #region Methods
        protected override void OnInitialized()
        {
            Model = new();
        }

        public async Task Login()
        {
            if (!IsLogin)
            {
                IsLogin = true;
                await InvokeAsync(StateHasChanged);
                try
                {
                    string token = await PageService.Login(Model);
                    JObject jsonObject = JObject.Parse(token);
                    PageState.Token = jsonObject["token"].ToString();
                    PageState.User = await PageService.Get(PageState.Token);
                    IsShowError = false;
                    if (OnSuccess.HasDelegate) await OnSuccess.InvokeAsync();

                }
                catch (Exception ex)
                {
                    IsShowError = true;
                    Console.WriteLine(ex.Message);
                }
                IsLogin = false;
                await InvokeAsync(StateHasChanged);
            }
        }
        #endregion
    }
}