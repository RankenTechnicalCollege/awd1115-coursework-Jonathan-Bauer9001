using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using UncleLeosPizza.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});


// Configure Entity Framework and SQL Server
builder.Services.AddDbContext<UncleLeosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UncleLeosConnection") ?? throw new InvalidOperationException("Connection string 'UncleLeosConnection' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

app.MapControllerRoute(
    name: "categoryFilter",
    pattern: "Menu/{action}/{categorySlug?}",
    defaults: new { controller = "Menu", action = "Index" });

app.Run();
