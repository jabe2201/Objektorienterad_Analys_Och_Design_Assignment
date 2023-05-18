using Microsoft.EntityFrameworkCore;
using xCore.Models.Entities;

namespace xCore.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
