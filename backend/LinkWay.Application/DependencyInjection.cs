using Microsoft.Extensions.DependencyInjection;

namespace LinkWay.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register application services
        return services;
    }
}