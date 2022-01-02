namespace EfCoreTutorialDotNet6
{
    public class Comic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
