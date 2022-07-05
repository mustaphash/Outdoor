namespace Core.Entities
{
    public class Fountain : Outdoor
    {
#pragma warning disable CS8618 
        public Fountain()
        {
        }
#pragma warning restore CS8618

        public string InMemoryOf { get; set; }

        public int WaterTypeId { get; set; }

        public ICollection<Extras> Extras { get; set; }

        public WaterType WaterType { get; set; }
    }
}
