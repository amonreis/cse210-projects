using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to holds numbers
        List<int> numbers = new List<int>();

        // Ask the user for a series of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;

        // Stop when they enter 0
        while (number != 0)
        {
            // Ask for a number
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                // Append each one to the list
                numbers.Add(number);
            }
            
        }

        // Compute the sum of the numbers in the list
        int total = numbers.Sum();

        // Find the lenght of the list
        int lenght = numbers.Count;
        
        // Compute the average of the numbers in the list
        float average = ((float)total) / lenght;
        
        // Find the maximum, or largest, number in the list.
        int max = numbers[0];

        foreach (int x in numbers)
        {
            if (x > max)
            {
                max = x;
            }
        }

        // Find the smallest positive number
        int smallest = max;
        foreach (int x in numbers)
        {
            if (x > 0)
            {
                if (x < smallest)
                {
                   smallest = x; 
                }
            }
        }

        // Sort the numbers in the list
        numbers.Sort();

        // Display results
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}