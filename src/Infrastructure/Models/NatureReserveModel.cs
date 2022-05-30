using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models.CreateModels
{
    public class NatureReserveModel
    {
#pragma warning disable CS8625
#pragma warning disable CS8618
        public NatureReserveModel(NatureReserve natureReserve)
        {
            Id = natureReserve.Id;
            Name = natureReserve.Name;
            Description = natureReserve.Description;
            Year = natureReserve.Year;
            Image = null;
            Longitude = natureReserve.Longitude;
            Latitude = natureReserve.Latitude;
            WorkingHours = natureReserve.WorkingHours;
            CreateDate = natureReserve.CreateDate;
            Size = natureReserve.Size;
            Animals = natureReserve.Animal.Select(a => new AnimalModel(a));
            Extras = natureReserve.Extras.Select(e => new ExtrasModel(e));
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

        public double Size { get; set; }

        public IEnumerable<AnimalModel> Animals { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}
