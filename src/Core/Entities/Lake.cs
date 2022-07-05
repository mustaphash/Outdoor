namespace Core.Entities
{
    public class Lake : Outdoor
    {
        public Lake()
        {
            Animals = null!;
            Extras = null!;
        }

        public ICollection<Animal> Animals { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
