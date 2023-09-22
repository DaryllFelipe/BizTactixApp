using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components;

namespace BizTactixApp.Components
{
    public partial class UserInfo
    {
        #region Propeties
        [Inject]
        public PageState PageState { get; set; }
        #endregion
    }
}