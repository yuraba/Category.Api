using Category.Domain.Interfaces;
using Category.Domain.Interfaces.Repositories;
using Category.Persistance.Data;
using Category.Persistance.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Category.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(
            this IServiceCollection serviceDescriptors,
            IConfiguration configuration)
        {
            serviceDescriptors.AddTransient<ICategoryRepository, CategoryRepository>();
            serviceDescriptors.AddTransient<ICategoriesData, CategoriesData>();

            return serviceDescriptors;

        }
    }
}
