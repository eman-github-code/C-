using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("⏱️ Simple Stopwatch");
        Console.WriteLine("Press any key to START...");
        Console.ReadKey(); // Wait for start

        DateTime startTime = DateTime.Now;
        Console.WriteLine("\nStopwatch started. Press any key to STOP...");
        Console.ReadKey(); // Wait for stop

        DateTime endTime = DateTime.Now;
        TimeSpan elapsed = endTime - startTime;

        Console.WriteLine($"\n⏲️ Elapsed Time: {elapsed.TotalSeconds:F2} seconds");
    }
}
