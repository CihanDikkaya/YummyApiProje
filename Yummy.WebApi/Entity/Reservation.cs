namespace Yummy.WebApi.Entity
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
        public string ReservationStatus { get; set; }

    }
}
