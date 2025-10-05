using System;
namespace Singleton;



public class Program
{
    public static void Main(string[] args)
    {
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();

        if (instance1 == instance2)
        {
            Console.WriteLine("Both instances are the same.");
        }
    }
}