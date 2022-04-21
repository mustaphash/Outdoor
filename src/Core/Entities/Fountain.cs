namespace Core.Entities
{
    public class Fountain : Outdoor
    {
        public Fountain()
        {
            WaterType = String.Empty;
            InMemoryOf = String.Empty;
        }
        public string WaterType { get; set; }
        public string InMemoryOf { get; set; }
    }
}
