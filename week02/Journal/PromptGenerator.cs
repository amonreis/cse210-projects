public class PromptGenerator
{

    public List<string> _promptThemes = new List<string>
    {
        "1. Daily Events",
        "2. Dreams and Wishes",
        "3. Goals and Plans",
        "4. Fun Events",
        "5. Communicate gratitude",
        "6. Brainstorming",
        "7. Generics"
    };

    public List<string> _genericPrompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "What am I grateful for today?",
        "What was the most fun thing I did today?",
        "What was something important I learn today?",
        "Write a short story that you would like your children and grandchildren to remember you by.",
        "What were the highlights of my day?",
        "What did I accomplish today?",
        "What are some things I want to remember about today?"
    };
    
    public List<string> _brainstormingPrompts = new List<string>   
    {   
        "What is the current problem or challenge I am facing?",
        "What could be a potential solution to one problem or challenge I currently have?",
        "What are some resources I can utilize to help solve my problems or challenges?",
        "If I could live in any time period or place, where would I choose and why?"
    };  
    
    public List<string> _dailyPrompts = new List<string>    
    {   
        "What are my top priorities for the day?",
        "What did I learn today? How can I apply this knowledge in the future?",
        "What challenges did I face today? How did I overcome them? What can I learn from these experiences?",
        "What was a moment of joy, delight, or contentment today?",
        "What could I have done differently today?"
    };  
    
    public List<string> _dreamPrompts = new List<string>    
    {
        "What was the most memorable dream I had last night?",
        "What are some of the most bizarre or surreal dreams I've ever had?",
        "What do I think my dream is trying to tell me? How can I apply its message to my life?",
        "What is the most common type of dream I have (like nightmares, flying dreams, etc.)?"

    };

    public List<string> _funPrompts = new List<string>
    {
        "If I could have any superpower, what would it be and why?",
        "What is one thing I can't live without?",
        "What is one funny story about my life that I don't mind sharing with other people?",
        "If I could magically switch lives with anyone for a day, who would it be and why?",
        "If I could travel anywhere in the world (or beyond), where would I go and what would I do there?"

    };

    public List<string> _goalSettingPrompts = new List<string>
    {
        "What are my top three goals for the next year?",
        "What is one new habit I would like to develop in the next month?",
        "What resources or support can I seek out to help me achieve my goals?",
        "What is something that is holding me back from achieving my goals?",
        "What are three small, measurable goals I can set for myself this week?"

    };

    public List<string> _gratitudePrompts = new List<string>
    {
        "Who are three people in my life that I am grateful for, and why?",
        "What is something in my life that I feel “lucky” to have?",
        "What is a simple delight I have been enjoying lately?",
        "What is something I am grateful to have learned recently?",
        "What are somethings I am grateful for today?"
    };


    public void DisplayPromptThemes()
    {
        foreach (string theme in _promptThemes)
        {
            Console.WriteLine(theme);
        }
    }

    public string GetRandomPrompt(List<string> listname)
    {
        
        // Check the lenght of the '_generalPrompts' list
        int lenght = listname.Count();
        
        if (lenght > 0)
        {   
            // Create a new instance of the System class 'Random'
            Random rand = new Random();

            // Select a random number with the same lenght as the list 
            int randprompt = rand.Next(0, lenght);
            string prompt = listname[randprompt];

            // return the randomly selected prompt
            return prompt;
             
        }

        return "There are no prompts";

    }

    public string GetDailyPrompts()
    {
        return GetRandomPrompt(_dailyPrompts);
    }

    public string GetBrainstormingPrompts()
    {
        return GetRandomPrompt(_brainstormingPrompts);
    }

    public string GetFunPrompts()
    {
        return GetRandomPrompt(_funPrompts);
    }

    public string GetDreamPrompts()
    {
        return GetRandomPrompt(_dreamPrompts);
    }

    public string GetGoalSettingPrompts()
    {
        return GetRandomPrompt(_goalSettingPrompts);
    }

    public string GetGenericPrompts()
    {
        return GetRandomPrompt(_genericPrompts);
    }

    public string GetGratitudePrompts()
    {
        return GetRandomPrompt(_gratitudePrompts);
    }
        
}