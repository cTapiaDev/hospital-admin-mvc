using HospitalAdminMVC.Data;
using HospitalAdminMVC.Middleware;
using HospitalAdminMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace HospitalAdminMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IHospitalInfoService, HospitalInfoService>();
            builder.Services.AddScoped<IServicioDeAuditoria, ServicioDeAuditoria>();
            
            builder.Services.AddDbContext<HospitalDbContext>(options => options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            

            app.UseHttpsRedirection();

            app.UseMiddleware<RegistroDeActividadMiddleware>();
            app.UseMiddleware<AuditoriaMiddleware>();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
