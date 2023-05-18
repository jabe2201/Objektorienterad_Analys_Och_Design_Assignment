using System.ComponentModel.DataAnnotations;
using xCore.Factories;
using xCore.Interfaces.Models;
using xCore.Models.BaseModels;
using xCore.Models.DTOs;

namespace xCore.Models.Entities
{
    public class CategoryEntity : BaseCategory, ICategoryEntity
    {
        public int Id { get; set; }
        public override string CategoryName { get; set; } = null!;
        public ICollection<ArticleEntity>? Articles { get; set; }

        public static implicit operator CategoryResponse(CategoryEntity entity)
        {
            var response = CategoryResponseFactory.Create();
            response.CategoryName = entity.CategoryName;
            return response;
        }
    }
}
