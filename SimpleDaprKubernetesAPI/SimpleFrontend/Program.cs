using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SimpleFrontend.Data;
//Add start
using Dapr.Client;
using System.Text.Json;
//add end

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//add start
JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
builder.Services.AddDaprClient(client =>
{
    client.UseJsonSerializationOptions(options);
});
//add end

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
