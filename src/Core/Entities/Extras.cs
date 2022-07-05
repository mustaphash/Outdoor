namespace Core.Entities
{
    public class Extras
    {
#pragma warning disable CS8618 
        public Extras()
        {
        }
#pragma warning restore CS8618

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
