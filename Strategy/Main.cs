using System;
using Design_Patterns_C_Sharp.Strategy;

namespace Strategy;



public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new CalculateOrderFreightsSmall();
        var order = new Order(777.2, "Tv Smart", calculator);
        double price = order.CalculateShippingCost();
        Console.WriteLine(price);
    }
}