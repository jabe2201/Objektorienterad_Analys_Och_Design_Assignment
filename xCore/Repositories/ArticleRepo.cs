using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xCore.Context;
using xCore.Interfaces.Repositories;
using xCore.Models.DTOs;
using xCore.Models.Entities;

namespace xCore.Repositories
{
    public class ArticleRepo : IArticleRepo
    {
        private readonly DataContext _context;

        public ArticleRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<ArticleResponse> CreateAsync(ArticleEntity entity)
        {
            try
            {
                await _context.Articles.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            } catch
            {
                return null!;
            }
        }

        public async Task<ArticleEntity> DeleteAsync(ArticleEntity entity)
        {
            try
            {
                _context.Articles.Remove(entity);
                await _context.SaveChangesAsync();
                return (null!);
            } catch
            {
                return (entity);
            }
        }

        public async Task<ArticleEntity> GetAsync(int id)
        {
            try
            {
                var entity = await _context.Articles
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .FirstOrDefaultAsync(x => x.Id == id);
                return entity;
            } catch
            {
                return null!;
            }
        }

        public async Task<IEnumerable<ArticleEntity>> GetAllAsync()
        {
            try
            {
                var articles = await _context.Articles
                .Include(x => x.Author)
                .ToListAsync();

                return articles;
            } catch { return null!; }
            
        }

        public async Task<ArticleResponse> UpdateAsync(ArticleEntity entity)
        {
            try
            {
                _context.Articles.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            } catch
            {
                return null!;
            }
        }
    }
}
