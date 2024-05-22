namespace  PMS_NET1.Models.Room
{
    #pragma warning disable CS8618

    public class Room
{
    public int RoomNumber { get; set; }
    public string BedType { get; set; }
    public int RoomFloor { get; set; }
    public string RoomType { get; set; }
    public string Basis { get; set; }
    public List<string> RoomFacilities { get; set; }
    public string Status { get; set; }
}
}

