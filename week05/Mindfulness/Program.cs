using System;

class Program
{
    static void Main(string[] args)
    {
        // Stores the user's menu choice
        string choice = "";

        // This while loop keeps the program running until 
        // user chooses option "4" to quit
        while (choice != "4")
        {
            // Clear the console for a clean menu display
            Console.Clear();

            // Display menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            // Ask user to select an option
            Console.Write("Select a choice form the menu: ");
            choice = Console.ReadLine();

            // Use if/else logic to run the selected activity
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {
                // Exit message
                Console.WriteLine("Goodbye!");
            }
            else
            {
                // Handles invalid input
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }
            // Pause before returning to menu
            if (choice != "4")
            {
                Console.WriteLine("\nReturning to the menu.");
            }

        }

    }
}