using xCore.Models;

namespace xCore.Interfaces.Models
{
    public interface IArticleResponse : IArticle
    {
        public string Author { get; set; }
        public DateTime Created { get; set; }
    }
}

