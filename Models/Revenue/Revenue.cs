#pragma warning disable CS8618

public class OccupancyRate
{
    public string Day { get; set; }
    public double Rate { get; set; }
}

public class RevenueData
{
    public DateTime Date { get; set; }
    public double TotalRevenue { get; set; }
    public double AverageRoomRevenue { get; set; }
}

public class DailyStatistics
{
    public DateTime Date { get; set; }
    public double RoomRevenue { get; set; }
    public double TotalRevenue { get; set; }
    public double Occupation { get; set; }
    public double ADR { get; set; }
    public double RevPar { get; set; }
    public double Pax { get; set; }
}

public class MonthlyOccupancyStatistics
{
    public string Month { get; set; }
    public double OccupancyRate { get; set; }
}
