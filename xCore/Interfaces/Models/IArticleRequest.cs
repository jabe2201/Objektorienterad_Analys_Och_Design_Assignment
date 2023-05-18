using xCore.Models.Entities;

namespace xCore.Interfaces.Models
{
    public interface IArticleRequest : IArticle
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
