namespace Core.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ICollection<Lake> Lakes { get; set; }
        public ICollection<NatureReserve> NatureReserves { get; set; }
    }
}
