// Controllers/ReportsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Reports; 
using System.Collections.Generic;

namespace PMS_NET1.Controllers
{
    [Route("reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        // Mock data for demonstration
        private static List<OccupancyReport> OccupancyReports = new List<OccupancyReport>
        {
            new OccupancyReport { Date = DateTime.Now, TotalRooms = 100, OccupiedRooms = 80, AvailableRooms = 20 }
        };

        private static List<FinancialReport> FinancialReports = new List<FinancialReport>
        {
            new FinancialReport { Date = DateTime.Now, TotalIncome = 10000, TotalExpense = 5000, NetProfit = 5000 }
        };

        private static List<MaintenanceReport> MaintenanceReports = new List<MaintenanceReport>
        {
            new MaintenanceReport { Date = DateTime.Now, TotalRequests = 10, CompletedRequests = 8, PendingRequests = 2 }
        };

        // GET: reports/occupancy
        [HttpGet("occupancy")]
        public ActionResult<IEnumerable<OccupancyReport>> GetOccupancyReports()
        {
            return Ok(OccupancyReports);
        }

        // GET: reports/financial
        [HttpGet("financial")]
        public ActionResult<IEnumerable<FinancialReport>> GetFinancialReports()
        {
            return Ok(FinancialReports);
        }

        // GET: reports/maintenance
        [HttpGet("maintenance")]
        public ActionResult<IEnumerable<MaintenanceReport>> GetMaintenanceReports()
        {
            return Ok(MaintenanceReports);
        }
    }
}
