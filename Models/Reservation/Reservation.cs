using System;

namespace PMS_NET1.Models.Reservation
{
        #pragma warning disable CS8618

    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string GuestName { get; set; }
        public string RoomName { get; set; }
        public int NumberOfGuests { get; set; }
        public string RoomStatus { get; set; }
        public string Referral { get; set; }
    }

}
