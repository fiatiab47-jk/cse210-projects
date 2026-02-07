using System;

public class BreathingActivity : Activity
{
    // Constructor passes name and description to shared fields in the base class
    public BreathingActivity() :
    base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ")
    { }

    // Runs Breathing Activity
    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("\nBreathe in... ");
            ShowCountDown(6);
            elapsed += 6;

            if (elapsed >= _duration)
                break;

            Console.Write("Now breathe out...");
            ShowCountDown(4);
            elapsed += 4;
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

}