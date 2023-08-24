using FluentValidation;
using FluentValidation.AspNetCore;
using OnionArchitecture.Application.Features.Commands.Vehicles.SaveVehicle;

namespace OnionArchitecture.WebAPI.Extensions
{
    public static class FluentApiExtensions
    {
        public static void AddFluentApiService(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssemblyContaining<SaveVehicleCommandValidator>();
        }
    }
}
