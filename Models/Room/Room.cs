// Models/Room.cs
namespace PMS_NET1.Models.Room
{
    #pragma warning disable CS8618

    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }

    #pragma warning restore CS8618

}
