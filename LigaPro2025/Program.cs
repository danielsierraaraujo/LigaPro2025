using Microsoft.EntityFrameworkCore;
using LigaPro2025.Data;
using Microsoft.Extensions.DependencyInjection;
//generado con chatgpt
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LigaPro2025Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LigaPro2025Context") ?? throw new InvalidOperationException("Connection string 'LigaPro2025Context' not found.")));

// Configurar EF Core
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllersWithViews();
var app = builder.Build();

// Middlewares
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
