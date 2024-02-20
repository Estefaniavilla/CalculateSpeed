using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the distance traveled (in meters): ");
        float distance = float.Parse(Console.ReadLine());

        Console.Write("Enter the time taken (in seconds): ");
        float time = float.Parse(Console.ReadLine());

        // fórmula v = d/t
        float speed = distance / time;

        
        Console.WriteLine($"The speed is: {speed} [m/s]");
    }
}
