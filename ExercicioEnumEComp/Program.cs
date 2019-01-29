using ExercicioEnumEComp.Classes;
using System;
using System.Globalization;

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

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string _produtoNome = Console.ReadLine();
                Console.Write("Product price: ");
                double _produtoPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                Produto produto = new Produto(_produtoNome, _produtoPreco);
                OrdemPedido ordemPedido = new OrdemPedido(qtd, _produtoPreco, produto);
                o.AdicionarItem(ordemPedido);

            }
            Console.WriteLine(o);
        }
    }
}
