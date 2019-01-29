using ExercicioEnumEComp.Classes;
using System;

namespace ExercicioEnumEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Cliente cl = new Cliente(name, email, dt);

            Ordem o = new Ordem(DateTime.Now, os, cl);
        }
    }
}
