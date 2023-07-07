namespace Heroproject.Models
{
    public class Heroi
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? SuperPoder { get; set; }

        public Identidade? Identidade { get; set; }

        public List<BatalhasHeroi>? BatalhasHerois { get; set; }

    }
}
