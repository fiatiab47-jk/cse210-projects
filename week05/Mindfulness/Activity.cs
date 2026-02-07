using System;
using System.Threading;

// The System.Threading namespace is used to access the Thread class,
// which allows us to pause the program for a set amount of time.
using System.Threading;

// Base class containing shared attributes and behaviors
public class Activity
{
    // Attributes
    private string _name;
    private string _description;
    protected int _duration;

    // Constructor to set name and description from the derived class
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Show the starting message and ask for duration
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long in seconds would you like your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        // Pause program for 5 seconds while rotating spinner
        ShowSpinner(5);
        Console.WriteLine("     ");
    }

    // Show ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");
        ShowSpinner(3);
        Console.WriteLine($"You completed another {_duration} seconds of the {_name} activity .");
        ShowSpinner(3);
        Console.WriteLine("     ");
    }

    // Spinner animation for delays
    protected void ShowSpinner(int seconds)
    {
        // Array of characters that make up the spinner animation
        string[] spinner = { "|", "/", "-", "\\" };
        // Calculates when the spinner should stop
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // Keeps track of which spinner character to show next
        int index = 0;

        // Loop keeps running until the current time reaches endTime
        while (DateTime.Now < endTime)
        {
            // Prints the current spinner to the console
            Console.Write(spinner[index]);

            // Pauses the program for _ milliseconds
            // Makes spinner visible before switching to the next character 
            // Without this spinner will change to fast to see
            Thread.Sleep(250);
            // Moves the cursor back one position so the next spinner character
            // overwrites the current one instead of printing on a new space
            Console.Write("\b");
            // Advances to the next spinner character and wraps back to the start
            // when the end of the spinner array is reached.
            // Example: if index = 3 (last character \) → (3+1) % 4 = 0 → back to "|"
            index = (index + 1) % spinner.Length;
        }
        // Console.WriteLine();
    }

    // Countdown animation
    public void ShowCountDown(int seconds)
    {
        // Loop starts at the number of seconds and counts down to 1
        for (int i = seconds; i > 0; i--)
        {
            // Displays the current countdown number on the console
            Console.Write(i);
            // Pauses the program for 1 seconds (5000 milliseconds)
            Thread.Sleep(1000);
            // Erases the previously printed number from the console
            // \b moves the cursor back, space clears the character, \b moves back again
            Console.Write("\b \b");
        }
    }
}