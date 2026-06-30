using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        Random randomGenerator = new Random();

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int guessCount = 0;

            // Keep asking until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display the number of guesses
            Console.WriteLine($"You guessed it in {guessCount} guesses.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
