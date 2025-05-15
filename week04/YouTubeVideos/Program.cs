using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "John Doe", 600);
        Video video2 = new Video("Advanced LINQ Tutorial", "Jane Smith", 1200);
        Video video3 = new Video("Unity Game Dev Intro", "GameGuru", 900);
        Video video4 = new Video("Understanding .NET Core", "DevExplained", 750);

        video1.AddComment(new Comment("Alice", "This was really helpful!", DateTime.Now));
        video1.AddComment(new Comment("Bob", "Thanks for this tutorial!", DateTime.Now));
        video1.AddComment(new Comment("Charlie", "Could you do one on interfaces?", DateTime.Now));

        video2.AddComment(new Comment("Dana", "LINQ is so powerful!", DateTime.Now));
        video2.AddComment(new Comment("Eli", "I learned so much.", DateTime.Now));
        video2.AddComment(new Comment("Fay", "Can you show some real-world examples?", DateTime.Now));

        video3.AddComment(new Comment("George", "Perfect for beginners!", DateTime.Now));
        video3.AddComment(new Comment("Hannah", "Subbed to your channel!", DateTime.Now));
        video3.AddComment(new Comment("Ian", "More Unity content please!", DateTime.Now));

        video4.AddComment(new Comment("Jack", ".NET Core demystified, thank you!", DateTime.Now));
        video4.AddComment(new Comment("Kelly", "Great explanation.", DateTime.Now));
        video4.AddComment(new Comment("Liam", "Looking forward to more!", DateTime.Now));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.display();
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine(new string('-', 40));
        }
    }
}