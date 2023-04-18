using ComputerRepair.Data;
using ComputerRepair.Models;
using ComputerRepair.Services;
using ComputerRepair.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("defaults")));

builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IDeviceService, ComputerRepair.Services.DeviceService>();
builder.Services.AddTransient<IServiceService, ServiceService>();
builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<IInvoiceService, invoiceService>();
builder.Services.AddTransient<IRequestService, requestService>();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/Login";
        options.AccessDeniedPath = "/Home/AccessDenied";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();

app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
