using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class CreateOutdoorModel
    {
        public CreateOutdoorModel()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = Array.Empty<byte>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public byte[] Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public Outdoor ToOutdoor()
        {
            return new Outdoor
            {
                Name = Name,
                Description = Description,
                Year = Year,
                Image = Image,
                Longitude = Longitude,
                Latitude = Latitude,
                WorkingHours = WorkingHours,
            };
        }
    }
}
