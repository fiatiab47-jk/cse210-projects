using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Stretch
        // This program use a small library of scriptures and 
        // randomly selects one each time the program runs.

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Exodus", 16, 1, 2),

            @"And they took their journey from Elim, and all the congregation
            of the children of Israel came unto the wilderness of Sin, which is between Elim
            and Sinai, on the fifteenth day of the second month after their departing out of
            the land of Egypt. And the whole congregation of the children of Israel murmured
            against Moses and Aaron in the wilderness."
        ));

        scriptures.Add(new Scripture(new Reference("John", 3, 16),
            @"For God so loved the world that he gave his only begotten Son, that whosoever
            believeth in him should not perish, but have everlasting life."
        ));

        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            @"Trust in the Lord with all thine heart and lean not unto thine own understanding. 
            In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        scriptures.Add(new Scripture(new Reference("Genesis", 49, 8, 9),
            @"Judah, thou art he whom thy brethren shall praise; thy hand shall be in the neck of
            thine enemies; thy father's children shall bow down before thee. Judah is lion's whelp; 
            from the prey, my son, thou art gone up; he stoop down, he couched as a lion, and 
            as an old lion; who shall rouse him up?                      "
        ));

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];


        while (true)
        {
            Console.Clear();
            // Display scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit");
            string input = Console.ReadLine();
            // Check for quit
            if (input.ToLower() == "quit")
                break;

            // Hide a few random words each round
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words have been hidden. Good job!");
                break;
            }
        }
    }
}