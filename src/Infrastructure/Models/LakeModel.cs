using Core.Entities;
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
        //     Name = string.Empty;
        //     Description = string.Empty;
        //     Image = Array.Empty<byte>();
        // }

        public LakeModel(Lake lake)
        {
            Id = lake.Id;
            Name = lake.Name;
            Description = lake.Description;
            Year = lake.Year;
            Image = lake.Image;
            Longitude = lake.Longitude;
            Latitude = lake.Latitude;
            WorkingHours = lake.WorkingHours;
            CreateDate = lake.CreateDate;
            Animals = lake.Animals.Select(a => new AnimalModel(a));
            Extras = lake.Extras.Select(e => new ExtrasModel(e));
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public byte[] Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public DateTime CreateDate { get; set; }

        public IEnumerable<AnimalModel> Animals { get; set; }

        public IEnumerable<ExtrasModel> Extras { get; set; }
    }
}
