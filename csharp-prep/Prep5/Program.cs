using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call the PromptUserName function and store it in a variable
        string userName = PromptUserName();

        // Call the PromptUserNumber function and store it in a variable
        int userNumber = PromptUserNumber();

        // Call the SquareNumber function and store it in a variable
        int squaredNumber = SquareNumber(userNumber);

        // Call the DisplayResult function
        DisplayResult(userName, squaredNumber);


        // Display the message, "Welcome to the Program!"
        static void  DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Ask for and return the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        // Ask for and return the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        // Accept an integer as a parameter and return that number squared (as an integer)
        static int SquareNumber (int number)
        {
            int squared = number * number;
            return squared;
        }

        // Accepts the user's name and the squared number and displays them
        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }
}