namespace Core.Entities
{
    public class Extras
    {
        public Extras()
        {
            Name = string.Empty;
            Description = string.Empty;
            Fountains = new List<Fountain>();
            Lakes = new List<Lake>();
            Landmarks = new List<Landmark>();
            Villas = new List<Villa>();
            NatureReserves = new List<NatureReserve>();
            Parks = new List<Park>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Fountain> Fountains { get; set; }

        public ICollection<Lake> Lakes { get; set; }

        public ICollection<Landmark> Landmarks { get; set; }

        public ICollection<Villa> Villas { get; set; }

        public ICollection<NatureReserve> NatureReserves { get; set; }

        public ICollection<Park> Parks { get; set; }
    }
}
