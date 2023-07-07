namespace Heroproject.Models
{
    public class Identidade
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Heroi? Heroi { get; set; }

        public int HeroiId { get; set;}


    }
}
