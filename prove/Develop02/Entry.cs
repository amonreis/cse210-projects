using System;

public class Entry 
{
    public string _prompt;
    public string _entry;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entry}");
    }


}