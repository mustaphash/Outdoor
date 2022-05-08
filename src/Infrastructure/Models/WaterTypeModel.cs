using Core.Entities;

namespace Infrastructure.Models
{
    public class WaterTypeModel
    {
        public WaterTypeModel(WaterType waterType)
        {
            Id = waterType.Id;
            Name = waterType.Name;
        }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
