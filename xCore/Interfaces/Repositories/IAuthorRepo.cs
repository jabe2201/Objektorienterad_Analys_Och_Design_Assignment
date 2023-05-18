using xCore.Models.Entities;

namespace xCore.Interfaces.Repositories
{
    public interface IAuthorRepo
    {
        public Task<AuthorEntity> GetAsync(int id); 
    }
}
