using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class CreateOutdoorsModel
    {
#pragma warning disable CS8625
#pragma warning disable CS8618 
        public CreateOutdoorsModel()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = null;
#pragma warning restore CS8618
#pragma warning restore CS8625
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public IFormFile Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public Outdoor ToOutdoor()
        {
            byte[] fileBytes = new byte[] { };

            if (Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    Image.CopyTo(ms);
                    fileBytes = ms.ToArray();
                }
            }

            return new Outdoor
            {

                Name = Name,
                Description = Description,
                Year = Year,
                Image = fileBytes,
                Longitude = Longitude,
                Latitude = Latitude,
                WorkingHours = WorkingHours,
                CreateDate = DateTime.Now,
            };

        }
    }
}
