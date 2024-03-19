
using quota.application.Handlers;
using quota.application.Interfaces;
using quota.domain.Interfaces;

namespace quota.api.Helpers;

public static class RegisterHelper
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IQuotaControllerHandler, QuotaControllerHandler>();
        // serviceCollection.AddTransient<IQuotaService>();
    }
    
    public static void AddInfrastructure(this IServiceCollection serviceCollection, ConfigurationManager configuration)
    {

    }
}