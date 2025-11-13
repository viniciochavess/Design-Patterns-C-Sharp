namespace Design_Patterns_C_Sharp.Strategy;

public class Order
{
    public double Price { get; set; }
    public string Description { get; set; }
    public IShippingService ShippingService { get; set; }
   
   public Order(double price, string description, IShippingService shippingService)
    {
        this.Price = price;
        this.Description = description;
        this.ShippingService = shippingService;
    }

    public double CalculateShippingCost()
    {
        return ShippingService.CalculateShippingCost(Price);
    }
}