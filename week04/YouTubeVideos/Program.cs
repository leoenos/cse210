using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("BTS 2.0 Official MV", "Hybe Labels", 234);
        video1.AddComment(new Comment("kimseokjins#1", "Jin looks so good in this MV!"));
        video1.AddComment(new Comment("Jungkook", "Gwenchana"));
        video1.AddComment(new Comment("obssessiveNerd", "Best song on the album."));
        videos.Add(video1);

        Video video2 = new Video("WARNING: SCARIEST GAME IN YEARS | Five Nights at Freddy's - Part 1", "Markiplier", 1063);
        video2.AddComment(new Comment("Fishbach", "Wow! 11 years ago! So funny"));
        video2.AddComment(new Comment("William Afton", "Next time..."));
        video2.AddComment(new Comment("obssessiveNerd", "A saga begins."));
        videos.Add(video2);

        Video video3 = new Video("I Opened My Own Waterpark...", "CaseOh", 4173);
        video3.AddComment(new Comment("1by1legobrick", "Brotato Chip"));
        video3.AddComment(new Comment("Jynxi", "lol"));
        video3.AddComment(new Comment("obssessiveNerd", "Best series of the decade"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"> {comment.GetUserName()}: {comment.GetComment()}");
            }

            Console.WriteLine();
        }
    }
}