namespace Core.Entities
{
    public class Landmark : Outdoor
    {
        public ICollection<LandmarkType> Type { get; set; }
    }
}
