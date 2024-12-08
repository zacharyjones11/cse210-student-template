using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitle("Python Programming Basics");
        video1.SetAuthor("CodeMaster");
        video1.SetLength(1200);  // 20 minutes

        Comment comment1 = new Comment();
        comment1.SetName("John Doe");
        comment1.SetText("Great tutorial for beginners!");
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2.SetName("Jane Smith");
        comment2.SetText("Very clear explanations!");
        video1.AddComment(comment2);

        Video video2 = new Video();
        video2.SetTitle("Machine Learning Fundamentals");
        video2.SetAuthor("AI Insights");
        video2.SetLength(1800);  // 30 minutes

        Comment comment3 = new Comment();
        comment3.SetName("Alex Johnson");
        comment3.SetText("Excellent introduction to ML concepts");
        video2.AddComment(comment3);

        Comment comment4 = new Comment();
        comment4.SetName("Sarah Lee");
        comment4.SetText("Can you do a follow-up on deep learning?");
        video2.AddComment(comment4);

        Video video3 = new Video();
        video3.SetTitle("Web Development Crash Course");
        video3.SetAuthor("DevTech");
        video3.SetLength(2400);  // 40 minutes

        Comment comment5 = new Comment();
        comment5.SetName("Mike Brown");
        comment5.SetText("This helped me so much!");
        video3.AddComment(comment5);

        Comment comment6 = new Comment();
        comment6.SetName("Emily White");
        comment6.SetText("Great overview of web technologies");
        video3.AddComment(comment6);

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine(); 
        }
    }
}