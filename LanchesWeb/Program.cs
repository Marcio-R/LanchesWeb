using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LanchesWeb.Data;
using LanchesWeb.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LanchesWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LanchesWebContext") ?? throw new InvalidOperationException("Connection string 'LanchesWebContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<LancheRepository>();
builder.Services.AddScoped<CategoriaRepository>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
