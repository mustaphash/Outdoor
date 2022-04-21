namespace Core.Entities
{
    public class Villa : Outdoor
    {
        public int RoomCount { get; set; }
        public bool WiFi { get; set; }
        public bool Electricity { get; set; }
        public int ParkingCount { get; set; }
    }
}
