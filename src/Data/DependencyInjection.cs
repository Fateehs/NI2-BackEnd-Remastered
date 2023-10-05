using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NI2.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgreSQL");

        return services;
    }
}
