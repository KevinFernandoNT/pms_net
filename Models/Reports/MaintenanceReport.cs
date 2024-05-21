namespace PMS_NET1.Models.Reports
{
    public class MaintenanceReport
    {
        public DateTime Date { get; set; }
        public int TotalRequests { get; set; }
        public int CompletedRequests { get; set; }
        public int PendingRequests { get; set; }
    }
}