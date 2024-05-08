using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Set the menu and its choices
        string option1 = "1. Write";
        string option2 = "2. Display";
        string option3 = "3. Load";
        string option4 = "4. Save";
        string option5 = "5. Quit";

        // Create a new instance of the Journal class to hold the menu
        Journal menu = new Journal();
        menu._menuOptions.Add(option1);
        menu._menuOptions.Add(option2);
        menu._menuOptions.Add(option3);
        menu._menuOptions.Add(option4);
        menu._menuOptions.Add(option5);

        // Create another instance of the Journal class
        Journal theJournal = new Journal();
        
        // Create a new instance of the PromptGenerator class
        PromptGenerator prompt = new PromptGenerator();  

        // Set the user answer
        int answer = -1;

        // Welcome the user to the Program
        Console.WriteLine("Welcome to the Journal Program!");

        // Keep displaying the menu until the user quit the program
        while (answer != 5)
        {
            Console.WriteLine("Please select one of the following choices:");

            // Display the menu
            menu.DisplayMenu();

            Console.Write("> ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                // Create a new instance of the Entry class
                Entry entry = new Entry();

                // Get the date
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                
                // Get a random prompt and store it in a variable. 
                entry._prompt = prompt.GetRandomPrompt();

                // Display the prompt
                Console.WriteLine(entry._prompt);

                // Allow the user to write an answer
                Console.Write("> ");
                entry._entry = Console.ReadLine();

                // Call the AddEntry function to add the new entry to the entries list
                theJournal.AddEntry(entry);
                
                // Remove the prompt from the "_prompts" list so it doesn't repeat
                prompt._prompts.Remove(entry._prompt);

            }

            else if (answer == 2)
            {
                // If the user selects "2", display all the entries with the prompts and the date
                theJournal.DisplayAll();
            }

            else if (answer == 3)
            {
                // Ask the user for a filename
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                Console.WriteLine("Loading from file...");

                // Load the prompts, and the answers along with the date from a file
                theJournal.LoadFromFile(filename);
            }

            else if (answer == 4)
            {
                // Ask the user for a filename
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                Console.WriteLine("Saving to file...");

                // Save the prompts and the answers, along with the date to a file
                theJournal.SaveToFile(filename);
            }

            else if (answer != 5)
            {
                Console.WriteLine("\nThis is not a valid option, choose a another one (1-5) :)\n");
            }

        }
    }
}