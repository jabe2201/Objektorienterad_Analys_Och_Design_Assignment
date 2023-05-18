using xCore.Factories;
using xCore.Interfaces.Models;
using xCore.Models.BaseModels;
using xCore.Models.Entities;

namespace xCore.Models.DTOs
{
    public class CategoryRequest : BaseCategory, ICategoryRequest
    {
        public override string CategoryName { get; set; } = null!;

        public static implicit operator CategoryEntity(CategoryRequest categoryRequest)
        {
            var entity = CategoryEntityFactory.Create();
            entity.CategoryName = categoryRequest.CategoryName;
            return entity;
        }
    }
}
