namespace Core.Entities
{
    public class Fountain : Outdoor
    {
        public Fountain()
        {
            WaterType = string.Empty;
            InMemoryOf = string.Empty;
            Extras = new List<Extras>();
        }
        public string WaterType { get; set; }
        public string InMemoryOf { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
