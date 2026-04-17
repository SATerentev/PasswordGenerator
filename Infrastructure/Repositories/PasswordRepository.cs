using PassGeneratorService.Application.Interfaces;
using PassGeneratorService.Domain.Entity;

namespace PassGeneratorService.Infrastructure.Repositories
{
    public class PasswordRepository : IPasswordRepository
    {
        private readonly DbContext _context;

        public PasswordRepository(DbContext context)
        {
            _context = context;
        }

        public Task<bool> SavePassword(Password password)
        {

        }
    }
}
