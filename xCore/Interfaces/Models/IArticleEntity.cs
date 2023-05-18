using xCore.Factories;
using xCore.Models.Entities;

namespace xCore.Interfaces.Models
{
    public interface IArticleEntity : IArticle
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public CategoryEntity Category { get; set; }
        public AuthorEntity Author { get; set; }
    }
}
