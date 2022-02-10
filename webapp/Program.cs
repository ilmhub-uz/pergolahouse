using System.Security.AccessControl;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using webapp;
using webapp.Services;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// builder.Services.AddScoped<JSRuntime>();

// builder.Services.AddTransient<FireBaseService>();
builder.Services.AddBlazoredLocalStorage();

// FireBase Background Service
// var Http = new HttpClient();
// var fireBase = new FireBaseService(Http);

// await fireBase.AddAllAsync(new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();