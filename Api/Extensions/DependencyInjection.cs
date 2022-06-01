using Domain.Interfaces;
using Infra.Contexts;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RmContext>(options =>
                                                options.UseNpgsql(configuration.GetConnectionString("Default"),
                                                x => x.MigrationsAssembly(typeof(RmContext).Assembly.FullName))
                                                .EnableSensitiveDataLogging()
                                            );

            services.AddScoped<IPeopleRepository, PeopleRepository>();

            return services;
        }
    }
}