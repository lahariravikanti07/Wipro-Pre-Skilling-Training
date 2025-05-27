using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskOfMay27.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaskOfMay27Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskOfMay27Context") ?? throw new InvalidOperationException("Connection string 'TaskOfMay27Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Run();
