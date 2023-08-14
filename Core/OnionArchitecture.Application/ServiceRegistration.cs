using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace OnionArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var asssembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(asssembly));
            services.AddAutoMapper(asssembly);
        }
    }
}
