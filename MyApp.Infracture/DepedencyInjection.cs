
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApp.Core.Interface;
using MyApp.Core.Options;
using MyApp.Infracture.Data;
using MyApp.Infracture.Repository;
using MyApp.Infracture.Services;

namespace MyApp.Infracture
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfractureDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>((provider, options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            service.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();
            service.AddHttpClient<CoinDeskHttpClientService>(client =>
            {
                client.BaseAddress = new Uri("https://api.coindesk.com/v1/");
            });
            return service;
        }
    }
}
