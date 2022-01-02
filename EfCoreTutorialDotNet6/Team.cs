namespace EfCoreTutorialDotNet6
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ComicId { get; set; }
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}
