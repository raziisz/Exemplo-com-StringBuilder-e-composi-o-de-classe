using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumEComp.Classes
{
    class Ordem
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrdemPedido> OrdemPedido { get; set; } = new List<OrdemPedido>();


        public Ordem()
        {

        }

        public Ordem(DateTime date, OrderStatus status, Cliente cliente)
        {
            Date = date;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(OrdemPedido item)
        {
            OrdemPedido.Add(item);
        }

        public void RemoveItem(OrdemPedido item)
        {
            OrdemPedido.Remove(item);
        }

        public double Total()
        {
            double total =0.0;
            foreach (OrdemPedido op in OrdemPedido)
            {
                total += op.SubTotal();
            }
            return total;
        }

    }
}
