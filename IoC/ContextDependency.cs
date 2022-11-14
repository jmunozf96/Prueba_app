using Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class ContextDependency
    {
        public static void AddContextDependency(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Conexion");
            services.AddDbContext<PruebaAppContext>(opt => opt.UseSqlServer(connectionString));
        }
    }
}
