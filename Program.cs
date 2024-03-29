using StroiTrendTest.Services;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<ChatDataService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:9080/");
});

builder.Services.AddSwaggerGen(options =>
{
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "datalist",
    pattern: "data",
    defaults: new { controller = "DataList", action = "Index" });

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
