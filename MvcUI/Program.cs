using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using MvcUI.Data;

var builder = WebApplication.CreateBuilder(args);


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddSingleton <TCKimlikKontrol>();
builder.Services.AddDbContext<BasvuruContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<BasvuruContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();



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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
