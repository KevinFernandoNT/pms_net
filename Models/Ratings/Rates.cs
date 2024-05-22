using System;
using PMS_NET1.Models.RoomType;

#pragma warning disable CS8618

public class Rates
{
    public int Id { get; set; } // Unique identifier for the rate
    public string Type { get; set; } // Name of the rate type (e.g., "HDK Direct Rate")
    public decimal CurrentRate { get; set; } // Current rate for the given period
    public DateTime EffectiveFrom { get; set; } // Start of the effective period
    public DateTime EffectiveTo { get; set; } // End of the effective period
    public decimal DefaultRate { get; set; } // Default rate
    public RoomType  RoomType {get; set;}
}
