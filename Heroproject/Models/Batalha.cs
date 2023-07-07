namespace Heroproject.Models
{
    public class Batalha
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Description { get; set; }

        public DateTime DtInicio { get; set; }

        public DateTime DtFim { get; set; }

        public List<BatalhasHeroi>? BatalhasHerois { get; set; }
    }
}
