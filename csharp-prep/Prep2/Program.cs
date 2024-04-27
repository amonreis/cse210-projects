using System;
class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage 
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        
        // Convert the user input into a float number
        float percentage = float.Parse(userInput);

        // Define the letter grade
        string letter;

        // Define the sign
        string sign;

        // Calculate the last digit 
        float lastDigit = percentage % 10;

        // Give a sign acording to last digit. Give it a "-" if the last digit is less 
        // than 3. Give it a "+" if it's equal to or greater than 7. 
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Remove "A+" grade
        if (percentage >= 97)
        {
            sign = "";
        }

        // Remove "F+" and "F-" grades
        if (percentage < 60)
        {
            sign = "";
        }

        // Display the letter grade
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        // Display a congratulation message if they passed the course
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("You have not passed the course! Tuition is available for an additional tuition fee");
        }
    }
}

