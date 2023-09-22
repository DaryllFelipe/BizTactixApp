using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components;

namespace BizTactixApp.Pages
{
    public partial class EditUserInfo
    {
        #region Properties
        [Inject]
        public PageState PageState { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        #endregion

        #region Methods
        protected override void OnInitialized()
        {
            if (PageState == null || PageState.User == null)
            {
                NavigationManager.NavigateTo("/", true);
            }
        }
        #endregion
    }
}