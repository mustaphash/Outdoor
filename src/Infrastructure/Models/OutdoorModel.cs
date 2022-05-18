using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class OutdoorModel
    {
        public OutdoorModel()
        {
            Name = String.Empty;
            Description = String.Empty;
            Image = new List<IFormFile>();
        }
        public OutdoorModel(Outdoor outdoor)
        {
            Id = outdoor.Id;
            Name = outdoor.Name;
            Description = outdoor.Description;
            Year = outdoor.Year;
            Image = null;
         //foreach (var file in Image)
         //{
         //    if (file.Length > 0)
         //    {
         //        using (var ms = new MemoryStream())
         //        {
         //            file.CopyTo(ms);
         //            var fileBytes = ms.ToArray();
         //            string s = Convert.ToBase64String(fileBytes);
         //            // act on the Base64 data
         //        }
         //    }
         //}
            Longitude = outdoor.Longitude;
            Latitude = outdoor.Latitude;
            WorkingHours = outdoor.WorkingHours;
            CreateDate = outdoor.CreateDate;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public IList<IFormFile> Image { get; set; }


        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public DateTime CreateDate { get; set; }

        public Outdoor ToOutdoor()
        {
            return new Outdoor
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Year = Year,
                Longitude = Longitude,
                Latitude = Latitude,
                WorkingHours = WorkingHours,
                CreateDate = DateTime.Now,
            };

        }
    }
}
