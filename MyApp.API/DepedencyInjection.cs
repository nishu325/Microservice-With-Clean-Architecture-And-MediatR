using MyApp.Application;
using MyApp.Core;
using MyApp.Infracture;

namespace MyApp.API
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddApplicationDI().AddInfractureDI(configuration);
            return service;
        }
    }
}
