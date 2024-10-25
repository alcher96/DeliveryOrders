using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace FilterToDelivery.Extentions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            //Разрешаем resource sharing
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader());
            });

            
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseSqlite(config.GetConnectionString("DefaultConnection"), b =>
                    b.MigrationsAssembly("FilterToDelivery")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
