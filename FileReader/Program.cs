using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("📂 File Reader");
        Console.Write("Enter the full file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            Console.WriteLine("\n📄 File Contents:\n");
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("\n❌ File not found. Please check the path and try again.");
        }
    }
}
