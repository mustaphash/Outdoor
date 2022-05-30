using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class LandmarkModel
    {
#pragma warning disable CS8625
#pragma warning disable CS8618
        public LandmarkModel(Landmark landmark)
        {
            Id = landmark.Id;
            Name = landmark.Name;
            Description = landmark.Description;
            Year = landmark.Year;
            Image = null;
            Longitude = landmark.Longitude;
            Latitude = landmark.Latitude;
            WorkingHours = landmark.WorkingHours;
            CreateDate = landmark.CreateDate;
            Extras = landmark.Extras.Select(e => new ExtrasModel(e));
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

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}
