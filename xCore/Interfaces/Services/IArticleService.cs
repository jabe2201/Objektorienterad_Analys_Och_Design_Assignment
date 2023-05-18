using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using xCore.Models.DTOs;
using xCore.Models.Entities;

namespace xCore.Interfaces.Services
{
    public interface IArticleService
    {
        public Task<ArticleResponse> CreateAsync(ArticleRequest request);
        public Task<ArticleEntity> DeleteAsync(int id);
        public Task<ArticleResponse> GetAsync(int id);
        public Task<IEnumerable<ArticleResponse>> GetAllAsync();
        public Task<ArticleResponse> UpdateAsync(int id, ArticleRequest request);

    }
}
