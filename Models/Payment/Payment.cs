// Models/Payment.cs
namespace PMS_NET1.Models.Payment
{
    #pragma warning disable CS8618

    public class Payment
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }

    #pragma warning restore CS8618
}
