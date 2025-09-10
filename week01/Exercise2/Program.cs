using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that determines the letter grade for a course according to the grade percentage:
        Console.WriteLine("What is your grade percentage?");
        Console.Write(">> ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determine the letter grade according to the grade percentage
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        // Determine the sign
        if (grade % 10 >= 7)
        {
            sign = "+";
        }

        else if (grade % 10 <= 3)
        {
            sign = "-";
        }

        // Handle A+, F+, and F- cases
        if (grade >= 97)
        {
            sign = "";
        }

        if (grade < 60)
        {
            sign = "";
        }

        // Display the letter grade along with a message according to the grade percentage
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You have passed the course! Congratulations!");
        }
        else
        {
            Console.WriteLine("You failed the course! Tutoring is available for an additional fee.");
        }
    }
}