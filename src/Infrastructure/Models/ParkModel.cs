using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class ParkModel
    {
#pragma warning disable CS8625
#pragma warning disable CS8618
        public ParkModel(Park park)
        {
            Id = park.Id;
            Name = park.Name;
            Description = park.Description;
            Year = park.Year;
            Image = null;
            Longitude = park.Longitude;
            Latitude = park.Latitude;
            WorkingHours = park.WorkingHours;
            CreateDate = park.CreateDate;
            Safety = park.Safety;
            Animals = park.Animals.Select(a => new AnimalModel(a));
            Extras = park.Extras.Select(e => new ExtrasModel(e));
        }
#pragma warning restore CS8618
#pragma warning restore CS8625

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public IList<IFormFile> Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public DateTime CreateDate { get; set; }
        public string Safety { get; set; }

        public IEnumerable<AnimalModel> Animals { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}

