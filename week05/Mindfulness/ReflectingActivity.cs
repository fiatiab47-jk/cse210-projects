using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Fields (attributes)
    private List<string> _prompts;     // Stores reflection prompts
    private List<string> _question;     // Stores reflection questions


    // Constructor passes name and description to share fields in the base
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on time in your life when you have shown strength and resilience. This will help you the power and how you can use it in other aspects of your life.")
    {
        // Initialize prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        // Initialize questions
        _question = new List<string>
        {
            "Why was this experience meaningful?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "How can this experience help you in the future?",
            "What is your favorite thing about this experience?",
            "What made this time different than other times when you were not as successful?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // -------------------------------
    // Methods
    // -------------------------------

    // Control the ull flow of the reflection activity
    public void Run()
    {
        // Displays the starting message
        DisplayStartingMessage();

        // Display a random prompt to the user
        DisplayPrompt();


        // Calculate when the activity should end
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Display random questions until the activity ends
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();

        }

        // Display common ending message when duration ends
        DisplayEndingMessage();
    }



    // Get random prompt from the list of prompts
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }


    // Returns a random question form the list of questions
    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _question[random.Next(_question.Count)];
    }


    // Displays a random prompt to the console
    private void DisplayPrompt()
    {
        // Display the instruction to the user
        Console.WriteLine("Consider the following prompt:\n");

        // Display the randomly selected prompt
        Console.WriteLine($"----- {GetRandomPrompt()}-----\n");

        // pause to allow thinking time and press enter when ready to continue
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();

        // Ask user to ponder on the some random questions
        Console.Write("Now ponder on each of the following questions as they relate to this experience. ");
        // display countdown timer before revealing questions 
        ShowCountDown(4);

        // Clear the console before questions
        Console.Clear();

    }


    // Displays a random   question to the console
    private void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion() );
        // pause with spinner before next question
        ShowSpinner(5);
        Console.WriteLine("         ");

    }

}

