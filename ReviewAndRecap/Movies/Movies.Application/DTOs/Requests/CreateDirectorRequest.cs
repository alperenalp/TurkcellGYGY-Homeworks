namespace Movies.Application
{
    public class CreateDirectorRequest
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Info { get; set; }
    }
}