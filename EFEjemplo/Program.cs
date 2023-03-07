using EFEjemplo.DataContext;
using EFEjemplo.Services;
using Microsoft.EntityFrameworkCore;

namespace EFEjemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<ITools, Tools>();
            builder.Services.AddDbContext<ProducContext>
                (option => option.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}