using System;

class Program
{
    static void Main(string[] args)
    {

        // Create Comment 1.
        Comment comment1 = new Comment();
        comment1._commenter = "@apple5293";
        comment1._comment = "i never thought this would end";

        // Create Comment 2.
        Comment comment2 = new Comment();
        comment2._commenter = "@Veshiram";
        comment2._comment = "As Lofi Girl's teacher, I'm proud of seeing her study for 2 years. She aced the final test.";

        // Create Comment 3.
        Comment comment3 = new Comment();
        comment3._commenter = "@EIMINE";
        comment3._comment = "Finally lofi girl is ready for her exams";

        // Create Video 1.
        Video video1 = new Video();
        video1._title = "lofi hip hop radio - beats to relax/study to";
        video1._author = "@LofiGirl";
        video1._length = "75,037,431";
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        // Check number of comments
        video1.Number();

        // Display all.
        video1.Display();
    }
}