namespace Core.Entities
{
    public class Lake : Outdoor
    {
        public Lake()
        {
            Animals = new List<Animal>();
            Extras = new List<Extras>();
        }
        public ICollection<Animal> Animals { get; set; }
        public ICollection<Extras> Extras { get; set; }
    }
}
