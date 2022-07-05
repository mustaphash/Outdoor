namespace Core.Entities
{
    public class Animal
    {
#pragma warning disable CS8618 
        public Animal()
        {
        }
#pragma warning restore CS8618

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Lake> Lakes { get; set; }

        public ICollection<NatureReserve> NatureReserves { get; set; }

        public ICollection<Park> Parks { get; set; }
    }
}
