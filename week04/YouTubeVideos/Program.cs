using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all videos objects.
        // This allows the program to manage multiple videos together.
        List<Video> videos = new List<Video>();

        // Create first video object using the default constructor
        Video video1 = new Video();

        // Set the public attributes of the video
        video1._title = "learning C# Basics";
        video1._author = "CodeAcademy";
        video1._lengthInSeconds = 600;

        // Create comments related to the first video.
        Comment c1 = new Comment();
        c1._commenterName = "Alice";
        c1._commenterText = "Very helpful explanation";

        Comment c2 = new Comment();
        c2._commenterName = "Brian";
        c2._commenterText = "This made C# easier to understand.";

        Comment c3 = new Comment();
        c3._commenterName = "Chloe";
        c3._commenterText = "Great intro for beginners.";

        // Add comments to the first video's comment list
        video1._comments.Add(c1);
        video1._comments.Add(c2);
        video1._comments.Add(c3);

        // Add the completed video to the list of videos
        videos.Add(video1);


        // Create the second video object using the default constructor
        Video video2 = new Video();

        // Set the public attributes of the video
        video2._title = "C# while loops";
        video2._author = "Bro code";
        video2._lengthInSeconds = 199;

        // Create comments related to the second video.
        Comment v2c1 = new Comment();
        v2c1._commenterName = "Nathan";
        v2c1._commenterText = "Help!, I am stuck in an infinite loop.";

        Comment v2c2 = new Comment();
        v2c2._commenterName = "Ben";
        v2c2._commenterText = "Descriptive and simple. Thanks.";

        Comment v2c3 = new Comment();
        v2c3._commenterName = "Williams";
        v2c3._commenterText = "Thanks for the video brother.";

        // Add comments to the second video's comment list
        video2._comments.Add(v2c1);
        video2._comments.Add(v2c2);
        video2._comments.Add(v2c3);

        // Add the completed video to the list of videos
        videos.Add(video2);


        // Create the third video object
        Video video3 = new Video();

        // Set video details
        video3._title = "Encapsulation Explained Simply";
        video3._author = "DevSimplified";
        video3._lengthInSeconds = 720;

        // Create comments for the third video
        Comment v3c1 = new Comment();
        v3c1._commenterName = "Grace";
        v3c1._commenterText = "Perfect timing for my programming class.";

        Comment v3c2 = new Comment();
        v3c2._commenterName = "Henry";
        v3c2._commenterText = "The analogies really helped.";

        Comment v3c3 = new Comment();
        v3c3._commenterName = "Ivy";
        v3c3._commenterText = "Short, clear, and easy to follow.";

        // Add comments to the third video
        video3._comments.Add(v3c1);
        video3._comments.Add(v3c2);
        video3._comments.Add(v3c3);

        // Add the video to the list
        videos.Add(video3);


        // Display all videos and comments.
        // Loop through each video in the list
        foreach (Video video in videos)
        {
            // Display video information
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            // Display the number of comments using the method
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            // Loop through and display each comment for the video
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commenterText}");
            }
        Console.WriteLine();
        }
    }
}