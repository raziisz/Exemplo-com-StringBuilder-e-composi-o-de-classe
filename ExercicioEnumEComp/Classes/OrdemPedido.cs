using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumEComp.Classes
{
    class OrdemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public OrdemPedido()
        {

        }

        public OrdemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            Preco = Produto.Preco;
            return Preco * Quantidade;
        }
    }
}
