using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using xCore.Context;
using xCore.Factories;
using xCore.Interfaces.Services;
using xCore.Models.DTOs;
using xCore.Models.Entities;
using xCore.Repositories;

namespace xCore.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ArticleRepo _articleRepo;
        private readonly AuthorRepo _authorRepo;
        private readonly CategoryRepo _categoryRepo;


        public ArticleService(AuthorRepo authorRepo, ArticleRepo articleRepo, CategoryRepo categoryRepo)
        {
            _authorRepo = authorRepo;
            _articleRepo = articleRepo;
            _categoryRepo = categoryRepo;
        }


        public async Task<ArticleResponse> CreateAsync(ArticleRequest request)
        {
            var entity = ArticleEntityFactory.Create();
            var category = await _categoryRepo.GetAsync(request.CategoryId);
            var author = await _authorRepo.GetAsync(request.AuthorId);

            if(author != null) {
                entity.Category = category;
                //entity.Authors.Add(author);
                entity.Author = author;
                entity.Content = request.Content;
                entity.Created = DateTime.Now;
                entity.Title = request.Title;

                var response = await _articleRepo.CreateAsync(entity);
                return response;
            }

            return null!;
        }

        public async Task<ArticleEntity> DeleteAsync(int id)
        {
            var entity = await _articleRepo.GetAsync(id);
            if(entity != null)
            {
                var result = await _articleRepo.DeleteAsync(entity);
                if(result != null)
                {
                    return null!;
                }
                return entity;
            }
            return null!;
        }

        public async Task<ArticleResponse> GetAsync(int id)
        {
            var entity = await _articleRepo.GetAsync(id);
            if(entity != null)
            {
                return entity;
            }
            return null!;
        }

        public async Task<IEnumerable<ArticleResponse>> GetAllAsync()
        {
            var list = new List<ArticleResponse>();
            var articles = await _articleRepo.GetAllAsync();
            foreach (var article in articles)
            {
                list.Add(article);
            }

            return list;
        }

        public async Task<ArticleResponse> UpdateAsync(int id, ArticleRequest request)
        {
            var entity = await _articleRepo.GetAsync(id);
            if(entity != null)
            {
                var category = await _categoryRepo.GetAsync(request.CategoryId);
                var author = await _authorRepo.GetAsync(request.AuthorId);
                entity.Title = request.Title;
                entity.Category = category;
                entity.Author = author;
                entity.Content = request.Content;

                var response = await _articleRepo.UpdateAsync(entity);
                if(response != null)
                {
                    return response;
                }
                return null!;
            }
            return null!;
        }
    }
}
