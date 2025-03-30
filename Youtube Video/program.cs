using System;
using System.Collections.Generic;
using VideoApp;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating videos
        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you cover more examples?"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C#", "Jane Smith", 1200);
        video2.AddComment(new Comment("David", "Loved this explanation!"));
        video2.AddComment(new Comment("Eve", "Could you do one on LINQ?"));
        video2.AddComment(new Comment("Frank", "Super informative!"));
        videos.Add(video2);

        Video video3 = new Video("C# Design Patterns", "Chris Brown", 900);
        video3.AddComment(new Comment("Grace", "This made OOP so clear!"));
        video3.AddComment(new Comment("Hank", "Best video on the topic."));
        video3.AddComment(new Comment("Ivy", "Subscribed for more!"));
        videos.Add(video3);

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
