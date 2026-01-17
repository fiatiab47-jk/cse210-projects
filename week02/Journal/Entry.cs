using System;

public class Entry
{
    // Attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    // Method
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(" ");
    }
}