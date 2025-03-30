using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comment comment1 = new Comment("John Doe", "What a great video!");
        Comment comment2 = new Comment("Jane Doe", "Fantastic job, it was amazing");
        Comment comment3 = new Comment("Sarah Walton", "Very informative");
        Comment comment4 = new Comment("Mike Brown", "I learned a lot, thanks!");
        Comment comment5 = new Comment("Emily White", "Can't wait for the next one!");
        Comment comment6 = new Comment("Chris Green", "This was really helpful.");
        Comment comment7 = new Comment("Anna Black", "Great explanation!");
        Comment comment8 = new Comment("Tom Blue", "I love this series!");

        Video video1 = new Video("Learning C#", "John Doe", 10.5);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 15.0);
        Video video3 = new Video("C# for Beginners", "Alice Johnson", 8.0);
        Video video4 = new Video("C# Best Practices", "Bob Brown", 12.0);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Displaying information for each video
        int videoCount = 1; 

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video {videoCount++}\n¯¯¯¯¯¯¯");
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}\n");
        }
    }
}

