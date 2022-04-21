namespace Core.Entities
{
    public class LandmarkType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Height { get; set; }

        public ICollection<Landmark> Landmarks { get; set; }
    }
}
