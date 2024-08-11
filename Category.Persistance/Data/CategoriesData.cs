using Category.Domain.Entities;
using Category.Domain.Interfaces;

namespace Category.Persistance.Data
{
    public class CategoriesData : ICategoriesData
    {
        public List<CategoryEntity> GetSampleCategories()
        {
            return new List<CategoryEntity>
            {
                new CategoryEntity { CategoryId = 1, CategoryName = "Fruits", ParentCategoryId = null },
                new CategoryEntity { CategoryId = 2, CategoryName = "Apples", ParentCategoryId = 1 },
                new CategoryEntity { CategoryId = 3, CategoryName = "Green Apples", ParentCategoryId = 2 },
                new CategoryEntity { CategoryId = 4, CategoryName = "Red Apples", ParentCategoryId = 2 },
                new CategoryEntity { CategoryId = 5, CategoryName = "Vegetables", ParentCategoryId = null },
                new CategoryEntity { CategoryId = 6, CategoryName = "Leafy Greens", ParentCategoryId = 5 },
                new CategoryEntity { CategoryId = 7, CategoryName = "Spinach", ParentCategoryId = 6 },
                new CategoryEntity { CategoryId = 8, CategoryName = "Kale", ParentCategoryId = 6 },
                new CategoryEntity { CategoryId = 9, CategoryName = "Root Vegetables", ParentCategoryId = 5 },
                new CategoryEntity { CategoryId = 10, CategoryName = "Carrots", ParentCategoryId = 9 },
                new CategoryEntity { CategoryId = 11, CategoryName = "Beets", ParentCategoryId = 9 }
            };
        }
    }
}
