using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components;

namespace BizTactixApp.Pages
{
    public partial class Index
    {
        #region Properties
        [Inject]
        public PageState PageState { get; set; }
        #endregion

        #region Fields
        #endregion

        #region Methods
        async Task OnSuccessLogin()
        {
            await InvokeAsync(StateHasChanged);
        }
        #endregion

    }
}
