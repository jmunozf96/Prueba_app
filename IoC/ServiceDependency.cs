using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace IoC
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services) {
            services.AddScoped<IDepartamentoService, DepartamentoService>();
            services.AddScoped<ICargoService, CargoService>();
        }
    }
}
