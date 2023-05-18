using xCore.Interfaces.Models;
using xCore.Models.BaseModels;

namespace xCore.Models.DTOs
{
    public class ArticleResponse : BaseArticle, IArticleResponse
    {
        public string Author { get; set; } = null!;
        public DateTime Created { get; set; }
        public override string Title { get; set; } = null!;
        public override string Content { get; set; } = null!;
    }
}
