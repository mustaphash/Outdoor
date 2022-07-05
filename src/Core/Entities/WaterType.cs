namespace Core.Entities
{
    public class WaterType
    {
#pragma warning disable CS8618 
        public WaterType()
        {
        }
#pragma warning restore CS8618

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Fountain> Fountains { get; set; }
    }
}
