using System;
#pragma warning disable CS8618

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal BuyingPrice { get; set; }
    public int Quantity { get; set; }
    public int ThresholdValue { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Availability { get; set; } // This can be calculated based on Quantity and ThresholdValue
}
