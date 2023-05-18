using xCore.Interfaces.Models;
using xCore.Models.BaseModels;

namespace xCore.Models.DTOs
{
    public class CategoryResponse : BaseCategory, ICategoryResponse
    {
        public override string CategoryName { get; set; } = null!;
    }
}
