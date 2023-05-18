using xCore.Models.DTOs;
using xCore.Models.Entities;

namespace xCore.Interfaces.Repositories
{
    public interface ICategoryRepo
    {
        public Task<CategoryResponse> CreateAsync(CategoryEntity entity);
        public Task<CategoryEntity> GetAsync(int id);
        //public Task<CategoryResponse> Update(CategoryEntity entity);
    }
}
