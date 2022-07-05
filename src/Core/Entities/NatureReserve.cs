namespace Core.Entities
{
    public class NatureReserve : Outdoor
    {
#pragma warning disable CS8618
        public NatureReserve()
        {
        }
#pragma warning restore CS8618

        public double Size { get; set; }

        public ICollection<Animal> Animal { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
