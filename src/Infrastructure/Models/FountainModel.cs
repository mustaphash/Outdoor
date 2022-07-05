using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class FountainModel
    {
#pragma warning disable CS8625
#pragma warning disable CS8618
        public FountainModel(Fountain fountain)
        {
            Id = fountain.Id;
            Name = fountain.Name;
            Description = fountain.Description;
            Year = fountain.Year;
            Image = null;
            Longitude = fountain.Longitude;
            Latitude = fountain.Latitude;
            WorkingHours = fountain.WorkingHours;
            CreateDate = fountain.CreateDate;
            InMemoryOf = fountain.InMemoryOf;
            WaterType = fountain.WaterType.Name;
            Extras = fountain.Extras.Select(e => new ExtrasModel(e));
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

        public string InMemoryOf { get; set; }

        public string WaterType { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }

    }
}
