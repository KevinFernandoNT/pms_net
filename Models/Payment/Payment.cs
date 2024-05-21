// Models/Payment.cs
namespace PMS_NET1.Models.Payment
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }
}
