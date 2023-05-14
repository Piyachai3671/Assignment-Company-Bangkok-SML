using BlazorApp1.Data;
using BlazorApp1.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<CustomerService>();
//builder.Services.AddDbContext<ApplicationContext>(Option => Option.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Assignment_SML;Trusted_Connection=True;MutipleActiveResultSets=true;TrustServerCertificate=true;"));
builder.Services.AddDbContext<ApplicationContext>(i => i.UseSqlServer("Server=.\\SQLEXPRESS;Database=Assignment_SML;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true; "));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
