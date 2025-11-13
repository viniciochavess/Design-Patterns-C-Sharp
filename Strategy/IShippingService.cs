namespace Design_Patterns_C_Sharp.Strategy;

public interface IShippingService
{
    double CalculateShippingCost(double price);
}