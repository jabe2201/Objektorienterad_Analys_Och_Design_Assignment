using xCore.Interfaces.Models;

namespace xCore.Models.BaseModels
{
    public abstract class BaseArticle : IArticle
    {
        public virtual string Title { get; set; } = null!;
        public virtual string Content { get; set; } = null!;
    }
}

