using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        Console.Write(">> ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        Console.Write(">>");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");


    }
}