using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using MVC_CRUD.Data;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace MVC_CRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add MVC services
            builder.Services.AddControllersWithViews();

            // Add DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            var app = builder.Build();

            // Middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // Default route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Students}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
