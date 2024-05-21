// Models/Notification.cs
namespace PMS_NET1.Models.Notification
{
        #pragma warning disable CS8618
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
    }
        #pragma warning restore CS8618
}
