
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interface;
using MyApp.Infracture.Data;
using MyApp.Infracture.Repository;

namespace MyApp.Infracture
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfractureDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return service;
        }
    }
}
