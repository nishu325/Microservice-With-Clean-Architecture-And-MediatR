

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Options;

namespace MyApp.Core
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
            return service;
        }
    }
}
