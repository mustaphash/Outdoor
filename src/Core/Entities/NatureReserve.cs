namespace Core.Entities
{
    public class NatureReserve : Outdoor
    {
        public NatureReserve()
        {
            Animal = new List<Animal>();
            Extras = new List<Extras>();
        }
        public double Size { get; set; }

        public ICollection<Animal> Animal { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
