using System.ComponentModel.DataAnnotations;
using xCore.Interfaces.Models;

namespace xCore.Models.Entities
{
    public class AuthorEntity : IAuthorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<ArticleEntity>? Articles { get; set; }
    }
}
