namespace PMS_NET1.Models.Reports
{
    public class FinancialReport
    {
        public DateTime Date { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal NetProfit { get; set; }
    }

}