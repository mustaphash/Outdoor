namespace Core.Entities
{
    public class Park : Outdoor
    {
        public Park()
        {
            Safety = string.Empty;
            Animals = new List<Animal>();
            Extras = new List<Extras>();
        }

        public string Safety { get; set; }

        public ICollection<Animal> Animals { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
