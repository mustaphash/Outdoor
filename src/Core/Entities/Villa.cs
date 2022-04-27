namespace Core.Entities
{
    public class Villa : Outdoor
    {
        public Villa()
        {
            Extras = new List<Extras>();
        }

        public int RoomCount { get; set; }

        public int GuestCount { get; set; }

        public int ParkingCount { get; set; }

        public ICollection<Extras> Extras { get; set; }
    }
}
