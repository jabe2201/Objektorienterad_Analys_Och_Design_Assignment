using Microsoft.EntityFrameworkCore;
using xCore.Context;
using xCore.Interfaces.Repositories;
using xCore.Models.Entities;

namespace xCore.Repositories
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly DataContext _context;

        public AuthorRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<AuthorEntity> GetAsync(int id)
        {
            try
            {
                var entity = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
                return entity!;
            } catch { return null!; }
            
        }
    }
}
