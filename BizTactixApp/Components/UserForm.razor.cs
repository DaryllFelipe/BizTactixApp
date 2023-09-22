using BizTactixApp.DataAccess.Dto;
using BizTactixApp.DataAccess.Service;
using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components;

namespace BizTactixApp.Components
{
    public partial class UserForm
    {
        #region Properties
        [Inject]
        public PageState PageState { get; set; }
        [Inject]
        public IPageService PageService { get; set; }
        #endregion

        #region Fields
        UpdateUserDto Model;
        bool IsUpdating;
        bool IsShowMessage;
        string Message;
        #endregion

        #region Methods
        protected override void OnInitialized()
        {
            if (PageState != null && PageState.User != null)
            {
                Model = new()
                {
                    DateOfBirth = PageState.User.dateOfBirth,
                    Email = PageState.User.email,
                    FirstName = PageState.User.firstName,
                    LastName = PageState.User.lastName,
                    mobilePhone = PageState.User.mobilePhone,
                    phone = PageState.User.phone,
                    Address = PageState.User.addresses.FirstOrDefault()?.address,
                    Address1 = PageState.User.addresses.FirstOrDefault()?.address2,
                    City = PageState.User.addresses.FirstOrDefault()?.city,
                    Company = PageState.User.companyName,
                    CountryCode = PageState.User.addresses.FirstOrDefault().countryCode,
                    PostalCode = PageState.User.addresses.FirstOrDefault()?.postalCode,
                    Region = PageState.User.addresses.FirstOrDefault()?.region
                };
            }
        }

        public async Task Update()
        {
            if (!IsUpdating)
            {
                IsUpdating = true;
                await InvokeAsync(StateHasChanged);
                try
                {
                    var result = await PageService.Put(PageState.Token, Model);
                    PageState.User = await PageService.Get(PageState.Token);
                    Message = "Successfully updated";
                }
                catch
                {
                    Message = "Something went wrong, please try again";
                }
                IsShowMessage = true;
                IsUpdating = false;
                await InvokeAsync(StateHasChanged);
            }

        }
        #endregion
    }
}