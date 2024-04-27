using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a radom number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // Declare a variable to store the user guess
        int guess;

        // Keep track of how many guesses the user has made
        int attempts = 1;

        // Play again
        string playAgain = "yes";

        // Loop until the user guesses the number
        while (playAgain.ToLower() == "yes")
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Determine if the user needs to guess higher or lower next time
            if (guess > magicNumber)
            {
                attempts += 1;
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                attempts += 1;
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("\nYou guessed it!");
                Console.WriteLine($"It took {attempts} attempt(s) to guess it");
                // Ask the user if they want to play again.
                Console.Write("\nDo you want to play again? (yes/no)\n>> ");
                playAgain = Console.ReadLine();

                if (playAgain.ToLower() == "yes")
                {
                    magicNumber = randomGenerator.Next(1, 100);
                    attempts = 1;
                }
            }
        }
        

    }  
}