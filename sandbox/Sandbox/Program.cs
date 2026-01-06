using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is in C#.");

        Console.WriteLine("What is your favorite music? ");
        string music = Console.ReadLine();
        Console.WriteLine($"Your favorite music is {music}");
    }
}