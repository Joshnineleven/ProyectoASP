using Microsoft.EntityFrameworkCore;
using ProyectoASP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PruebamvccoreContext>(conexion => {
    conexion.UseSqlServer(builder.Configuration.GetConnectionString("Server=DESKTOP-76T2MFK;Database=pruebamvccore;user id=sa;password=123;TrustServerCertificate=True"));
});

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
