using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using p5_C00441253_C00445623.Data;
using Microsoft.EntityFrameworkCore;
using BlazorServerWDB.Data;

var builder = WebApplication.CreateBuilder(args);

// Builder to get the connection string and connect to the database
builder.Services.AddDbContext<DictionaryDbContext>(
    options =>options.UseSqlite(
        builder.Configuration.GetConnectionString(
            "DictionaryDbContext")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();

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
