namespace Core.Entities
{
    public class Outdoor
    {
#pragma warning disable CS8618 
        public Outdoor()
        {
        }
#pragma warning restore CS8618

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
