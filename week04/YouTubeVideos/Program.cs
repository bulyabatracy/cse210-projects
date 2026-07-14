using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learn C# in 20 Minutes",
            "Code Academy",
            1200);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Brian", "Very helpful."));
        video1.AddComment(new Comment("Carol", "Thanks for sharing."));

        Video video2 = new Video(
            "Exploring Uganda",
            "Travel Africa",
            850);

        video2.AddComment(new Comment("David", "Beautiful country!"));
        video2.AddComment(new Comment("Emma", "I want to visit someday."));
        video2.AddComment(new Comment("Frank", "Amazing video!"));

        Video video3 = new Video(
            "Healthy Cooking Tips",
            "Kitchen Master",
            960);

        video3.AddComment(new Comment("Grace", "Nice recipe."));
        video3.AddComment(new Comment("Henry", "Looks delicious."));
        video3.AddComment(new Comment("Irene", "I'll try this today."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}

