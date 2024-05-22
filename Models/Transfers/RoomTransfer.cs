    #pragma warning disable CS8618


public class RoomTransfer
{
    public int Id { get; set; }
    public string Name { get; set; } // Guest's name
    public string CurrentRoomNumber { get; set; } // Current room number
    public string NewRoomNumber { get; set; } // New room number
    public string ReasonForMove { get; set; } // Reason for the room move
    public DateTime FromDate { get; set; } // Date when the move starts
    public DateTime ToDate { get; set; } // Date when the move ends
}
