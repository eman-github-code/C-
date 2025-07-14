using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        int score = CalculateStrength(password);
        Console.WriteLine("Password Strength: " + GetStrengthLevel(score));
    }

    static int CalculateStrength(string password)
    {
        int score = 0;

        if (password.Length >= 8)
            score++;

        if (Regex.IsMatch(password, "[A-Z]"))
            score++;

        if (Regex.IsMatch(password, "[0-9]"))
            score++;

        if (Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            score++;

        return score;
    }

    static string GetStrengthLevel(int score)
    {
        return score switch
        {
            4 => "Strong",
            3 => "Medium",
            _ => "Weak",
        };
    }
}
