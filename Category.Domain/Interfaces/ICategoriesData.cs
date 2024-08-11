using Category.Domain.Entities;

namespace Category.Domain.Interfaces
{
    public interface ICategoriesData
    {
        List<CategoryEntity> GetSampleCategories();
    }
}
