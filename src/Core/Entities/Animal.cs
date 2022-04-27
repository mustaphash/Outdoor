namespace Core.Entities
{
    public class Animal
    {
        public Animal()
        {
            Name = string.Empty;
            Description = string.Empty;
            Lakes = new List<Lake>();
            NatureReserves = new List<NatureReserve>();
            Parks = new List<Park>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Lake> Lakes { get; set; }

        public ICollection<NatureReserve> NatureReserves { get; set; }

        public ICollection<Park> Parks { get; set; }
    }
}
