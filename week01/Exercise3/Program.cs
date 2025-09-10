using System;

class Program
{
    static void Main(string[] args)
    {
        // Get a random number from the computer 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        int attempts = 0;
        int guess = -1;
        string response = "yes";
        
        // Kepp looping as long as the user types "yes"
        while (response == "yes")
        {
            // Prompt the user for a number
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Keep track of how man guesses the user has made
            attempts += 1;

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                
                // Display the total number of attempts the user made until guesses the number
                Console.WriteLine($"It took you a total of {attempts} attempts.");

                // Ask the user if they want to play again
                Console.WriteLine("Would you like to play again? ");
                response = Console.ReadLine();
                    if (response == "yes")
                    {
                        // Generate a new random number
                        number = randomGenerator.Next(1, 100);
                        // Reset the attempts 
                        attempts = 0;
                    }
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}