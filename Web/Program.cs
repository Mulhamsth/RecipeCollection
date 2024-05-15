using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Web;
using Web.Sevice;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<UserCredentials>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7067") });

await builder.Build().RunAsync();