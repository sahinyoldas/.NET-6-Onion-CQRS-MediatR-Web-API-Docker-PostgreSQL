using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("WebApiConnectionString"));
            });

            services.AddScoped<IVehicleRepository, VehicleRepository>();
        }
    }
}
