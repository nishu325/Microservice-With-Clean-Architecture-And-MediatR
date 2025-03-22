using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {
            service.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(DepedencyInjection).Assembly));
            return service;
        }
    }
}
