using xCore.Models.Entities;

namespace xCore.Interfaces.Models
{
    public interface ICategoryEntity : ICategory
    {
        public int Id { get; set; }
        public ICollection<ArticleEntity> Articles { get; set; }
    }
}
