using Category.Application.Operations.Categories.Dto;
using Category.Domain.Entities;
using Mapster;

namespace Category.Application
{
    public class MappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CategoryEntity, CategoryDto>();

        }
    }
}
