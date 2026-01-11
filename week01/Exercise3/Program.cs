using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate Random number
        Random random = new Random();
        int magicNumber = random.Next(1, 101); 

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        int guessCount = 1;

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;
        }

        Console.WriteLine($"You guessed it in {guessCount} guesses!");
    }    
}