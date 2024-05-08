using System;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "What was the most fun thing I did today?",
        "What was something important I learn today?",
        "Write a short story that you would like your children and grandchildren to remember you by.",
        "What were the highlights of my day?",
        "What did I accomplish today?",
        "What are some things I want to remember about today?"
    };

    public string GetRandomPrompt()
    {
        // Check the lenght of the list
        int length = _prompts.Count();

        if (length > 0)
        {
            // Create a new instance of the System class "Random"
            Random rand = new Random();

            // Select a random number with the same length as the list
            int randprompt = rand.Next(0, length);
            string prompt = _prompts[randprompt];

            // Return the randomly selected prompt
            return prompt;
        }

        return "There are no prompts left";
    }
}