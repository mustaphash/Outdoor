namespace Core.Entities
{
    public class Lake : Outdoor
    {
        public bool FishingAllowed { get; set; }
        public bool Camping { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
