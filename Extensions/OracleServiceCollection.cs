using Oracle.ManagedDataAccess.Client;

namespace ParcAuto.Extensions;

public static class OracleServiceCollection
{
    public static IServiceCollection AddOracleConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<OracleConnection>(sp =>
        {
            var connectionString = configuration.GetConnectionString("OracleDb");
            return new OracleConnection(connectionString);
        });

        return services;
    }
}
