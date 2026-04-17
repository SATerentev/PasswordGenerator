namespace PassGeneratorService.Application.Settings
{
    public record PasswordSettings
    {
        public int MinLength { get; init; }
        public int MaxLength { get; init; }
        public int DefaultLength { get; init; }
    }
}
