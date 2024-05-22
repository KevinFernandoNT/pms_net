using System;


#pragma warning disable CS8618


public class Feedback
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string GuestName { get; set; }
    public string RoomNumber { get; set; }
    public string FeedbackCategory { get; set; }
    public string FeedbackDescription { get; set; }
}
