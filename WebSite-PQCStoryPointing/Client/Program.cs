using IDT.Purification.Razor.Components.Extensions;
using IDT.Shared.Razor.Components.Extensions;
using IDT.Shared.Razor.Components.Shared.Models;
using IDTServiceRegistryClient.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using WebSite_PQCStoryPointing.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

var applicationName = builder.Configuration["CrystalBallOptions:AppName"] ?? string.Empty;
var buildMode = builder.Configuration.GetSection("BuildMode").Value ?? "Build mode not specified";
var connectionsContainer = builder.Services.AddRegistryClient(builder.Configuration.GetSection("RegistryServiceUri").Value
                                                              ?? "End point not specified");

builder.Services.AddSharedRazorComponents(connectionsContainer,
    buildMode,
    "fas fa-user-astronaut");
builder.Services.AddPurificationRazorComponents(connectionsContainer,
    buildMode);
builder.Services.AddSingleton<IApplicationData>(new ApplicationData(applicationName, applicationName));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
