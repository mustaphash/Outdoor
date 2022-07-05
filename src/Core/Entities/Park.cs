namespace Core.Entities
{
    public class Park : Outdoor
    {

#pragma warning disable CS8618 
        public Park()
        {
        }
#pragma warning restore CS8618

        public string Safety { get; set; }

        public ICollection<Animal> Animals { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
