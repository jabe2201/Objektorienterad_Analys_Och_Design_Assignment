using Microsoft.EntityFrameworkCore;
using xCore.Context;
using xCore.Interfaces.Repositories;
using xCore.Models.DTOs;
using xCore.Models.Entities;

namespace xCore.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DataContext _context;

        public CategoryRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<CategoryResponse> CreateAsync(CategoryEntity entity)
        {
            try
            {
                await _context.Categories.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            } catch
            {
                return null!;
            }
        }

        public async Task<CategoryEntity> GetAsync(int id)
        {
            try
            {
                var entity = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
                return entity;
            }
            catch { return null!; }
        }

        //public async Task<CategoryResponse> Update(CategoryEntity entity)
        //{
        //    try
        //    {
        //        _context.Update(entity);
        //        await _context.SaveChangesAsync();
        //        return entity;
        //    } catch { return null!; }
        //}
    }
}
