using Microsoft.IdentityModel.Tokens;
using xCore.Factories;
using xCore.Interfaces.Models;
using xCore.Models.BaseModels;
using xCore.Models.Entities;
using xCore.Repositories;

namespace xCore.Models.DTOs
{
    public class ArticleRequest : BaseArticle, IArticleRequest
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public override string Title { get; set; } = null!;
        public override string Content { get; set; } = null!;

    }
}


