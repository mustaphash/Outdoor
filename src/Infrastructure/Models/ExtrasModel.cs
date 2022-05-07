using Core.Entities;

namespace Infrastructure.Models
{
    public class ExtrasModel
    {

        public ExtrasModel(Extras extras)
        {
            Id = extras.Id;
            Name = extras.Name;
            Description = extras.Description;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
