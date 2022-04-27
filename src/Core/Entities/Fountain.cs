namespace Core.Entities
{
    public class Fountain : Outdoor
    {
        public Fountain()
        {
            InMemoryOf = string.Empty;
            Extras = new List<Extras>();
            WaterType = new WaterType();
        }

        public string InMemoryOf { get; set; }

        public int WaterTypeId { get; set; }

        public ICollection<Extras> Extras { get; set; }

        public WaterType WaterType { get; set; }
    }
}
