namespace Core.Entities
{
    public class Park : Outdoor
    {
        public Park()
        {
            Safety = String.Empty;
            WalkingPaths = String.Empty;
        }
        public string Safety { get; set; }
        public bool Camping { get; set; }
        public string WalkingPaths { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
