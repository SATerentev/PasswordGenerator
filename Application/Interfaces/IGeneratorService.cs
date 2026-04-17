using PassGeneratorService.Domain.Entity;

namespace PassGeneratorService.Application.Interfaces
{
    public interface IGeneratorService
    {
        Password GeneratePass(int passLength, bool includeUpperCase, bool includeNumbers, bool includeSymbols);
    }
}
