using Microsoft.AspNetCore.Mvc;
using xCore.Models.DTOs;
using xCore.Models.Entities;

namespace xCore.Interfaces.Repositories
{
    public interface IArticleRepo
    {
        public Task<ArticleResponse> CreateAsync(ArticleEntity entity);

        public Task<ArticleEntity> DeleteAsync(ArticleEntity entity);

        public Task<ArticleEntity> GetAsync(int id);

        public Task<IEnumerable<ArticleEntity>> GetAllAsync();

        public Task<ArticleResponse> UpdateAsync(ArticleEntity entity);
    }
}
