namespace Design_Patterns_C_Sharp.Strategy;

public class CalculateOrderFreightsNormal:IShippingService
{
    public double CalculateShippingCost(double price)
    {
       return price * 0.5;
    }
}


public class CalculateOrderFreightsSmall:IShippingService
{
    public double CalculateShippingCost(double price)
    {
        return price * 0.1;
    }
}


public class CalculateOrderFreightsBig:IShippingService
{
    public double CalculateShippingCost(double price)
    {
        return price * 0.2;
    }
}