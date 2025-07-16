using System;
using System.Security.Cryptography.X509Certificates;

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

        // Create Comment 4.
        Comment comment4 = new Comment();
        comment4._commenter = "@EIMINE";
        comment4._comment = "Finally lofi girl is ready for her exams";
        // Create Comment 5.
        Comment comment5 = new Comment();
        comment5._commenter = "@EIMINE";
        comment5._comment = "Finally lofi girl is ready for her exams";
        // Create Comment 6.
        Comment comment6 = new Comment();
        comment6._commenter = "@EIMINE";
        comment6._comment = "Finally lofi girl is ready for her exams";

        // Create Video 2.
        Video video2 = new Video();
        video2._title = "lofi hip hop radio - beats to relax/study to";
        video2._author = "@LofiGirl";
        video2._length = "75,037,431";
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        // Create Comment 7.
        Comment comment7 = new Comment();
        comment7._commenter = "@EIMINE";
        comment7._comment = "Finally lofi girl is ready for her exams";
        // Create Comment 8.
        Comment comment8 = new Comment();
        comment8._commenter = "@EIMINE";
        comment8._comment = "Finally lofi girl is ready for her exams";
        // Create Comment 9.
        Comment comment9 = new Comment();
        comment9._commenter = "@EIMINE";
        comment9._comment = "Finally lofi girl is ready for her exams";

        // Create Video 3.
        Video video3 = new Video();
        video3._title = "lofi hip hop radio - beats to relax/study to";
        video3._author = "@LofiGirl";
        video3._length = "75,037,431";
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);



        // Check number of comments
        video1.Number();
        video2.Number();
        video3.Number();

        // Display all.
        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
    }
}