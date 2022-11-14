using Domain.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services) {
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
