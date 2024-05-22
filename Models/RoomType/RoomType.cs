using System;

namespace PMS_NET1.Models.RoomType

{
    #pragma warning disable CS8618

    public class RoomType
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public Rates Price { get; set; }
        public int Count { get; set; }
        public int AvailableCount { get; set; }
    }
}
