namespace Category.Domain.Entities
{
    public class CategoryEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int? ParentCategoryId { get; set; }
    }
}
