using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("LisApplicationConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            return services;
        }

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            //services.AddTransient<ICurrentUserService, CurrentUserService>();
            //services.AddScoped<IHttpContextUserService, HttpContextUserService>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



            //services.AddScoped<IIdentityService, IdentityService>();
            //services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            //services.AddScoped<IAccessRightService, AccessRightService>();

            return services;
        }
    }
}