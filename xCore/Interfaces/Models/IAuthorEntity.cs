using xCore.Models.Entities;

namespace xCore.Interfaces.Models
{
    public interface IAuthorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ArticleEntity> Articles { get; set; }
    }
}
