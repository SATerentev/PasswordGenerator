namespace PassGeneratorService.Application.DTO
{
    public record PasswordSettingsResponse
    {
        public int MaxLength { get; init; }
        public int MinLength { get; init; }
        public int DefaultLength { get; init; }
    }
}
