using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class VillaModel
    {

#pragma warning disable CS8625
#pragma warning disable CS8618
        public VillaModel(Villa villa)
        {
            Id = villa.Id;
            Name = villa.Name;
            Description = villa.Description;
            Year = villa.Year;
            Image = null;
            Longitude = villa.Longitude;
            Latitude = villa.Latitude;
            WorkingHours = villa.WorkingHours;
            CreateDate = villa.CreateDate;
            RoomCount = villa.RoomCount;
            GuestCount = villa.GuestCount;
            ParkingCount = villa.ParkingCount;
            Extras = villa.Extras.Select(e => new ExtrasModel(e));
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

        public int RoomCount { get; set; }

        public int GuestCount { get; set; }

        public int ParkingCount { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}
