using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list to store numbers from the user
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;

        // Keep looping until the user types 0
        while (userNumber != 0)
        {
            // Promp the user for a number
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            // If the number is not 0, then add to the list 'numbers'
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        int largestNumber = -1;
        int smallestNumber = 9999;

        // Iterate through the list
        foreach (int number in numbers)
        {   
            // Sum the numbers
            sum += number;

            if (number > largestNumber)
            {
                // Find the largest number in the list
                largestNumber = number;
            }
            
            if (number < smallestNumber && number > 0)
            {
                // Find the smallest number in the list 
                smallestNumber = number;
            }
        }

        // Compute the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        
        // Display the results for the user to see
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        // Sort the numbers in the list and display the sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }    ;
    }
}