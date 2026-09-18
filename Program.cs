using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FingerSlide;
using FingerSlide.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registrar el servicio de C# para el configurador
builder.Services.AddScoped<ConfiguratorService>();

await builder.Build().RunAsync();