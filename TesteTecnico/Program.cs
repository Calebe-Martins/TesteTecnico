using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System;
using TesteTecnico;
using TesteTecnico.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Registro do serviço UserRepository
builder.Services.AddScoped<Repository>();
builder.Services.AddScoped<SyncData>();
// Entity Framework
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql("Server=172.16.9.117;Database=MyDatabase;Uid=root;Pwd=123456;", new MySqlServerVersion("8.0.33")));



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
