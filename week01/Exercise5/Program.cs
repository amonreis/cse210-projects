using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the 'DisplayWelcomeMessage' function to display a welcoming message on the screen
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);

        // Call the 'DisplayResult' function and display the user's name and their favorite number squared
        DisplayResult(userName, square);
    }
    static void DisplayWelcomeMessage()
    {   
        // Print a welcome message
        Console.WriteLine("Welcome to the Program!");
    }


    static string PromptUserName()
    {   
        // Prompt the user for their name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    
    static int PromptUserNumber()
    {   
        // Prompt the user for their favorite number.
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }


    static int SquareNumber(int userNumber)
    {
        // Compute the square of a number passed by the user. 
        // Parameters: A number given by the user
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        // Display both the name and number from the user passed in parameters.  
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    

}