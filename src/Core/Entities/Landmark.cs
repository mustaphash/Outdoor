namespace Core.Entities
{
    public class Landmark : Outdoor
    {
        public Landmark()
        {
            Extras = new List<Extras>();
        }
        public ICollection<Extras> Extras { get; set; }
    }
}
