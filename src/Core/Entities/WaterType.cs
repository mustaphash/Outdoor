namespace Core.Entities
{
    public class WaterType
    {
        public WaterType()
        {
            Name = string.Empty;
            Fountains = new List<Fountain>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Fountain> Fountains { get; set; }
    }
}
