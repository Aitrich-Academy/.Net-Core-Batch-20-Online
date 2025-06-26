
using JobManagement.Extension;
using JobManagement.Helper;
using JobManagement.Model;
using JobManagement.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.MapFallbackToPage("/Job/Index");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
