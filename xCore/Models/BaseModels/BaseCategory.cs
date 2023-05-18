using xCore.Interfaces.Models;

namespace xCore.Models.BaseModels
{
    public abstract class BaseCategory : ICategory
    {
        public virtual string CategoryName { get; set; } = null!;
    }
}
