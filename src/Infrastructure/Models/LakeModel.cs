using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class LakeModel
    {
      // public LakeModel()
      // {
      //     Name = String.Empty;
      //     Description = String.Empty;
      //     Image = new List<IFormFile>();
      // }
#pragma warning disable CS8625
#pragma warning disable CS8618 
        public LakeModel(Lake lake)
        {
            Id = lake.Id;
            Name = lake.Name;
            Description = lake.Description;
            Year = lake.Year;
            Image = null;
            Longitude = lake.Longitude;
            Latitude = lake.Latitude;
            WorkingHours = lake.WorkingHours;
            CreateDate = lake.CreateDate;
            Animals = lake.Animals.Select(a => new AnimalModel(a));
            Extras = lake.Extras.Select(e => new ExtrasModel(e));
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

        public IEnumerable<AnimalModel> Animals { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}
