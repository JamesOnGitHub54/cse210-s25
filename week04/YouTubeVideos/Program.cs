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
        comment4._commenter = "@Astro5793";
        comment4._comment = "Can the fish swim between the lanes?";
        // Create Comment 5.
        Comment comment5 = new Comment();
        comment5._commenter = "@NGC1232";
        comment5._comment = "Scrat WILL have a picture in the hall of fame, he is a legend";
        // Create Comment 6.
        Comment comment6 = new Comment();
        comment6._commenter = "@Aqua-v2u";
        comment6._comment = "Congrats those fish are cool looking";

        // Create Video 2.
        Video video2 = new Video();
        video2._title = "Scrat will be our GOLDFISH PIONEER";
        video2._author = "@lukesgoldies";
        video2._length = "68";
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        // Create Comment 7.
        Comment comment7 = new Comment();
        comment7._commenter = "@mc_jojo3";
        comment7._comment = "Yoo I have that CPU, it works fine to this day thank you very much";
        // Create Comment 8.
        Comment comment8 = new Comment();
        comment8._commenter = "@kaz7886";
        comment8._comment = "I was considering it honestly. If i have to both edit, do 3d models, and do gaming.. it's worth it.";
        // Create Comment 9.
        Comment comment9 = new Comment();
        comment9._commenter = "@racergsxr1";
        comment9._comment = "I have a 9800X3D in the mail, upgrading from an 8700k, can't wait!";
        // Create Comment 10.
        Comment comment10 = new Comment();
        comment10._commenter = "@Daniel_Oliv";
        comment10._comment = "I got mine for almost 9 years now .... i believe i should change it";

        // Create Video 3.
        Video video3 = new Video();
        video3._title = "Is the AMD X3D CPU Worth It?";
        video3._author = "@METAPCs";
        video3._length = "52";
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);



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