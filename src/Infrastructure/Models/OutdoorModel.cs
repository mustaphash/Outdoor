﻿using Core.Entities;
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
#pragma warning disable CS8618
#pragma warning disable CS8625
        public OutdoorModel(Outdoor outdoor)
        {
            Id = outdoor.Id;
            Name = outdoor.Name;
            Description = outdoor.Description;
            Year = outdoor.Year;
            Image = null;
            Longitude = outdoor.Longitude;
            Latitude = outdoor.Latitude;
            WorkingHours = outdoor.WorkingHours;
            CreateDate = outdoor.CreateDate;
        }
#pragma warning restore CS8625
#pragma warning restore CS8618

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
