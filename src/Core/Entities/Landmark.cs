namespace Core.Entities
{
    public class Landmark : Outdoor
    {
#pragma warning disable CS8618
        public Landmark()
        {
        }
#pragma warning restore CS8618

        public ICollection<Extras> Extras { get; set; }
    }
}
