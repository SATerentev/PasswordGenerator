using System.ComponentModel.DataAnnotations;

namespace PassGeneratorService.Application.DTO
{
    public record GenerationRequest
    {
        public int PassLength { get; init; }
        public bool IncludeUppercase { get; init; }
        public bool IncludeNumbers { get; init; }
        public bool IncludeSymbols { get; init; }
    }
}
