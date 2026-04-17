using PassGeneratorService.Domain.Entity;

namespace PassGeneratorService.Application.Interfaces
{
    public interface IPasswordRepository
    {
        Task<bool> SavePassword(Password password);
    }
}
