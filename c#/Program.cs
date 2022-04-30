using System;

// RUN COMMAND
// csc Program.cs && mono Program.exe

namespace NumberGuesser
{
  class Program
  {
    public static void Main(string[] args)
    {
      string appName = "Number Guesser";
      string appVersion = "1.0.0";
      string appAuthor = "Richard Amare";

      Console.ForegroundColor = ConsoleColor.Green;

      Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

      Console.ResetColor();

      Console.WriteLine("What's your name?");

      string name = Console.ReadLine();

      Console.WriteLine($"Hello {name}, let's play a game...");

      var random = new Random();
      int correctNumber = random.Next(1, 10);
      int guess = 0;
      int numOfGuesses = 0;

      Console.WriteLine("Guess a number between 1 and 10");

      while (guess != correctNumber)
      {
        string input = Console.ReadLine();

        guess = Int32.Parse(input);

        numOfGuesses += 1;

        if (guess != correctNumber)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Wrong number, please try again");
          Console.ResetColor();
        }
      }

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"Congratulations, you won! It took you {numOfGuesses} guesses");
      Console.ResetColor();
    }
  }
}
