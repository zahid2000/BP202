using Microsoft.EntityFrameworkCore;
using WebAppMigration.DAL;

namespace WebAppMigration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
            });
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {

            }

            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(
                  endpoints =>
                  {
                      endpoints.MapControllerRoute(
                               name: "areas",
                               pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                             );
                      endpoints.MapDefaultControllerRoute();
                    
                  });

            app.Run();
        }
    }
}