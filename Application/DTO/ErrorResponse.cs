namespace PassGeneratorService.Application.DTO
{
    public record ErrorResponse
    {
        public string Type { get; init; }
        public string Title { get; init; }
        public string Detail { get; init; }
    }
}
