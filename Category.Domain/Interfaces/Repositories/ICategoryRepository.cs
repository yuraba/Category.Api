using Category.Domain.Entities;

namespace Category.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryEntity> GetAll();
        List<CategoryEntity> GetMain();
        List<CategoryEntity> GetSub(int parentId);
    }
}
