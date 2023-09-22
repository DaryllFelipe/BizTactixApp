using BizTactixApp;
using BizTactixApp.DataAccess.Service;
using BizTactixApp.DataAccess.State;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<PageState>();

builder.Services.AddRefitClient<IPageService>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://testapi.bizt.it/api/v1");
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();
