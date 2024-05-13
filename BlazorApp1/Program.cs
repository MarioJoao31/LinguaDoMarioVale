using BlazorApp1;
using BlazorApp1.Controller;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// 1. Add the LocalStorage Services
builder.Services.AddBlazoredLocalStorage();
// 2. Add the Localization Service
builder.Services.AddLocalization();
var host = builder.Build();
// 3. Set the Default UI Culture
await host.SetDefaultUICulture();


await builder.Build().RunAsync();
