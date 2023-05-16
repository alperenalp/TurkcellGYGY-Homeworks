namespace Movies.Application
{
    public class UpdateDirectorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Info { get; set; }
    }
}