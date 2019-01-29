using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumEComp.Classes
{
    class OrdemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public List<Produto> Produto { get; set; } = new List<Produto>();

        public OrdemPedido()
        {

        }

        public OrdemPedido(int quantidade, double preco)
        {
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
