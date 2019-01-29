using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.Processing.ToString());
            sb.Append("Client: ");
            sb.Append(Cliente.Name + "(" + Cliente.DataNascimento.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Order items: ");
            foreach (OrdemPedido op in OrdemPedido)
            {
                sb.Append(op.Produto.Nome+ ", $" + op.Preco.ToString(CultureInfo.InvariantCulture) + ", Quantidade: " + op.Quantidade +
                    ", SubTotal: " + op.SubTotal().ToString(CultureInfo.InvariantCulture));
                sb.AppendLine("");
            }
            sb.AppendLine("Total price: " + Total());

            return sb.ToString();
            
        }

    }
}
