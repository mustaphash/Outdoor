﻿using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models.CreateModels
{
    public class CreateFountainsModel
    {
#pragma warning disable CS8618
#pragma warning disable CS8625
        public CreateFountainsModel()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = null;
            InMemoryOf = string.Empty;
        }
#pragma warning restore CS8625
#pragma warning restore CS8618

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public IFormFile Image { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int WorkingHours { get; set; }

        public string InMemoryOf { get; set; }

        public int WaterTypeId { get; set; }

        public List<int> Extras { get; set; }

        public Fountain ToFountain()
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
            return new Fountain
            {
                Name = Name,
                Description = Description,
                Year = Year,
                Image = fileBytes,
                Longitude = Longitude,
                Latitude = Latitude,
                WorkingHours = WorkingHours,
                CreateDate = DateTime.Now,
                InMemoryOf = InMemoryOf,
                WaterTypeId = WaterTypeId
            };

        }
    }
}
