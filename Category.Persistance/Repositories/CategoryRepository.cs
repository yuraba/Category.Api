using Category.Domain.Entities;
using Category.Domain.Interfaces;
using Category.Domain.Interfaces.Repositories;

namespace Category.Persistance.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICategoriesData _categoriesData;

        public CategoryRepository(ICategoriesData categoriesData)
        {
            _categoriesData = categoriesData;
        }

        public List<CategoryEntity> GetAll()
        {
            return _categoriesData.GetSampleCategories().ToList();
        }

        public List<CategoryEntity> GetMain()
        {
            return _categoriesData.GetSampleCategories().Where(x=>x.ParentCategoryId==null).ToList();
        }

        public List<CategoryEntity> GetSub(int parentId)
        {
            return _categoriesData.GetSampleCategories().Where(x => x.ParentCategoryId == parentId).ToList();
        }
    }
}
