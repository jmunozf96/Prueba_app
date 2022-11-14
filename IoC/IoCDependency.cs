using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class IoCDependency
    {
        public static void AddDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddContextDependency(configuration);
            services.AddRepositoryDependency();
            services.AddServiceDependency();
        }
    }
}
