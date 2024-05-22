using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/revenue")]
[ApiController]
public class RevenueController : ControllerBase
{
    [HttpGet("occupancyRate")]
    public ActionResult<IEnumerable<OccupancyRate>> GetOccupancyRate()
    {
        var occupancyRates = new List<OccupancyRate>
        {
            new OccupancyRate { Day = "MON", Rate = 0.2 },
            new OccupancyRate { Day = "TUE", Rate = 0.4 },
            new OccupancyRate { Day = "WED", Rate = 0.6 },
            new OccupancyRate { Day = "THU", Rate = 0.8 },
            new OccupancyRate { Day = "FRI", Rate = 0.6 },
            new OccupancyRate { Day = "SAT", Rate = 0.4 },
            new OccupancyRate { Day = "SUN", Rate = 0.2 }
        };
        return Ok(occupancyRates);
    }

    [HttpGet("revenueData")]
    public ActionResult<IEnumerable<RevenueData>> GetRevenueData()
    {
        var revenueData = new List<RevenueData>
        {
            new RevenueData { Date = new DateTime(2023, 8, 30), TotalRevenue = 1.2, AverageRoomRevenue = 1.1 },
            new RevenueData { Date = new DateTime(2023, 9, 15), TotalRevenue = 1.8, AverageRoomRevenue = 1.6 },
            new RevenueData { Date = new DateTime(2023, 9, 30), TotalRevenue = 2.0, AverageRoomRevenue = 1.9 },
        };
        return Ok(revenueData);
    }

    [HttpGet("dailyStatistics/{date}")]
    public ActionResult<DailyStatistics> GetDailyStatistics(DateTime date)
    {
        var dailyStatistics = new DailyStatistics
        {
            Date = date,
            RoomRevenue = 3665.61,
            TotalRevenue = 3981.00,
            Occupation = 1256.00,
            ADR = 305.47,
            RevPar = 156.64,
            Pax = 1238.00
        };
        return Ok(dailyStatistics);
    }

    [HttpGet("occupancyStatistics/{occurence?}")]
    public ActionResult<IEnumerable<MonthlyOccupancyStatistics>> GetMonthlyOccupancyStatistics(string? occurence = "Daily")
    {
        var occupancyStatistics = new List<MonthlyOccupancyStatistics>
        {
            new MonthlyOccupancyStatistics { Month = "May", OccupancyRate = 0.5 },
            new MonthlyOccupancyStatistics { Month = "Jun", OccupancyRate = 0.6 },
            new MonthlyOccupancyStatistics { Month = "Jul", OccupancyRate = 0.7 },
            new MonthlyOccupancyStatistics { Month = "Aug", OccupancyRate = 0.8 },
            new MonthlyOccupancyStatistics { Month = "Sep", OccupancyRate = 0.9 },
            new MonthlyOccupancyStatistics { Month = "Oct", OccupancyRate = 1.0 },
            new MonthlyOccupancyStatistics { Month = "Nov", OccupancyRate = 0.95 },
            new MonthlyOccupancyStatistics { Month = "Dec", OccupancyRate = 1.0 },
            new MonthlyOccupancyStatistics { Month = "Jan", OccupancyRate = 1.0 },
            new MonthlyOccupancyStatistics { Month = "Feb", OccupancyRate = 1.0 }
        };
        return Ok(occupancyStatistics);
    }
}
