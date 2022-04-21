namespace Core.Entities
{
    public class NatureReserve : Outdoor
    {
        public bool OpenForTourist { get; set; }
        public double Size { get; set; }

        public ICollection<Animal> Animal { get; set; }
    }
}
