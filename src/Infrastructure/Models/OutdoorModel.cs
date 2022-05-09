using Core.Entities;

namespace Infrastructure.Models
{
    public class OutdoorModel
    {
        public OutdoorModel(Outdoor outdoor)
        {
            Id = outdoor.Id;
            Name = outdoor.Name;
            Description = outdoor.Description;
            Year = outdoor.Year;
            Image = outdoor.Image;
            Longitude = outdoor.Longitude;
            Latitude = outdoor.Latitude;
            WorkingHours = outdoor.WorkingHours;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public byte[] Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }
    }
}
