namespace PMS_NET1.Models.Reports
{
    public class OccupancyReport
    {
        public DateTime Date { get; set; }
        public int TotalRooms { get; set; }
        public int OccupiedRooms { get; set; }
        public int AvailableRooms { get; set; }
    }
}
