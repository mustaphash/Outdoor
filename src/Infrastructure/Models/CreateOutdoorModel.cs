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
            Image = new List<IFormFile>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public IList<IFormFile> Image { get; set; }

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
                    Longitude = Longitude,
                    Latitude = Latitude,
                    WorkingHours = WorkingHours,
                };
            
        }
    }
}
