namespace Core.Entities
{
    public class Outdoor
    {
        public Outdoor()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = Array.Empty<byte>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public byte[] Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
