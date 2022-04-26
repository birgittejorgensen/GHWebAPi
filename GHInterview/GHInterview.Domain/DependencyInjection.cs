using Microsoft.Extensions.DependencyInjection;

namespace GHInterview.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IValueService, ValueService>();
            return services;
        }
    }
}
