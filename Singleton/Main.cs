using System;
namespace Singleton;



public class ProgramSingleton
{
    public static void MainSingleton(string[] args)
    {
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();

        if (instance1 == instance2)
        {
            Console.WriteLine("Both instances are the same.");
        }
    }
}