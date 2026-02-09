using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Counts how many items the user lists
    private int _count;

    // Stores listing prompts
    private List<string> _prompts;




    // Constructor;  Constructor passes name and description to share fields in the base
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // Initialize the count of listed items to zero
        _count = 0;


        // Initialize prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }




    // Run method – controls the flow of the activity
    public void Run()
    {
        // Displays the common starting message
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt.");

        // Display a random prompt
        GetRandomPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        // Prints on a new line
        Console.WriteLine("");

        GetListFromUser();

       
        // Display how many items the user listed
        Console.WriteLine($"\nYou listed {_count} items!");

        // Display the common ending message
        DisplayEndingMessage();
    }



    // Selects and displays a random prompt
    private void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"-----{prompt}-----");
    }

    private List<string> GetListFromUser()
    {
        List<string> userItems = new List<string>();

        // Determine when the activity should end
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Keep accepting input until time is up
        while (DateTime.Now < endTime)
        {
            // Prompt the user to enter an item
            Console.Write("> ");
            // Read the user input
            string input = Console.ReadLine();

            // Only count non-empty responses
            if (!string.IsNullOrWhiteSpace(input))
            {
                userItems.Add(input);
                _count++;
            }
        }

        // Return the list of user-entered items
        return userItems;
    }
    
}
