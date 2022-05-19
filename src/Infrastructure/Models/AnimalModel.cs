using Core.Entities;

namespace Infrastructure.Models
{
    public class AnimalModel
    {
        private AnimalModel a;

        public AnimalModel()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public AnimalModel(Animal animal)
        {
            Id = animal.Id;
            Name = animal.Name;
            Description = animal.Description;
        }

        public AnimalModel(AnimalModel a)
        {
            this.a = a;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
