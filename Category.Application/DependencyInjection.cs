using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Category.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(typeof(MappingConfig).Assembly);

            serviceDescriptors.AddSingleton(config);
            serviceDescriptors.TryAddScoped<IMapper, ServiceMapper>();

            return serviceDescriptors;
        }
    }
}
