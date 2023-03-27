using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RainbowPlant.Data;
using RainbowPlant.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RainbowPlantContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RainbowPlantContext") ?? throw new InvalidOperationException("Connection string 'RainbowPlantContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // 
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
