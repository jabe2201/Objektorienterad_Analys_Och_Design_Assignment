using System.ComponentModel.DataAnnotations;
using xCore.Factories;
using xCore.Interfaces.Models;
using xCore.Models.BaseModels;
using xCore.Models.DTOs;

namespace xCore.Models.Entities
{
    public class ArticleEntity : BaseArticle, IArticleEntity 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public CategoryEntity? Category { get; set; }
        public AuthorEntity Author { get; set; } = null!;
        //public ICollection<AuthorEntity> Authors { get; set; } = null!;
        public override string Title { get; set; } = null!;
        public override string Content { get; set; } = null!;

        public static implicit operator ArticleResponse(ArticleEntity entity)
        {
            var res = ArticleResponseFactory.Create();

            res.Title = entity.Title;
            res.Content = entity.Content;
            res.Created = entity.Created;
            res.Author = $"{(entity.Author.FirstName)} {entity.Author.LastName}";
            return res;
        }
    }

    
}
