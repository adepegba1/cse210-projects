using System;

class Program
{
    static void Main(string[] args)
    {

        // Create a video
        Video video1 = new Video("Learning C#", "David", 600);

        // Add comments
        video1.AddComment(new Comment("Alice", "This video was super helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation, thank you."));
        video1.AddComment(new Comment("Charlie", "Can you also cover interfaces?"));

        // Display video info
        video1.DisplayVideo();
        Console.WriteLine();

        Video video2 = new Video("Cooking Jollof Rice", "Alice", 450);

        // Add comments
        video2.AddComment(new Comment("David", "Nice Video!"));
        video2.AddComment(new Comment("John", "I love your video"));
        video2.AddComment(new Comment("Smith", "Trying this tonight"));
        video2.AddComment(new Comment("Jane", "Whoa, my husband love the Jollof Rice I did yesterday with the help of your video. Thank you!"));

        video2.DisplayVideo();
        Console.WriteLine();

        Video video3 = new Video("SQL Programming for beginners", "Adepegba David", 3600);

        video3.AddComment(new Comment("James", "Watching from Canada"));
        video3.AddComment(new Comment("Debby", "Nice work, I love your video"));
        video3.AddComment(new Comment("Kola", "I understand SQL very well now. Thank you"));
        video3.AddComment(new Comment("Ola", "You explained the basic of SQL that a beginner should know."));
        video3.AddComment(new Comment("Tunji", "Whoa, nice video. Can you do video on Python too"));
        video3.AddComment(new Comment("Sarah", "Awesome, I love the video😍😍"));

        video3.DisplayVideo();
        Console.WriteLine();
    }
}