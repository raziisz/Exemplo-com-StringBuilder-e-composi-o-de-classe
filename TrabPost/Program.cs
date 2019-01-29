using System;
using TrabPost.Classes;

namespace TrabPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Have a nice trip");
            Comentario c2 = new Comentario("Wow That's awesome!");
            Poste p1 = new Poste(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);
            p1.AddComentarios(c1);
            p1.AddComentarios(c2);

            Comentario c3 = new Comentario("Good night");
            Comentario c4 = new Comentario("May the Force be with you");
            Poste p2 = new Poste(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComentarios(c3);
            p2.AddComentarios(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
