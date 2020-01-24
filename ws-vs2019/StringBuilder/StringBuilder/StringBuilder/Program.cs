using System;
using Comentarios.Entities;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");

            Post p1 = new Post(
                DateTime.Parse("22/01/2020 13:05:44"),
                "Traveling to New Zealand",
                "I am going to visit this beatiful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the force be with you!");

            Post p2 = new Post(

                DateTime.Parse("20/01/2020 23:14:19"),
                "Good nighr guys!",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            
        }
    }
}
