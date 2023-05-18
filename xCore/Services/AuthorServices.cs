using xCore.Models.Entities;

namespace xCore.Services
{
    public class AuthorServices
    {
        public AuthorEntity Get(int id)
        {
            return new AuthorEntity { Id = id };
        }
    }
}
