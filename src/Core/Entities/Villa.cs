namespace Core.Entities
{
    public class Villa : Outdoor
    {
#pragma warning disable CS8618 
        public Villa()
        {
        }
#pragma warning restore CS8618

        public int RoomCount { get; set; }

        public int GuestCount { get; set; }

        public int ParkingCount { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
