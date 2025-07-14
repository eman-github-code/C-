using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎯 Welcome to the Number Guessing Game!");

        bool playAgain = true;

        while (playAgain)
        {
            int maxNumber = SelectDifficulty();
            PlayGame(maxNumber);

            Console.Write("\nDo you want to play again? (y/n): ");
            playAgain = Console.ReadLine().Trim().ToLower() == "y";
        }

        Console.WriteLine("Thanks for playing! Goodbye 👋");
    }

    static int SelectDifficulty()
    {
        Console.WriteLine("\nSelect Difficulty:");
        Console.WriteLine("1. Easy (1–10)");
        Console.WriteLine("2. Medium (1–50)");
        Console.WriteLine("3. Hard (1–100)");

        while (true)
        {
            Console.Write("Enter 1, 2, or 3: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": return 10;
                case "2": return 50;
                case "3": return 100;
                default: Console.WriteLine("Invalid input. Try again."); break;
            }
        }
    }

    static void PlayGame(int max)
    {
        Random rand = new Random();
        int secret = rand.Next(1, max + 1);
        int attempts = 0;
        bool guessed = false;

        Console.WriteLine($"\nI have chosen a number between 1 and {max}. Try to guess it!");

        while (!guessed)
        {
            Console.Write("Your guess: ");
            string guessStr = Console.ReadLine();
            int guess;

            if (!int.TryParse(guessStr, out guess))
            {
                Console.WriteLine("⚠️ Please enter a valid number.");
                continue;
            }

            attempts++;

            if (guess < secret)
                Console.WriteLine("Too low! 📉");
            else if (guess > secret)
                Console.WriteLine("Too high! 📈");
            else
            {
                Console.WriteLine($"🎉 Correct! You guessed it in {attempts} attempts.");
                guessed = true;
            }
        }
    }
}
